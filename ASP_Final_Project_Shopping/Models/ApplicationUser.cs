﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Shopping.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Favorites = new HashSet<Product>();
            Cart = new HashSet<CartItem>();
        }

        [StringLength(50)]
        public string Firstname { get; set; }

        [StringLength(50)]
        public string Lastname { get; set; }

        public string Fullname
        {
            get
            {
                return $"{Firstname} {Lastname}";
            }
        }

        public DateTime Birthdate { get; set; }

        [StringLength(300)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        public virtual ICollection<Product> Favorites { get; set; }

        public virtual ICollection<CartItem> Cart { get; set; }
    }
}
