using System;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			var marks = new[]
			{
				new [] {2, 3, 3, 2, 3},
				new [] {2, 4, 5, 3},
				null,
				new [] {5, 5, 5, 5},
				new [] {4}
			};

			string message = "The average mark for day #";
			double allMarksForWeek = 0;
			int marksCount = 0; 

			for (uint i = 0; i < marks.Length; ++i)
			{
				if (marks[i] == null)
				{
					Console.WriteLine(message + i.ToString() + " N/A");
					continue;
				}

				double allMarksForDay = 0; 
				for(uint j = 0; j < marks[i].Length; ++j)
				{
					allMarksForDay += marks[i][j];
				}

				Console.WriteLine(message + i.ToString() + " " + (allMarksForDay / marks[i].Length).ToString());

				allMarksForWeek += allMarksForDay;
				marksCount += marks[i].Length;
			}

			Console.WriteLine("The average mark for week is {0}", allMarksForWeek / marksCount);
		}
	}
}
