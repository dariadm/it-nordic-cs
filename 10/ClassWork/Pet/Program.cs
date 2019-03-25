using System;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			Pet pet1 = new Pet();
			pet1.Name = "Barsik";
			pet1.Kind = "Cat";
			pet1.Age = 2;
			pet1.Sex = 'M';

			Console.WriteLine(pet1.Description);

			Pet pet2 = new Pet
			{
				Name = "Sharik",
				Kind = "Dog",
				Age = 3,
				Sex = 'M'
			};

			Console.WriteLine(pet2.Description);
		}
	}
}
