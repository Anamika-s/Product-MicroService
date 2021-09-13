using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Category>()
                .HasData(
                new Category() { Id = 1, Name = "Electronics", Description = "Electronics Items" },
                  new Category() { Id = 2, Name = "Clothes", Description = "Dresses" },

                    new Category() { Id = 3, Name = "Grocery", Description = "Grocery Items" }

                );
            builder.Entity<Product>()
                 .HasOne<Category>(s => s.Category)
                  .WithMany(g => g.Products)
                  .HasForeignKey(s => s.CategoryId);


        }
    }
}
