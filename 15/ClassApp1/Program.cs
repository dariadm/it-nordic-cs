using System;

namespace ClassApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Account<int> firstClient = new Account<int>(23424, "Name1");
			Account<string> secondClient = new Account<string>("sf2243", "Name2");
			Account<Guid> thirdClient = new Account<Guid>(Guid.NewGuid(), "Name3");

			firstClient.WriteProperties();
			secondClient.WriteProperties();
			thirdClient.WriteProperties();

			Console.WriteLine(thirdClient.getId());
		}
	}
}
