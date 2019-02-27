using System;

namespace ClassApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] myArray = new string[5];

			Console.WriteLine("Enter array:");
			for (int i = 0; i < myArray.Length; ++i)
				myArray[i] = Console.ReadLine();

			Console.WriteLine("Your input array:");
			for (int i = 0; i < myArray.Length; ++i)
				Console.WriteLine(myArray[i]);
		}
	}
}
