using System;

namespace ClassApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Pet pet1 = new Pet();
			pet1.Name = "Barsik";
			pet1.Kind = "Cat";
			pet1.DateOfBirth = DateTimeOffset.Parse("2017-02-02");
			pet1.Sex = 'M';

			pet1.WriteDescription(false);

			Pet pet2 = new Pet
			{
				Name = "Sharik",
				Kind = "Dog",
				DateOfBirth = DateTimeOffset.Parse("2016-02-02"),
				Sex = 'M'
			};

			pet2.WriteDescription(true);
		}
	}
}
