using System;

namespace ClassApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			Circle myCircle = new Circle(1.5);
			double circleSquare = myCircle.Calculate(Calculation.CalcSquare);
			double circlePerimetr = myCircle.Calculate(Calculation.CalcPerimetr);

			Console.WriteLine($"circlePerimetr {circlePerimetr}");
			Console.WriteLine($"circleSquare {circleSquare}");
		}
	}
}
