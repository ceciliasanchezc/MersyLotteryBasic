﻿namespace Mersy.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class LoginViewModel
    {
        [Required]
       // [EmailAddress]
        [Display(Name = "Email")]
        public string Username { get; set; }

        [Required]
        [MinLength(4)]
        public string Password { get; set; }

        [Display(Name = "Recordamos este dispositivo?")]
        public bool RememberMe { get; set; }
    }
}
