using System;
using System.Collections.Generic;

namespace HomeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogWriter fileLogWriter = new FileLogWriter();
            ConsoleLogWriter consoleLogWriter = new ConsoleLogWriter();

            List<AbstractLogWriter> logWriters = new List<AbstractLogWriter>();

            logWriters.Add(fileLogWriter);
            logWriters.Add(consoleLogWriter);

            MultipleLogWriter multipleLogWriter = new MultipleLogWriter(logWriters);

            multipleLogWriter.LogError("hsjkhfsjkfhsd");
            multipleLogWriter.LogWarning("sfjsdfhsdkjfsk");
            multipleLogWriter.LogInfo("sdhfjsdkfhskfj");
        }
    }
}
