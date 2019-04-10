using ASP_Final_Project_Shopping.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Shopping.Models
{
    public class Product
    {
        public Product()
        {
            Images = new HashSet<Image>();
        }

        public int Id { get; set; }

        [StringLength(200), Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        public double SalePrice { get; set; }

        public string Description { get; set; }

        public bool OnSale { get; set; }

        public int ReviewCount { get; set; }

        public double ReviewAverage { get; set; }

        [StringLength(100)]
        public string Department { get; set; }

        [StringLength(100)]
        public string Class { get; set; }

        [StringLength(100)]
        public string SubClass { get; set; }

        [StringLength(100)]
        public string Color { get; set; }

        [StringLength(100)]
        public string Weight { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual CartItem CartItem { get; set; }
    }
}
