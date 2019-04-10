using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Shopping.Models
{
    public class LoginModel
    {
        [StringLength(100), EmailAddress, Required]
        public string Email { get; set; }

        [StringLength(100), Required]
        public string Password { get; set; }

        [Display(Name = "Remmember me?")]
        public bool RemmemberMe { get; set; }
    }
}
