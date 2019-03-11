using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] myNumbers = {2, 34, 1, 23, 4};

			int currentSum = 0;
			int i = 0;

			while (i != myNumbers.Length)
			{
				currentSum += myNumbers[i];
				Console.WriteLine($"Current sum is: {currentSum}");

				++i;
			};
		}
	}
}
