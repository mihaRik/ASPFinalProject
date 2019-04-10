using ASP_Final_Project_Shopping.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Shopping.Extensions
{
    public static class SelectListExtension
    {
        public static IEnumerable<SelectListItem> ToSelectList(this IEnumerable<Category> categories)
        {
            foreach (var cat in categories)
            {
                yield return new SelectListItem
                {
                    Value = cat.Id.ToString(),
                    Text = cat.CategoryName
                };
            }
        }
    }
}
