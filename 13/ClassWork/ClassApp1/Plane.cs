using System;
using System.Collections.Generic;
using System.Text;

class Plane: FlyingMachine, IPlane
{ 
	public byte EnginesCount { get; private set; }

	public Plane(int maxHeight, byte enginesCount):base(maxHeight)
	{
		EnginesCount = enginesCount;
		Console.WriteLine("It's a plane , welcome aboard!");
	}

	public override void WriteAllProperties()
	{
		Console.WriteLine("Properties of Plane:");
		Console.WriteLine($"		EnginesCount: {EnginesCount}");
		base.WriteAllProperties();
	}
}
