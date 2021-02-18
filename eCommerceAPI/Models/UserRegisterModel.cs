﻿using System.ComponentModel.DataAnnotations;

namespace eCommerceAPI.Models
{
    public class UserRegisterModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
