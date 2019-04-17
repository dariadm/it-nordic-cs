using System;

namespace ClassApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			var worker = new Worker();
			worker.WorkPerfomed += Worker_WorkPerfomed;
			worker.WorkCompleted += Worker_WorkCompleted;

			worker.DoWork(6, WorkType.Work);
		}

		private static void Worker_WorkCompleted(object sender, EventArgs e)
		{
			Console.WriteLine($"Work DONE ({sender.GetHashCode()})");
		}

		private static void Worker_WorkPerfomed(int hours, WorkType workType)
		{
			Console.WriteLine($"Work of type: {workType}: {hours} hours");
		}

	}
}
