using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Shopping.Models
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string APICategoryId { get; set; }

        [StringLength(200)]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
