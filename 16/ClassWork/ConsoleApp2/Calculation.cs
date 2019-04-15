using System;
using System.Collections.Generic;
using System.Text;

class Calculation
{
	private int[] _array;

	public Calculation(int [] array)
	{
		_array = array;
	}

	public int CalcSingleValue(Func<int[], int> func)
	{
		return (func(_array));
	}
}
