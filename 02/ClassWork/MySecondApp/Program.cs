using System;

namespace MySecondApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//char letter = 'A';
			//Console.WriteLine(letter);

			//string name = "Bob";
			//name = name.ToUpper().ToLower(); 
			//Console.WriteLine(name.ToUpper());
			//Console.WriteLine(name);

			//System.Int32 myInteger;

			//float x1 = 3.5F;
			//Console.WriteLine(x1);

			//int x = 3;
			//float y = float.NegativeInfinity;//4.5F;
			//short z = 5;
			//var result = x + y / z;
			//Console.WriteLine("The result is {0}", result);
			//Type type = result.GetType();
			//Console.WriteLine("result is of type {0}", type.ToString());

			//float pi = Convert.ToSingle(Math.PI);

			float notNumber = float.NaN;
			float zero = 0;
			Console.WriteLine("{0} / {0} = {1}", zero, zero / zero);

			Console.WriteLine(zero / zero == float.NaN);
			Console.WriteLine(float.IsNaN(zero / zero));

			Console.WriteLine(float.PositiveInfinity);
			Console.WriteLine(float.NegativeInfinity);

		}
	}
}
