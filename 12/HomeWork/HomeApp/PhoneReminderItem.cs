using System;
using System.Collections.Generic;
using System.Text;

class PhoneReminderItem: ReminderItem
{
    string PhoneNumber { get; set; }

    public PhoneReminderItem(DateTimeOffset date, string message, string number)
        : base(date, message)
    {
        PhoneNumber = number;
    }

    public override void WriteProperties()
    {
        Console.WriteLine("PhoneReminderItem");
        base.WriteProperties();
        Console.Write($"PhoneNumber: {PhoneNumber}");
    }
}
