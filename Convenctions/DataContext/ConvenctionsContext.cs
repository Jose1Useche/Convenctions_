using Convenctions.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Convenctions.DataContext
{
    public class ConvenctionsContext : DbContext
    {
        //The name of these properties are declared in plural

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }

        //We can use "OnModelCreating" Method to manipulate the properties/columns of the clases/tables that are involved into the context.
        //This method is optional, We can use DataAnotation against the "OnModelCreating"

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}