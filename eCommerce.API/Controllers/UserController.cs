using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using eCommerce.Domain.Users;
using eCommerce.API.Models;
using eCommerce.Domain.Identity;
using eCommerce.Domain.Interfaces;

namespace eCommerce.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<Identity> _userManager;
        private readonly IConfiguration _config;
        private IUnitOfWork _unitOfWork;

        public UserController(UserManager<Identity> userManager, IConfiguration config, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _config = config;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existUser = await _userManager.FindByNameAsync(model.Username);
            if (existUser != null)
            {
                return StatusCode(500);
            }

            Identity user = new Identity()
            {
                UserName = model.Username,
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return StatusCode(500);
            }

            var userData = new User
            {
                UserIdentity = user.Id
            };
            await _unitOfWork.UserRepository.Add(userData);
            await _unitOfWork.Complete();

            return Ok("User successfully created!");
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return Unauthorized();
            }
            else
            {
                var existingUser = await _userManager.FindByNameAsync(model.Username);

                if (existingUser != null && await _userManager.CheckPasswordAsync(existingUser, model.Password))
                {
                    var userRoles = await _userManager.GetRolesAsync(existingUser);

                    var authClaims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, existingUser.UserName),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    };

                    foreach (var role in userRoles)
                    {
                        authClaims.Add(new Claim(ClaimTypes.Role, role));
                    }

                    var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Secret"]));

                    var token = new JwtSecurityToken(
                        issuer: _config["JWT:ValidIssuer"],
                        audience: _config["JWT:ValidAudience"],
                        expires: DateTime.Now.AddHours(1.5),
                        claims: authClaims,
                        signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                        );

                    return Ok(new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token),
                        expiration = token.ValidTo,
                    });
                }
                else
                {
                    return Unauthorized();
                }
            }
        }
    }
}
