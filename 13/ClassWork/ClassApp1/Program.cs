using System;

namespace ClassApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Plane plane = new Plane(200,2);
			plane.WriteAllProperties();
			plane.CurrentHeight = 200; 
			plane.TakeUpper(300);

			Helicopter helicopter = new Helicopter(100, 1);
			helicopter.CurrentHeight = 300;
			helicopter.WriteAllProperties();
			helicopter.TakeLower(20);
			
			Console.WriteLine("Hello World!");
		}
	}
}
