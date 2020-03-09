using System;
using System.Collections.Generic;
using System.Text;
using EFDALAssignment.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDALAssignment.Context
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-A63MUHA\SQLEXPRESS;Initial Catalog=ItemDB;User ID=sa;Password=pass@word1");
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}
