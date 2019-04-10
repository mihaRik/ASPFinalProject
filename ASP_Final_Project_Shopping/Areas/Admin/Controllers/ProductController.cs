using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Final_Project_Shopping.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Final_Project_Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly ProductContext _db;

        public ProductController(ProductContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Products.Take(50));
        }
    }
}