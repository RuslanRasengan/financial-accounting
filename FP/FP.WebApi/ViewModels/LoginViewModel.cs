﻿using System.ComponentModel.DataAnnotations;

namespace FP.WebApi.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
