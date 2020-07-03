using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Data Source=(localdb)\MSSQLLocalDB;Initial catalog=Northwind;integrated security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
