using System;

namespace ClassApp5_2
{
	[Flags]
	enum Colors : byte
	{
		None,
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

			Colors userColors = Colors.None;
			for (uint i = 0; i < 4; ++i)
			{
				object curColor;
				if (Enum.TryParse(typeof(Colors), Console.ReadLine(), out curColor))
				{
					userColors |= (Colors)curColor;
				}
				else
				{
					Console.WriteLine("Wrong color!");
					return;
				}
			}

			// Writing on screen
			//for (uint i = 0; i < 4; ++i)
			//{
			//	Console.WriteLine(userColors[i]);
			//}


		}
	}
}
