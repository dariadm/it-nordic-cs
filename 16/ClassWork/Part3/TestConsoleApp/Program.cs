using System;
using Calculator.Figure;
using Calculator.Operation;
using Newtonsoft.Json;

namespace TestConsoleApp
{
	public class Person
	{
		public string Name;
		public int Age;
	}

	class Program
	{
		static void Main(string[] args)
		{
			//Circle myCircle = new Circle(1.5);
			//double circleSquare = myCircle.Calculate(Calculation.CalcSquare);
			//double circlePerimetr = myCircle.Calculate(Calculation.CalcPerimetr);

			//Console.WriteLine($"circlePerimetr {circlePerimetr}");
			//Console.WriteLine($"circleSquare {circleSquare}");

			//object a = new
			//{
			//	Name = "sdfsdfsd",
			//	Age = (int)12
			//};

			var a = new Person();
			var packedJson = JsonConvert.SerializeObject(a);
			var newObject = JsonConvert.DeserializeObject<Person>("{\"Name\":Daria,\"Age\":12}");
			Console.WriteLine(packedJson);
			Console.WriteLine(newObject.Name + newObject.Age);
		}
	}
}
