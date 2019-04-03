using System;
using System.Collections.Generic;
using System.Text;

class Helicopter : FlyingMachine, IHelicopter
{
	public byte BladesCount { get; private set; }

	public Helicopter(int maxHeight, byte bladesCount) : base(maxHeight)
	{
		BladesCount = bladesCount;
		Console.WriteLine("It's a helicopter , welcome aboard!");
	}

	public override void WriteAllProperties()
	{
		Console.WriteLine("Properties of Helicopter:");
		Console.WriteLine($"		EnginesCount: {BladesCount}");
		base.WriteAllProperties();
	}
}
