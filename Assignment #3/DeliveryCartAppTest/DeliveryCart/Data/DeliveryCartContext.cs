using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeliveryCart.Models;

namespace DeliveryCart.Data
{
    public class DeliveryCartContext : DbContext
    {
        public DeliveryCartContext (
            DbContextOptions<DeliveryCartContext> options)
            : base(options)
        {
        }

        public DbSet<DeliveryCart.Models.Products> Products { get; set; }

        public DbSet<DeliveryCart.Models.Customer> Customer { get; set; }

        public DbSet<DeliveryCart.Models.Shopper> Shopper { get; set; }

        public DbSet<DeliveryCart.Models.Order> Order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Shopper>().ToTable("Shopper");
            modelBuilder.Entity<Order>().ToTable("Order");
        }
    }
}