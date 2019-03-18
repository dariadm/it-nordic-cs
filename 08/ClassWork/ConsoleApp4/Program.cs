using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<int> userPlates = new Stack<int>();

			Console.WriteLine("*******Dishwhashing*******");
			Console.WriteLine("Enter commands: \"wash\", \"dry\" or \"exit\"");

			string userCommand;

			while(true)
			{
				userCommand = Console.ReadLine().ToLower();
				if(userCommand == "wash")
				{
					userPlates.Push(1);
					Console.WriteLine($"The nummber of plates to dry is: {userPlates.Count}");
					continue;
				}
				else if(userCommand == "dry")
				{
					if (userPlates.Count != 0)
						userPlates.Pop();
					else
						Console.WriteLine("There are no plates to dry!");

					Console.WriteLine($"The nummber of plates to dry is: {userPlates.Count}");
					continue;
				}
				else if(userCommand == "exit")
				{
					Console.WriteLine($"The nummber of plates to dry is: {userPlates.Count}");
					Console.WriteLine("Finished");
					break;
				}
			}
		}
	}
}
