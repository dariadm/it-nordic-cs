using System;
using System.Collections.Generic;
using System.Text;
using Ef_Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Ef_Core.Data
{
    public class OnlineStoreContext : DbContext
    {
        private string _connectionString;

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public OnlineStoreContext()
        {
            _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;"
                + "Initial Catalog=OnlineStoreEF;"
                + "Integrated Security=true";
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Customer>().HasAlternateKey(c => c.Name)
                .HasName("UQ_Customers_Name");
            modelBuilder
                .Entity<OrderItem>()
                    .HasKey("OrderId", "ProductId")
                    .HasName("PK_OrdeItems");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString); 
        }
    }
}
