using Microsoft.EntityFrameworkCore;
using SampleProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.Data
{
    public class SampleContext : DbContext
    {
        public SampleContext(DbContextOptions<SampleContext>options)
            :base(options)
        {

        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> Items { get; set; }
    }
}
