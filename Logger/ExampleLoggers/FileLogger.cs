using clog.Interfaces;

namespace AFG.Logger.Loggers;

public class FileLogger : ILoggable
{
    private static string _fileDestination = string.Empty;
    private bool _disposedValue;
    private StreamWriter _fileStream;

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

    public FileLogger(string filePath)
    {
        try
        {
            _fileDestination = filePath;
        }
        catch (Exception ex)
        {
            Log(LogLevels.Fatal, $"Error initializing FileLogger: {ex.Message}").Wait();
        }
    }

    public static async Task Log(LogLevels logLevel, string message)
    {
        string logEntry = $"{DateTime.Now} - {logLevel} - {message}{Environment.NewLine}";

        try
        {
            await File.AppendAllTextAsync(_fileDestination, logEntry);
        }
        catch (Exception e)
        {
            await File.AppendAllTextAsync(_fileDestination, e.Message);
            throw;
        }
    }

    public object Log(object request)
    {
        throw new NotImplementedException();
    }

    public ILoggable NextLogger(ILoggable logger)
    {
        throw new NotImplementedException();
    }

    public void Setup()
    {
        string _filename = DateTime.Now("yyyyMMdd") + ".log";
        _fileStream = new StreamWriter(_fileDestination, _filename), true)
        {
            AutoFlush = true
        }
        ;
    }

    public void TearDown()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}