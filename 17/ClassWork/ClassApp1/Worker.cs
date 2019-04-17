using System;
using System.Collections.Generic;
using System.Text;

namespace ClassApp1
{
	public enum WorkType
	{
		Work,
		DoNothing
	}

	public delegate void WorkPerfomedEventHandler(int hours, WorkType workType);
	
	public class Worker
	{
		public event WorkPerfomedEventHandler WorkPerfomed;
		public event EventHandler WorkCompleted; 

		public void DoWork(int hours, WorkType workType)
		{
			for (int i = 0; i < hours; ++i)
			{
				//WorkPerfomed?.Invoke(i + 1, workType);

				//var del = WorkPerfomed as WorkPerfomedEventHandler;
				//if (del != null)
				//	del.Invoke(i + 1, workType);

				//(WorkPerfomed as WorkPerfomedEventHandler)?.Invoke(i + 1, workType);
				OnWorkPerfomed(i + 1, workType); 
			}

			OnWorkCompleted(this, EventArgs.Empty);
		}

		protected virtual void OnWorkPerfomed(int data, WorkType workType)
		{
			WorkPerfomed?.Invoke(data, workType);
		}

		protected virtual void OnWorkCompleted(object sender, EventArgs e)
		{
			WorkCompleted?.Invoke(sender, e);
		}
	}
}
