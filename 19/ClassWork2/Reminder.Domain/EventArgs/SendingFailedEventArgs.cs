﻿using Reminder.Domain.Model;
using System;

namespace Reminder.Domain.EventArgs
{
	public class SendingFailedEventArgs : System.EventArgs
	{
		public SendReminderModel Reminder { get; set; }

		public Exception Exception { get; set; }

		public SendingFailedEventArgs(SendReminderModel reminder, Exception exception)
		{
			Reminder = reminder;
			Exception = exception;
		}
	}
}
