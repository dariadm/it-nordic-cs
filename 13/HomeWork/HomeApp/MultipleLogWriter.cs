using System;
using System.Collections.Generic;
using System.Text;

class MultipleLogWriter : AbstractLogWriter
{
    List<AbstractLogWriter> LogWriters;
    public MultipleLogWriter(List<AbstractLogWriter> logWriters)
    {
        LogWriters = logWriters;
    }

    override protected void LogGeneral(MessageTypes messageType, string message)
    {
        foreach (var logWriter in LogWriters)
        {
            switch(messageType)
            {
                case MessageTypes.Info:
                    logWriter.LogInfo("This is simple info");
                    break;
                case MessageTypes.Error:
                    logWriter.LogError("This is bad mistake");
                    break;
                case MessageTypes.Warning:
                    logWriter.LogWarning("This is just warning");
                    break;
                default:
                    throw new FormatException();
            }                    
        }
    }
}
