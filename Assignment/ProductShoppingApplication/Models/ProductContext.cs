using Microsoft.EntityFrameworkCore;
using System;


namespace ProductShoppingApplication.Models
{
    public class ProductContext : DbContext
    {
        //connection to the database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=KANINI-LTP-474\KANINISQLSERVER;Integrated Security=true;Initial Catalog=ProductsDB");
        }
        //create a table names Products
        public DbSet<Product> Products { get; set; }

        //seeding some intial data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = 101,
                Name = "Mobiles",
                Price = 10000,
                Quantity = 10
            });
        }
    }
}
