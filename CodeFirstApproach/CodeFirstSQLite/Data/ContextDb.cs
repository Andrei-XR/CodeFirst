using CodeFirstSQLite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstSQLite.Data
{
    public class ContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite(@"Data Source=C:\SampleDb.db");
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
