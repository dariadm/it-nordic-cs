using System;
using System.Collections.Generic;
using System.Text;
using Ef_Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace Ef_Core.Data
{
    public class OnlineStoreContext : DbContext
    {
        private string _connectionString;

		public static readonly LoggerFactory MyConsoleLoggingFactory =
			new LoggerFactory(new[]
			{
				new ConsoleLoggerProvider(
					(category, level) =>
						category == DbLoggerCategory.Database.Command.Name
						&& level == LogLevel.Information,
					true)
			});

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
                .Entity<Customer>()
				.HasIndex(c => c.Name)
                .IsUnique();
            modelBuilder
                .Entity<OrderItem>()
                    .HasKey("OrderId", "ProductId")
                    .HasName("PK_OrdeItems");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			optionsBuilder
				.UseLoggerFactory(MyConsoleLoggingFactory)
				.UseSqlServer(_connectionString)
				.EnableSensitiveDataLogging(true);
		}
    }
}
