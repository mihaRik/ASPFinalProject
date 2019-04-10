using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Final_Project_Shopping.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using ASP_Final_Project_Shopping.Models;

namespace ASP_Final_Project_Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ProductContext _db;

        public CategoryController(ProductContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Categories.Take(10));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid) return View(category);

            await _db.Categories.AddAsync(category);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var cat = _db.Categories.Find(id);

            if (cat == null) return NotFound();

            return View(cat);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Category cat)
        {
            if (!ModelState.IsValid) return View(cat);

            _db.Entry(cat).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var cat = _db.Categories.Find(id);

            if (cat == null) return NotFound();

            return View(cat);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var cat = _db.Categories.Find(id);
            _db.Entry(cat).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}