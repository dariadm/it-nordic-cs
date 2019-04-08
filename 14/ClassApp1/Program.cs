using System;
using System.Collections.Generic;

namespace ClassApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			using(var myErrorList = new ErrorList("Stackoverflow error"))
			{
				myErrorList.Add("Bad error 1");
				myErrorList.Add("Bad error 2");

				// Writing
				//foreach (var error in myErrorList)
				//	Console.WriteLine($"{myErrorList.Category} : {error}");

				myErrorList.WriteToConsole();
			}
		}
	}
}
