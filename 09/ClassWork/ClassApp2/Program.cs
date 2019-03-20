using System;
using System.Diagnostics;

namespace ClassApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i <= 20; i++)
			{
				// Получаем массив для тестов
				int[] initialArray = GetTestArray(i*1000, 1_000_000);

				// Таймер для тестов
				Stopwatch stopwatch = new Stopwatch();

				// Выводим на экран его первонаальное состояние
				//WriteArrayState("Initial state:", initialArray);

				// Клонируем массив для сортировки пузырьком
				int[] bubbleSortedArray = (int[])initialArray.Clone();

				stopwatch.Start();
				// Выполняем сортировку "пузырьком"
				BubbleSort(bubbleSortedArray); stopwatch.Stop();
				stopwatch.Stop();
				Console.WriteLine($"Bubble sort with {i * 1000} elements done in {stopwatch.ElapsedMilliseconds} ms:");

				// Клонируем массив для сортировки dotnet
				int[] dotnetSortedArray = (int[])initialArray.Clone();

				stopwatch.Restart();
				// Выполняем сортировку dotnet
				Array.Sort(dotnetSortedArray);
				stopwatch.Stop();
				Console.WriteLine($"Dotnet sort with {i * 1000} elements done in {stopwatch.ElapsedMilliseconds} ms:");

				// Выводим на экран его отсортированное состояние
				//Writearraystate("sorted state:", bubblesortedarray);
			}
		}

		private static int[] GetTestArray(int length, int maxValue)
		{
			var arr = new int[length];

			var rnd = new Random();
			for(var i = 0; i < arr.Length; i++)
			{
				arr[i] = rnd.Next(maxValue);
			}

			return arr;			
		}

		// Функция вывода на экран элементов массива с названием состояния
		private static void WriteArrayState(string message, int[] arr)
		{
			Console.WriteLine(message);
			for (var i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
			}
		}

		// Функция сортировки "пузырьком"
		private static void BubbleSort(int[] arr)
		{
			for (int i = 0; i < arr.Length - 1; i++)
			{
				var limit = arr.Length - 1 - i;

				for (int j = 0; j < limit; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						// поменять местами
						var temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
					}
				}
			}
		}
	}
}
