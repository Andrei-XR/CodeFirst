using CodeFirstPostgreSql.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstPostgreSql.Data
{
    public class ShoppeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseNpgsql(Environment.GetEnvironmentVariable("StrConDb"));
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; } 
    }
}
