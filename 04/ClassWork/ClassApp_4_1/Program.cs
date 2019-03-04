using System;

namespace ClassApp_4_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the number:");
			int x = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the number:");
			int y = int.Parse(Console.ReadLine());


			Console.WriteLine($"{x} == {y}: {x == y}");
			Console.WriteLine($"{x} != {y}: {x != y}");
			Console.WriteLine($"{x} > {y}: {x > y}");
			Console.WriteLine($"{x} < {y}: {x < y}");
			Console.WriteLine($"{x} >= {y}: {x >= y}");
			Console.WriteLine($"{x} <= {y}: {x <= y}");
		}
	}
}
