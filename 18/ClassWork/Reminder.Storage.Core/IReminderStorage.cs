using System;
using System.Collections.Generic;

namespace Reminder.Storage.Core
{
	public interface IReminderStorage
	{	
		/// <summary>
		/// Adds new reminder item to collection
		/// </summary>
		/// <param name="reminderItem"></param>
		void Add(ReminderItem reminderItem);

		/// <summary>
		/// Updates already existing reminder item
		/// </summary>
		/// <param name="reminderItem"></param>
		void Update(ReminderItem reminderItem);

		ReminderItem Get(Guid guid);

		List<ReminderItem> GetList(
			IEnumerable<ReminderItemStatus> status,
			int count,
			int startPosition);
	}
}
