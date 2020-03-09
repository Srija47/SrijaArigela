using HandsOnCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnCodeFirst.Context
{
    class MyContext:DbContext
    {
        //Define Entities
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-A63MUHA\SQLEXPRESS;Initial Catalog=StudentDB;Persist Security Info=True;User ID=sa;Password=pass@word1");
        }
    }
}
