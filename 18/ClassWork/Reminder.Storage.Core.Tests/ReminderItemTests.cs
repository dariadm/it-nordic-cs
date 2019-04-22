using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reminder.Storage.Core.Tests
{
	[TestClass]
	public class ReminderItemTests
	{
		[TestMethod]
		public void Constructor_Validly_Sets_Id_Property()
		{
			// Preparing
			Guid expected = new Guid("EC882042-CF7B-4BC8-865F-F86B081A041D");

			// Running
			var reminderItem = new ReminderItem(
				expected,
				DateTimeOffset.MinValue,
				null,
				null);

			// Checking
			Assert.AreEqual(expected, reminderItem.Id);
		}

		[TestMethod]
		public void Constructor_Validly_Sets_Date_Property()
		{
			// Preparing
			var expected = DateTimeOffset.Now;

			// Running
			var reminderItem = new ReminderItem(
				Guid.Empty,
				expected,
				null,
				null);

			// Checking
			Assert.AreEqual(expected, reminderItem.Date);
		}

		[TestMethod]
		public void TimeToSend_Is_In_500_ms_Range()
		{
			// Preparing
			var time500ms = TimeSpan.FromMilliseconds(500);
			var reminderItem = new ReminderItem(
				Guid.Empty,
				DateTimeOffset.UtcNow + TimeSpan.FromMilliseconds(500),
				null,
				null);

			var actual = reminderItem.TimeToSend;

			// Checking
			Assert.IsTrue(actual < time500ms);
			Assert.IsTrue(actual > TimeSpan.Zero);
		}

		[TestMethod]
		public void TimeToSend_Is_Less_Then_Zero_For_Date_In_The_Past_Time()
		{
			// Preparing
			var reminderItem = new ReminderItem(
				Guid.Empty,
				DateTimeOffset.UtcNow - TimeSpan.FromDays(1),
				null,
				null);

			var actual = reminderItem.TimeToSend;

			// Checking
			Assert.IsTrue(actual < TimeSpan.Zero);
		}
	}
}
