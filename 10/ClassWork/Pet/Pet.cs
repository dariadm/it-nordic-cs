using System;
using System.Collections.Generic;
using System.Text;

public class Pet
{
	public string Kind;
	public string Name;
	public char Sex;
	public uint Age;

	public string Description
	{
		get
		{
			return $"{Name} is a {Kind}({Sex}) of {Age} years old";
		}
	}
}
