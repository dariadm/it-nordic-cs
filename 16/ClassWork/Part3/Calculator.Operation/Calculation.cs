using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Operation
{
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
}