using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Shopping.Models.ViewModels
{
    public class ProductFavoritesViewModel
    {
        public IEnumerable<Product> Favorites { get; set; }
        public IEnumerable<Product> DealsOfTheWeek { get; set; }
    }
}
