using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP_Final_Project_Shopping.Models;
using Microsoft.AspNetCore.Authorization;
using ASP_Final_Project_Shopping.Data;
using ASP_Final_Project_Shopping.Models.ViewModels;

namespace ASP_Final_Project_Shopping.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductContext _db;

        public HomeController(ProductContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var vm = new HomeIndexViewModel
            {
                SelectedProducts = _db.Products.Take(8),
                ComingProducts = _db.Products.Skip(8).Take(8),
                ExclusiveProducts = _db.Products.Where(p => p.Images.FirstOrDefault().ImageUrl != null).Skip(16).Take(5),
                DealsOfTheWeek = _db.Products.Where(p => p.OnSale).Skip(50).Take(9),
                BannerProducts = _db.Products.Where(p => p.OnSale).Take(2)
            };
            return View(vm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
