using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите радиус: ");
			double radius = double.Parse(Console.ReadLine());
			double circleS = Math.PI * Math.Pow(radius, 2);
			Console.WriteLine("Площадь круга: {0}", circleS);
		}
	}
}
