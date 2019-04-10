using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ASP_Final_Project_Shopping.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using static ASP_Final_Project_Shopping.Models.API.APICategory;
using static ASP_Final_Project_Shopping.Models.API.APIProduct;

namespace ASP_Final_Project_Shopping.Controllers
{
    public class APIController : Controller
    {
        private const string _apiKey = "IoppFn9EY3GaTkYGS6DHPipH";
        private readonly ProductContext _db;

        public APIController(ProductContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Category(int id)
        {
            if (id == 69)
            {
                var client = new RestClient("https://api.bestbuy.com");
                for (int page = 1; page < 40; page++)
                {
                    var request = new RestRequest($"/v1/categories?format=json&show=id,name&apiKey={_apiKey}&pageSize=100&page={page}",
                                                    Method.GET);
                    var response = client.Execute<CustomAPICategory>(request);

                    var catList = new List<Models.Category>();

                    var cats = response?.Data?.categories;
                    if (cats != null)
                    {
                        foreach (var cat in cats)
                        {
                            var category = new Models.Category
                            {
                                CategoryName = cat.name,
                                APICategoryId = cat.id
                            };
                            catList.Add(category);
                        }

                        await _db.Categories.AddRangeAsync(catList);
                        await _db.SaveChangesAsync();
                    }
                }
            }
            return Content("status: 200 OK");
        }

        public async Task<IActionResult> Products(int id)
        {
            if (id == 69)
            {
                var client = new RestClient("https://api.bestbuy.com");

                foreach (var category in _db.Categories.ToList())
                {
                    if (category.Id != 1110)
                    {
                        var request = new RestRequest($"/v1/products(categoryPath.id={category.APICategoryId})?format=json&apiKey={_apiKey}&pageSize=100&page=1",
                                                                        Method.GET);
                        var response = client.Execute<CustomAPIProduct>(request);

                        var prods = response.Data?.products;

                        if (prods != null && prods.Count != 0)
                        {
                            foreach (var prod in prods)
                            {
                                var product = new Models.Product
                                {
                                    Name = prod.name,
                                    CategoryId = category.Id,
                                    Class = prod.@class,
                                    Color = prod.color ?? "black",
                                    Department = prod.department,
                                    Description = prod.longDescription ?? prod.description.ToString() ?? prod.shortDescription ?? "Has not description.",
                                    OnSale = prod.onSale ?? false,
                                    ReviewAverage = prod.customerReviewAverage ?? 0,
                                    ReviewCount = prod.customerReviewCount ?? 0,
                                    Price = prod.regularPrice ?? 24.99,
                                    SalePrice = prod.salePrice ?? 24.99,
                                    SubClass = prod.subclass,
                                    Weight = prod.weight
                                };

                                await _db.Products.AddAsync(product);
                                await _db.SaveChangesAsync();

                                var images = new List<Models.Image>
                                    {
                                        new Models.Image{ FromServer = false, ProductId = product.Id, ImageUrl = prod.image },
                                        new Models.Image{ FromServer = false, ProductId = product.Id, ImageUrl = prod.largeFrontImage },
                                        new Models.Image{ FromServer = false, ProductId = product.Id, ImageUrl = prod.mediumImage },
                                        new Models.Image{ FromServer = false, ProductId = product.Id, ImageUrl = prod.largeImage },
                                        new Models.Image{ FromServer = false, ProductId = product.Id, ImageUrl = prod.alternateViewsImage }
                                    };

                                await _db.Images.AddRangeAsync(images);
                                await _db.SaveChangesAsync();
                            }
                        }
                    }
                }
            }
            return Content("status 200 OK");
        }
    }
}