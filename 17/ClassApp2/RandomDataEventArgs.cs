using System;
using System.Collections.Generic;
using System.Text;

namespace ClassApp2
{
	class RandomDataEventArgs: EventArgs
	{
		public int bytesDone { get; set; }
		public int totalBytes { get; set; }
	}
}
