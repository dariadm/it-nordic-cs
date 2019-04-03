using System;
using System.Collections.Generic;
using System.Text;

abstract class FlyingMachine: IFlyingObject, IPropertiesWriter
{
	public int MaxHeight { get; set; }
	public int CurrentHeight { get; set; }

	public FlyingMachine(int maxHeight)
	{
		MaxHeight = maxHeight;
		CurrentHeight = 0; 
	}

	public void TakeUpper(int delta)
	{
		if (delta <= 0)
			throw new ArgumentOutOfRangeException();

		CurrentHeight = Math.Min(CurrentHeight + delta, MaxHeight);
	}

	public void TakeLower(int delta)
	{
		if(delta <= 0)
			throw new ArgumentOutOfRangeException();

		if (CurrentHeight - delta > 0)
			CurrentHeight = CurrentHeight - delta;
		else if (CurrentHeight - delta == 0)
			CurrentHeight = 0;
		else
			throw new InvalidOperationException("Crash!");
	}

	public virtual void WriteAllProperties()
	{
		Console.WriteLine($"		CurrentHeight: {CurrentHeight}");
		Console.WriteLine($"		MaxHeight: {MaxHeight}");
	}
}

