using System;

namespace ClassApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Circle myCircle = new Circle(1.5);
			double circleSquare = myCircle.Calculate((double radius) => Math.PI * radius * radius);
			double circlePerimetr = myCircle.Calculate((double radius) => 2 * Math.PI * radius);
			//double circleSquare = myCircle.Calculate(Calculation.CalcSquare);
			//double circlePerimetr = myCircle.Calculate(Calculation.CalcPerimetr);


			Console.WriteLine($"circlePerimetr {circlePerimetr}");
			Console.WriteLine($"circleSquare {circleSquare}");
		}
	}
}
