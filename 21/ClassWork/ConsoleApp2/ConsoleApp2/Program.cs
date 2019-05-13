using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			var sum = 0
				do
			{
				try
				{
					var i = int Parse(Console.ReadLine());
					sum += i
				}
				catch (FormatException)
				{

				}
			}
		}
	}
}
