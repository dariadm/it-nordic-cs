using System;
using System.Collections.Generic;
using System.Text;

class ChatReminderItem: ReminderItem
{
    string ChatName { get; set; }
    string AccountName { get; set; }

    public ChatReminderItem(DateTimeOffset date, string message,
                        string chatName, string accountName)
                            :base(date, message)
    {
        ChatName = chatName;
        AccountName = accountName;
    }

    public override void WriteProperties()
    {
        Console.WriteLine("ChatReminderItem");
        base.WriteProperties();
        Console.Write($"ChatName: {ChatName}\n");
        Console.Write($"AccountName: {AccountName}\n");
    }
}
