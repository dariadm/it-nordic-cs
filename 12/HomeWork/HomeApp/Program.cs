using System;
using System.Collections.Generic;

namespace HomeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var reminders = new List<ReminderItem>();
            var firstReminder = new ChatReminderItem(DateTimeOffset.Parse("2019-04-11"), "Meeting", "MyChat", "Daria");
            var secondReminder = new ReminderItem(DateTimeOffset.Parse("2020-05-21"), "Vacation");
            var thirdReminder = new PhoneReminderItem(DateTimeOffset.Parse("2015-09-26"), "Don't forget buy milk", "+71234567891");

            reminders.Add(firstReminder);
            reminders.Add(secondReminder);
            reminders.Add(thirdReminder);

            // Writing
            foreach (var reminder in reminders)
            {
                reminder.WriteProperties();
                Console.WriteLine();
            }
        }
    }
}
