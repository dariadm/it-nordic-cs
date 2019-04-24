using System;

namespace Reminder.Domain.Model
{
	public class AddReminderModel
	{
		/// <summary>
		/// Gets or sets the date and time the reminder item scheduled for sending.
		/// </summary>
		public DateTimeOffset Date { get; set; }

		/// <summary>
		/// Gets or sets contact identifier in the target sending system
		/// </summary>
		public string ContactId { get; set; }

		/// <summary>
		/// The message of the reminder item for sending to the recepient.
		/// </summary>
		public string Message { get; set; }
	}
}