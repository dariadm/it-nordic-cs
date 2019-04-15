using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculation myCalculation = new Calculation(new[] { 1, 4, -5 });
			int result = myCalculation.CalcSingleValue((int[] array) =>
			{
				int sum = 0;
				foreach (var i in array)
					sum += i;
				return sum / array.Length;
			});

			Console.WriteLine(result);
		}
	}
}
