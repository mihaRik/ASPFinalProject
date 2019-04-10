using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Shopping.Models
{
    public class RegisterModel
    {
        [Required, StringLength(100), EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(100)]
        public string Password { get; set; }

        [Compare(nameof(Password))]
        [Display(Name = "Confirm password")]
        public string ConfirmPassword { get; set; }
    }
}
