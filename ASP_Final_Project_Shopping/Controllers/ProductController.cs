using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Final_Project_Shopping.Data;
using ASP_Final_Project_Shopping.Models;
using ASP_Final_Project_Shopping.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Final_Project_Shopping.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductController(ProductContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var product = _db.Products.Find(id);

            if (product == null) return NotFound();

            var vm = new ProductDetailsViewModel
            {
                Product = product,
                DealsOfTheWeek = _db.Products.Where(p => p.OnSale).Skip(100).Take(9)
            };

            return View(vm);
        }

        [Authorize(Roles = Roles.Member)]
        private async Task<IActionResult> AddToFavorites(int? id)
        {
            if (id == null) return NotFound();

            var product = _db.Products.Find(id);

            if (product == null) return NotFound();

            var user = await _userManager.GetUserAsync(User);
            if (user.Favorites.Any(f => f.Id == id))
            {
                user.Favorites.Remove(user.Favorites.First(f => f.Id == id));
                await _db.SaveChangesAsync();
                return Json(new
                {
                    code = 200,
                    data = "Removed from favorites.",
                    descp = "You always can add this product back to favorite list."
                });
            };
            product.UserId = user.Id;

            _db.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _db.SaveChangesAsync();

            return Json(new
            {
                code = 200,
                data = "Product added to favorites",
                descp = "You can check favorite products in fav list menu."
            });
        }

        public async Task<IActionResult> CheckAuthorize(int? id)
        {
            if (User.Identity.IsAuthenticated)
            {
                var role = await _userManager.GetRolesAsync(await _userManager.GetUserAsync(User));

                if (role.Any(r => r == Roles.Member))
                {
                    return await AddToFavorites(id);
                }
                return Json(new { code = 404, data = "Access denied." });
            }

            return Json(new { code = 404, data = "Please login." });
        }

        [Authorize(Roles = Roles.Member)]
        public async Task<IActionResult> Favorites()
        {
            var user = await _userManager.GetUserAsync(User);

            var vm = new ProductFavoritesViewModel
            {
                Favorites = user.Favorites,
                DealsOfTheWeek = _db.Products.Where(p => p.OnSale).Skip(100).Take(9)
            };

            return View(vm);
        }

        [Authorize]
        public async Task<IActionResult> Cart()
        {
            var user = await _userManager.GetUserAsync(User);

            return View(user.Cart);
        }

        [Authorize]
        public async Task<IActionResult> AddToCart(int id, int quantity)
        {
            var product = _db.Products.Find(id);

            var cartItem = new CartItem
            {
                ProductId = id,
                UserId = _userManager.GetUserId(User),
                Quantity = quantity
            };

            await _db.CartItems.AddAsync(cartItem);
            await _db.SaveChangesAsync();

            return Json(new { code = 200, data = "Congratilations!", descp = "Product added to cart" });
        }
    }
}