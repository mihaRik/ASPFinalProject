using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Shopping.Models.API
{
    public class APICategory
    {
        public class Category
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class CustomAPICategory
        {
            public int from { get; set; }
            public int to { get; set; }
            public int currentPage { get; set; }
            public int total { get; set; }
            public int totalPages { get; set; }
            public string queryTime { get; set; }
            public string totalTime { get; set; }
            public bool partial { get; set; }
            public string canonicalUrl { get; set; }
            public List<Category> categories { get; set; }
        }
    }
}
