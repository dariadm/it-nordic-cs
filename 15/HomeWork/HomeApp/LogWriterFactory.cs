using System;
using System.Collections.Generic;
using System.Text;

class LogWriterFactory
{
    private static LogWriterFactory instance;

    private LogWriterFactory()
    { }

    public static LogWriterFactory GetInstance()
    {
        if (instance == null)
            instance = new LogWriterFactory();

        return instance;
    }

    public ILogWriter GetLogWriter<T>(object parameters = null) where T : ILogWriter
    {
        Type inputType = typeof(T);
        
        if (inputType == typeof(ConsoleLogWriter))
            return new ConsoleLogWriter();
        if (inputType == typeof(FileLogWriter))
        {
            if (parameters != null)
                return new FileLogWriter((parameters.ToString()));
            else
                return new FileLogWriter();
        }
        if (inputType == typeof(MultipleLogWriter))
            return new MultipleLogWriter((List<AbstractLogWriter>)parameters);

        // If unknown type
        return null;
    }
}
