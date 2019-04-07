using System;
using System.IO;

class FileLogWriter : AbstractLogWriter, IDisposable
{
    private StreamWriter _logFileWriter;
    public string LogFileName { get; private set; }

    public FileLogWriter(string fileName = "log.txt")
    {
        // save file name to not lose it in future
        LogFileName = fileName;

        // create the stream writer and open it for writing
        _logFileWriter = new StreamWriter(
            File.Open(
                LogFileName,
                FileMode.OpenOrCreate,
                FileAccess.ReadWrite,
                FileShare.Read));

        // move internal pointer to the end of file
        _logFileWriter.BaseStream.Seek(0, SeekOrigin.End);
    }

    public void Dispose()
    {
        if (_logFileWriter != null)
            _logFileWriter.Dispose();
    }

    protected override void LogGeneral(MessageTypes messageType, string message)
    {
        string date = DateTimeOffset.Now.ToString("yyyy-MM-ddTHH:mm:ss K");

        _logFileWriter.WriteLine(date + "\t" + messageType.ToString() + "\t" + message);
        _logFileWriter.Flush();
    }
}
