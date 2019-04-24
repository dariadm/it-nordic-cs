using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Storage.InMemory;
using Reminder.Domain.Model;
using System;
using System.Threading;

namespace Reminder.Domain.Tests
{
	[TestClass]
	public class ReminderDomainTests
	{
		[TestMethod]
		public void Check_That_Reminder_Calls_Internal_Delegate()
		{
			var reminderStorage = new ReminderStorage();
			var reminderDomain  = new ReminderDomain(reminderStorage);

			bool delegateWasCalled = false;
			reminderDomain.SendReminder += (reminder) =>
			{
				delegateWasCalled = true;
			};

			reminderDomain.Add(
				new AddReminderModel
				{
					Date = DateTimeOffset.Now
				});

			reminderDomain.Run();

			Thread.Sleep(2000);

			Assert.IsTrue(delegateWasCalled);
		}

		[TestMethod]
		public void Check_That_On_SendReminder_Exception_SendingFailed_Raised()
		{
			var reminderStorage = new ReminderStorage();
			var reminderDomain = new ReminderDomain(reminderStorage);

			reminderDomain.SendReminder += (reminder) =>
			{
				throw new Exception();
			};

			bool eventHandlerCalled = false;
			reminderDomain.SendingFailed += (s, e) =>
			{
				eventHandlerCalled = true;
			};

			reminderDomain.Add(
				new AddReminderModel
				{
				Date = DateTimeOffset.Now
				});

			reminderDomain.Run();

			Thread.Sleep(2000);

			Assert.IsTrue(eventHandlerCalled);
		}
	}
}
