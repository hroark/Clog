using Clog;

namespace LoggerTypes;

[LoggerLevel(EventLevel.Informational)]
public class FileLogger : CLogger
{
    private static string _fileDestination = string.Empty;
    private List<EventLevel> _currentLevel = new();
    private bool _disposedValue;

    private async Task LogAsynch(EventLevel logLevel, string message)
    {
        string logEntry = $"{DateTime.Now} - {logLevel} - {message}{Environment.NewLine}";

        try
        {
            await File.AppendAllTextAsync(_fileDestination, logEntry);
        }
        catch (Exception e)
        {
            await File.AppendAllTextAsync(_fileDestination, e.Message); //This is interesting because we might not have a file to write to.
            throw;
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
            }

            _disposedValue = true;
        }
    }

    public FileLogger(string filePath, EventLevel HandleTheseEvents, bool Append = true) : base(HandleTheseEvents)
    {
        _fileDestination = filePath;
        using (StreamWriter fileStream = File.AppendText(_fileDestination))
        {
            fileStream.WriteLine("Log file created at: " + DateTime.Now);
        }
    }

    public override void Log(EventLevel eventLevel, string message)
    {
        LogAsynch(eventLevel, message).Wait();
    }

    public void TearDown()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}