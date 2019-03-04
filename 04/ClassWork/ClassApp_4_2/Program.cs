using System;

namespace ClassApp_4_2
{
	class Program
	{
		static void Main(string[] args)
		{
			long longNum;
			int intNum;

			Console.WriteLine(int.MaxValue);
			Console.WriteLine("Enter long type number:");
			longNum = long.Parse(Console.ReadLine());

			if ((longNum <= int.MaxValue) && (longNum >= int.MinValue))
			{
				intNum = (int)longNum;
				Console.WriteLine("number: {0}", intNum);
			}
			else
			{
				if (longNum > int.MaxValue)
					Console.WriteLine("Value is bigger then int maximum!");
				else
					Console.WriteLine("Value is smaller then int minimum!");
			}
		}
	}
}
