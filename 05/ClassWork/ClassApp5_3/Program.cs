using System;

namespace ClassApp5_3
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Число {0}", ((int.Parse(Console.ReadLine())) < 0) ? "отрицательное" : "неотрицательное");

				//throw new Exception("dsfsdfsfsf");
				//Console.WriteLine("Число" + ((int.Parse(Console.ReadLine()) < 0) ? " отрицательное" : " неотрицательное"));
			}
			catch (FormatException e)
			{
				Console.WriteLine("Введены неверные данные!");
				throw;
			}
		}
	}
}
