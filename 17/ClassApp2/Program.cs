using System;
using System.IO;
using System.IO.Compression;

namespace ClassApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			var dataGenerator = new RandomDataGenerator();
			dataGenerator.RandomDataGenerated += DataGenerator_RandomDataGenerated;
			dataGenerator.RandomDataGenerationDone += DataGenerator_RandomDataGenerationDone;

			var bytesArray = dataGenerator.GetRandomData(10000, 10);

			Console.WriteLine("Generated array: {0}", Convert.ToBase64String(bytesArray));

			string fileWithBytesPath = "log.txt";
			string fileWithBytesFolder = @"C:\Users\User\Desktop\it-nordic-cs\17\ClassApp2\bin\Debug\netcoreapp2.1\Log";
			string fileToZip = @"\Archive.zip";

			if (File.Exists(fileToZip))
				File.Delete(fileToZip);

			File.WriteAllBytes(fileWithBytesPath, bytesArray);
			ZipFile.CreateFromDirectory(fileWithBytesFolder, fileToZip);
		}

		private static void DataGenerator_RandomDataGenerationDone(object sender, EventArgs e)
		{
			Console.WriteLine("Data generation done!");
		}

		private static void DataGenerator_RandomDataGenerated(object sender, RandomDataEventArgs e)
		{
			Console.WriteLine($"{e.bytesDone} bytes of {e.totalBytes} done!");
		}
	}
}
