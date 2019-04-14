using System;
using System.Collections.Generic;

namespace HomeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = LogWriterFactory.GetInstance();

            var consoleLogWriter = (ConsoleLogWriter)factory.GetLogWriter<ConsoleLogWriter>();
            var fileLogWriter = (FileLogWriter)factory.GetLogWriter<FileLogWriter>();
            var multipleLogWriter = factory.GetLogWriter<MultipleLogWriter>(new List<AbstractLogWriter>{ consoleLogWriter, fileLogWriter });

            multipleLogWriter.LogError("hsjkhfsjkfhsd");
            multipleLogWriter.LogWarning("sfjsdfhsdkjfsk");
            multipleLogWriter.LogInfo("sdhfjsdkfhskfj");
        }
    }
}
