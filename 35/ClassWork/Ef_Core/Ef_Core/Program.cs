using Ef_Core.Data;
using Ef_Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Ef_Core
{
    class Program
    {
		private static OnlineStoreContext _context = new OnlineStoreContext(); 

        static void Main(string[] args)
        {
			//Console.WriteLine("Hello World!");
			//InsertCustomers(); 
			//InsertProducts(); 
			//SelectCustomers();
			//MoreQueries();
			//SelectProducts(); 
			//UpdateCustomers();

			//UpdateProductsDisconnected(); 
			DeleteCustomers(); 
		}

		private static void DeleteCustomers()
		{
			var customer = new Customer
			{
				Id = 3
			};

			_context.Customers.Remove(customer);
			_context.SaveChanges(); 
		}

		private static void UpdateProductsDisconnected()
		{
			var product = new Product
			{
				Id = 1,
				Name = "Test1",
				Price = 10M - 10M * 0.1M
			};

			using (var newContext = new OnlineStoreContext())
			{
				newContext.Products.Update(product);
				newContext.SaveChanges();
			}
		}

		private static void MoreQueries()
		{
			//_context.Customers.Where(c => c.Name.StartsWith("D")).ToList(); ;

			//var customers = _context
			//	.Customers
			//	.OrderBy(c => c.Id)
			//	.Last(c => c.Name.Length > 2); 
		}

		private static void InsertCustomers()
		{
			var customer = new Customer { Name = "Maria" };
			var customerSet = new Customer[]
			{
				new Customer {Name = "Sergei"},
				new Customer{Name = "Olga"}
			};

			using (var context = new OnlineStoreContext())
			{
				//context.Customers.Add(customer);
				context.Add(customer);
				context.AddRange(customerSet);
				context.SaveChanges();
			}
		}

		private static void InsertProducts()
		{
			var product = new Product { Name = "Часы MiBand", Price = 2000 };

			//var productSet = new Product[]
			//{
			//	new Product {Name = "Телевизор Samsung", Price = 50000},
			//	new Product {Name = "Ноутбук Dell", Price = 50000}
			//};

			var productSet = new Product[]
			{
				new Product {Name = "Планшет Lenovo", Price = 10000},
				new Product {Name = "Телефон Asus", Price = 10000}
			};

			using (var context = new OnlineStoreContext())
			{
				//context.Add(product);
				context.AddRange(productSet);
				context.SaveChanges(); 
			}
		}

		private static void SelectCustomers()
		{
			using (var context = new OnlineStoreContext())
			{
				//var name = "Sergei";
				//var allCustomers = context
				//	.Customers
				//	.Where(c => c.Name == name)
				//	.ToList();
				var customers = context.Customers.ToList();
				foreach (var customer in customers)
				{
					Console.WriteLine($"Customer '{customer.Name}' has ID = {customer.Id}");
				}
			}
		}

		private static void SelectProducts()
		{
			using (var context = new OnlineStoreContext())
			{
				//var products = context
				//	.Products
				//	.Where(p => p.Price > 10000)
				//	.ToList(); 

				//foreach(var product in products)
				//{
				//	Console.WriteLine($"{product.Name}({product.Id}) : {product.Price}");
				//}

				var products = _context
					.Products
					.Where(c => EF.Functions.Like(c.Name, "Теле%"))
					.ToList();

				foreach (var product in products)
				{
					Console.WriteLine($"{product.Name}({product.Id}) : {product.Price}");
				}
			}
		}

		private static void UpdateCustomers()
		{
			var customer = _context.Customers.First();
			customer.Name = "Mrs. " + customer.Name;
			_context.SaveChanges(); 
		}
	}
}
