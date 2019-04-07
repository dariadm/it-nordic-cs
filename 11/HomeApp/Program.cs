using System;

namespace HomeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstReminder = new ReminderItem(DateTimeOffset.Parse("25-03-2019"), 
                                                    "Don't forget to buy milk!");
            var secondReminder = new ReminderItem(DateTimeOffset.Parse("2019-04-11"),
                                                    "Theatre visit");

            firstReminder.WriteProperties();
            secondReminder.WriteProperties();
        }
    }
}
