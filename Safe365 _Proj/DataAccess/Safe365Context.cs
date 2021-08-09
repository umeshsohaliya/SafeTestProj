using System;
using Microsoft.EntityFrameworkCore;
using Safe365__Proj.Model;

namespace Safe365__Proj.DataAccess
{
    public class Safe365Context : DbContext
    {

        public Safe365Context(DbContextOptions options)
         : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                   new Customer
                   {
                       CustomerId = 1,
                       FirstName = "personA",
                       LastName = "LastNameA",
                       DateOfBirth = DateTime.Now,
                       BusinessName = "beerpub@gmail.com",
                       DateCreated = DateTime.Now
                   },
                   new Customer
                   {
                       CustomerId = 2,
                       FirstName = "PersonB",
                       LastName = "LastNameB",
                       DateOfBirth = DateTime.Now,
                       BusinessName = "beerpub@gmail.com",
                       DateCreated = DateTime.Now
                   }
               ) ;
        }
    }
}
