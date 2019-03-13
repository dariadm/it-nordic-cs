using System;

namespace ClassApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter two real numbers to multiply them:");

			double firstNumber = double.Parse(Console.ReadLine());
			double secondNumber = double.Parse(Console.ReadLine());

			Console.WriteLine(firstNumber + "*" + secondNumber + "=" + firstNumber*secondNumber);
			Console.WriteLine("{0:.##} + {1:.##} = {2:.##}", firstNumber, secondNumber, firstNumber + secondNumber);
			Console.WriteLine($"{firstNumber:.##} - {secondNumber:.##} = {(firstNumber - secondNumber):.##}");

			//Console.WriteLine(String.Format("{0:.##} + {1:.##} = {2:.##}", firstNumber, secondNumber, firstNumber + secondNumber));
		}
	}
}
