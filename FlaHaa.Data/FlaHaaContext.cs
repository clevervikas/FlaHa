using FlaHa.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FlaHaa.Data
{
    public class FlaHaaContext :DbContext
    {
        public FlaHaaContext(DbContextOptions<FlaHaaContext> options) : base(options) { }
        
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Customer>().HasData(new Customer { Name = "dsSDFDf", Address = "dscfsdcf" });
        }

        //Test ata

    }
}
