using System;
using System.Collections.Generic;
using System.Text;

class ConsoleLogWriter : AbstractLogWriter
{
    public ConsoleLogWriter() { }

    protected override void LogGeneral(MessageTypes messageType, string message)
    {
        string date = DateTimeOffset.Now.ToString("yyyy-MM-ddTHH:mm:ss K");

        Console.WriteLine(date + "\t" + messageType.ToString() + "\t" + message);
    }
}

