using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			var Capitals = new Dictionary<string, string>
			{
				{"Paris", "France"},
				{"Moscow", "Russia"},
				{"Berlin", "Germany"},
				{"London", "Great Britain"}
			};

			var values = Capitals.Values;
			var keys = Capitals.Keys;

			while (true)
			{
				int i = (new Random()).Next(Capitals.Count);
				var currentPair = Capitals.ElementAt(i);

				Console.WriteLine("Capital of " + currentPair.Value  + " is: ");
				string userAnswer = Console.ReadLine();
				// var answer = Console.ReadLine()?.Trim();

				if(currentPair.Key.ToLower() == userAnswer.ToLower())
				{
					Console.WriteLine("You're right! Let's continue");
				}
				else
				{
					Console.WriteLine("You're failed :(");
					break;
				}
			}
		}
	}
}
