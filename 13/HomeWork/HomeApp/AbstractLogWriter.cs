using System;
using System.Collections.Generic;
using System.Text;

abstract class AbstractLogWriter : ILogWriter
{
    abstract protected void LogGeneral(MessageTypes messageType, string message);
    
    // Implementing interface ILogWriter
    public void LogInfo(string message)
    {
        LogGeneral(MessageTypes.Info, message);
    }
    public void LogWarning(string message)
    {
        LogGeneral(MessageTypes.Warning, message);
    }
    public void LogError(string message)
    {
        LogGeneral(MessageTypes.Error, message);
    }
}
