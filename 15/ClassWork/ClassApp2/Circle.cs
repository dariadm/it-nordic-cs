using System;
using System.Collections.Generic;
using System.Text;

public sealed class Circle
{
	private double _radius;

	public Circle(double radius)
	{
		_radius = radius;
	}

	public double Calculate(Func<double, double> operation)
	{
		return operation(_radius);
	}
}

public static class Calculation
{
	public static double CalcSquare(double radius)
	{
		return Math.PI * radius * radius;
	}

	public static double CalcPerimetr(double radius)
	{
		return 2 * Math.PI * radius;
	}
}
