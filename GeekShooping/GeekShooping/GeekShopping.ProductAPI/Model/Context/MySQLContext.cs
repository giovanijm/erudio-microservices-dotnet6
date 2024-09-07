using Microsoft.EntityFrameworkCore;
using System;

namespace GeekShopping.ProductAPI.Model.Context;

public class MySQLContext : DbContext
{
    public MySQLContext(){}
    public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }
    public DbSet<Product>? Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        for (int i = 0; i < 15; i++)
        {
            Random randNum = new Random();

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3+i,
                Name = string.Format("Produto {0}", randNum.Next(100, 200)),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Price = new decimal(randNum.Next(1000, 9000)/100),
                CategoryName = "T-Shirt",
                ImageUrl = "https://d2byg56fbf6u3p.cloudfront.net/1066/imagens/1028934419651dc879a7fc36.88469426.1696450681_l.jpg"
            });
        }
        
    }
}
