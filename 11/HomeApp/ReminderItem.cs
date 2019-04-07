using System;
using System.Collections.Generic;
using System.Text;

class ReminderItem
{
    DateTimeOffset AlarmDate { get; set; }
    string AlarmMessage { get; set; }
    TimeSpan TimeToAlarm
    {
        get
        {
            return DateTimeOffset.Now.Subtract(AlarmDate);
        }
    }
    bool IsOutdated
    {
        get
        {
            return (TimeToAlarm.TotalSeconds > 0) ? true : false;
        }
    }

    public ReminderItem(DateTimeOffset date, string message)
    {
        AlarmDate = date;
        AlarmMessage = message;
    }

    public void WriteProperties()
    {
        Console.WriteLine($"AlarmDate: {AlarmDate}\n" +
                           $"AlarmMessage: {AlarmMessage}\n" +
                           $"TimeToAlarm: {TimeToAlarm}\n" +
                           $"IsOutdated: {IsOutdated}\n");
    }
}
