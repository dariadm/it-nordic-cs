using System;

namespace ClassApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter \"exit\" to finish");
			Console.WriteLine("Enter the string:");

			do
			{
				string s = Console.ReadLine();

				if (s == "exit")
					break;

				if (s.Length <= 15)
					Console.WriteLine($"Entered string lenghth is {s.Length}");
				else
				{
					Console.WriteLine("Too long string! Try another.");
					continue;
				}
			}while (true);
		}
	}
}
