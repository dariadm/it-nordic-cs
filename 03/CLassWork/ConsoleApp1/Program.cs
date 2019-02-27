using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			double? d = null;

			do
			{
				try
				{
					d = Convert.ToDouble(Console.ReadLine());
				}
				catch { }
			} while {!d.HasValue};

			Console.WriteLine(d);
		}
	}
}
