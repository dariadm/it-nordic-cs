using System;
using Reminder.Storage.Core;
using System.Threading;
using System.Linq;
using Reminder.Domain.Model;
using Reminder.Domain.EventArgs;

namespace Reminder.Domain
{
	public class ReminderDomain
	{
		const int _deltaToCheckAwaitingReminders = 1000;
		const int _deltaToSendReadyReminders = 1000;

		private readonly IReminderStorage _storage; 

		public Action<SendReminderModel> SendReminder { get; set; }

		public event EventHandler<SendingSuccededEventArgs> SendingSucceded;
		public event EventHandler<SendingFailedEventArgs> SendingFailed;

		public ReminderDomain(IReminderStorage storage)
		{
			_storage = storage; 
		}

		public void Run()
		{
			var awaitingRemindersCheckTimer = new Timer(
				CheckAwaitingReminders,
				null,
				TimeSpan.Zero,
				TimeSpan.FromMilliseconds(_deltaToCheckAwaitingReminders)
				);

			var readyRemindersSendTimer = new Timer(
				SendReadyReminders,
				null,
				TimeSpan.Zero,
				TimeSpan.FromMilliseconds(_deltaToSendReadyReminders)
				);
		}

		public void Add(AddReminderModel addReminderModel)
		{
			_storage.Add(
				new ReminderItem
				{
					Date = addReminderModel.Date,
					ContactId = addReminderModel.ContactId,
					Message = addReminderModel.Message,
					Status = ReminderItemStatus.Awaiting
				});
		}

		public void CheckAwaitingReminders(object dummy)
		{
			var ids = _storage
				.Get(ReminderItemStatus.Awaiting)
				.Where(r => r.IsTimeToSend)
				.Select(r => r.Id)
				.ToList();

			_storage.UpdateStatus(ids, ReminderItemStatus.Ready);
		}

		public void SendReadyReminders(object dummy)
		{
			var sendReminderModels = _storage
				.Get(ReminderItemStatus.Ready)
				.Where(r => r.IsTimeToSend)
				.Select(r => new SendReminderModel
				{
					Id = r.Id,
					Message = r.Message,
					ContactId = r.ContactId
				})
				.ToList();

			foreach (SendReminderModel sendReminder in sendReminderModels)
			{
				try
				{
					// Trying to send message
					SendReminder?.Invoke(sendReminder);

					// Updating status
					_storage.UpdateStatus(sendReminder.Id, ReminderItemStatus.Sent);

					// Informing about success 
					SendingSucceded?.Invoke(this, new SendingSuccededEventArgs(sendReminder));
				}
				catch (Exception exception)
				{
					_storage.UpdateStatus(sendReminder.Id, ReminderItemStatus.Failed);

					SendingFailed?.Invoke(this, new SendingFailedEventArgs(sendReminder, exception));
				}
			}
		}
	}
}
