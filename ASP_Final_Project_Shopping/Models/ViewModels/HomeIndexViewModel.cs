using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Shopping.Models.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Product> SelectedProducts { get; set; }
        public IEnumerable<Product> ComingProducts { get; set; }
        public IEnumerable<Product> ExclusiveProducts { get; set; }
        public IEnumerable<Product> DealsOfTheWeek { get; set; }
        public IEnumerable<Product> BannerProducts { get; set; }
    }
}
