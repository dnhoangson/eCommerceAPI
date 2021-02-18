using eCommerceAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace eCommerceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _config;

        public UserController(UserManager<ApplicationUser> userManager, IConfiguration config)
        {
            _userManager = userManager;
            _config = config;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterModel model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existUser = await _userManager.FindByNameAsync(model.Username);
            if (existUser != null)
            {
                return StatusCode(500);
            }

            ApplicationUser user = new ApplicationUser()
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
            return Ok("User successfully created!");
        }

        [HttpGet]
        [Route("Login")]
        public async Task<IActionResult> Login()
        {
            throw new NotImplementedException();
        }
    }
}
