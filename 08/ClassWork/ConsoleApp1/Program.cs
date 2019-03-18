using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> intList = new List<int>();
			intList.Add(10);
			intList.Add(20);
			intList.Add(30);
			intList.Add(40);

			List<int> intList2 = new List<int> { 10, 20, 30, 40 };
			intList.AddRange(new[] { 50, 60 });
			intList.RemoveRange(1, 2);
			intList.RemoveAt(3);

			Console.WriteLine(string.Join(", ", intList));
			Console.WriteLine(string.Join(", ", intList2));

			var c = new Dictionary<int, int>();
			c.Add(1, 2);
			//c.Add(1, 3);
			c[1] = 3;

			foreach (var currentPair in c)
			{
				Console.WriteLine(currentPair.Key + " - " + currentPair.Value);
			}
		}
	}
}
