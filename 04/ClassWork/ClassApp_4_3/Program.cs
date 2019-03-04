using System;

namespace ClassApp_4_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("*****Pyramide******");

			float a;
			float h;

			Console.WriteLine("Enter a: ");
			a = float.Parse(Console.ReadLine());
			Console.WriteLine("Enter h:");
			h = float.Parse(Console.ReadLine());

			float sideS = 3F * a * h;
			float fullS = (3F / 2F) * a * (a*MathF.Sqrt(3F) + 2*h);
			float H = h / (MathF.Sqrt(2F));
			float V = (a * a / 2) * H * MathF.Sqrt(3F);

			Console.WriteLine($"sideS = {sideS}, fullS = {fullS}, V = {V}");
		}
	}
}
