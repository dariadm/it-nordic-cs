using System;
using System.Collections.Generic;
using System.Text;

namespace ClassApp2
{
	//public delegate void RandomDataGeneratedHandler(int bytesDone, int totalBytes);

	class RandomDataGenerator
	{
		public event EventHandler<RandomDataEventArgs> RandomDataGenerated;
		public event EventHandler RandomDataGenerationDone;

		public byte[] GetRandomData(int dataSize, int bytesDoneToRaiseEvent)
		{
			byte[] result = new byte[dataSize];
			Random rand = new Random();

			if (dataSize % bytesDoneToRaiseEvent == 0)
			{
				for (int i = 0; i < dataSize; ++i)
				{
					result[i] = (byte)rand.Next(256);

					if((i + 1) % bytesDoneToRaiseEvent == 0)
						OnDataGenerated(this, new RandomDataEventArgs { bytesDone = i + 1, totalBytes = dataSize });
				}	

				OnDataGenerationDone(this, EventArgs.Empty);
			}

			return result;
		}

		protected virtual void OnDataGenerated(object sender, RandomDataEventArgs e)
		{
			RandomDataGenerated?.Invoke(sender, e);
		}

		protected virtual void OnDataGenerationDone(object sender, EventArgs e)
		{
			RandomDataGenerationDone?.Invoke(sender, e);
		}
	}
}
