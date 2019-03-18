using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			var userNumbers = new Queue<int>();

			Console.WriteLine("Enter tne number or commands: \"run\" or \"exit\" ");
			while (true)
			{
				string userString = Console.ReadLine();

				if(userString == "exit")
				{
					Console.WriteLine($"The number of left tasks: {userNumbers.Count}");
					break;
				}

				if(userString == "run")
				{
					while(userNumbers.Count != 0)
					{
						Console.WriteLine("Root of " + userNumbers.Peek() + " is " + Math.Sqrt(userNumbers.Peek()));
						userNumbers.Dequeue();
					}

					continue;
				}

				try
				{
					userNumbers.Enqueue(int.Parse(userString));
				}
				catch (FormatException e)
				{
					Console.WriteLine("The Number is not int! Try another");
					continue;
				}
				catch (OverflowException e)
				{
					Console.WriteLine("The Number is too big! Try another");
					continue;
				}
			}
		}
	}
}
