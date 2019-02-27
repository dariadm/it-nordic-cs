using System;

namespace ClassApp
{
	class Program
	{
		static void Main(string[] args)
		{
			object x1 = 10D;
			object y1 = 2.5;

			////Console.WriteLine(((int)x) + 5);
			//Console.WriteLine((double)x1 * ((double)y1));

			dynamic x = 10;
			dynamic y = double.Parse("12.3", System.Globalization.CultureInfo.InvariantCulture.NumberFormat);

			//Console.WriteLine((double)x + (double)y);
			Console.WriteLine(x + y);
		}
	}
}
