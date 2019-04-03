using System;
using System.Collections.Generic;
using System.Text;

interface IFlyingObject
{
	int MaxHeight { get; set; }
	int CurrentHeight { get; set; }

	void TakeUpper(int delta);
	void TakeLower(int delta);
}
