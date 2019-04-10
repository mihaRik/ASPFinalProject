using ASP_Final_Project_Shopping.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Shopping.Data
{
    public class ProductContext : IdentityDbContext<ApplicationUser>
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "5fa9bc83-e364-4219-927d-5cad3c414b2d",
                                   Name = Data.Roles.Admin,
                                   NormalizedName = Data.Roles.Admin.ToUpper() },
                new IdentityRole { Id = "26e8f3a2-6cbb-440f-a02a-b9e20193c557",
                                   Name = Data.Roles.Member,
                                   NormalizedName = Data.Roles.Member.ToUpper() });
                }
    }
}
