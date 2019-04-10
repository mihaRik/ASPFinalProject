using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Shopping.Models
{
    public class Image
    {
        public int Id { get; set; }

        public bool FromServer { get; set; }

        [StringLength(300)]
        public string ImageUrl { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
