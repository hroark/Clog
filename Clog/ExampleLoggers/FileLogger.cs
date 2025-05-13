namespace Clog.ExampleLoggers;

public class FileLogger : CLogger
{
    private static string _fileDestination = string.Empty;
    private EventLevel _currentLevel;
    private bool _disposedValue;

    private async Task LogAsynch(EventLevel logLevel, string message)
    {
        string logEntry = $"{DateTime.Now} - {string.Join(", ", logLevel)} - {message}{Environment.NewLine}";

        try
        {
            await File.AppendAllTextAsync(_fileDestination, logEntry);
        }
        catch (Exception e)
        {
            await File.AppendAllTextAsync(_fileDestination, e.Message); // This is interesting because we might not have a file to write to.
            throw;
        }
    }

    protected override void Dispose(bool disposing = true)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                Dispose(true);
            }

            _disposedValue = true;
        }
    }

    public FileLogger(CLogger NewWatcher) : base(NewWatcher)
    {
        _subscriptionLevel = NewWatcher._subscriptionLevel;
    }

    public string filePath
    {
        get => _fileDestination;
        set => _fileDestination = value;
    }

    public override void Log(EventLevel CurrentLLevel, string message)
    {
        _fileDestination = filePath;
        using (StreamWriter fileStream = File.AppendText(_fileDestination))
        {
            fileStream.WriteLine("Log file created at: " + DateTime.Now);
        }
        _currentLevel = CurrentLLevel;
        if (_currentLevel == CurrentLLevel)
        {
            LogAsynch(_currentLevel, message).Wait();
        }
    }

    public void Subscribe(CLogger logger)
    {
        // Implementation for subscribing to another logger
    }

    public void TearDown()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}