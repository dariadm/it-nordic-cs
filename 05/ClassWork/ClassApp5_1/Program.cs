using System;

namespace ClassApp5_1
{
	enum Colors : byte
	{
		Black,
		Blue,
		Cyan,
		Grey,
		Green,
		Magenta,
		Red,
		White,
		Yellow
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter 4 colors:");

			Colors[] userColors = new Colors[4];
			for(uint i = 0; i < 4; ++i)
			{
				object curColor;
				if (Enum.TryParse(typeof(Colors), Console.ReadLine(), true, out curColor))
					userColors[i] = (Colors)curColor;
				else
				{
					Console.WriteLine("Wrong color!");
					return;
				}
			}

			// Writing on screen
			Console.WriteLine("User's colors:");
			for(uint i = 0; i < 4; ++i)
			{
				Console.WriteLine(userColors[i]);
			}

			Console.WriteLine("Left colors:");
			// Convert userColors to strings or numbers ad then compare to what we have

		}

		static bool isColorInArray(Colors color, Colors[] someColors)
		{
			for(uint i = 0; i < 4; ++i)
			{
				if (someColors[i] == color)
					return true;
			}
			return false;
		}
	}
}
