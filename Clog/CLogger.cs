namespace Clog;

/// <summary>
/// Class CLogger.
/// </summary>
public class CLogger : ILoggable, IDisposable
{
    private bool disposedValue;

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // Free managed resources here
            }

            // Free unmanaged resources here (if any)
            disposedValue = true;
        }
    }

    public CLogger(CLogger NewWatcher)
    {
        _subscriptionLevel = NewWatcher._subscriptionLevel;
    }

    public CLogger()
    {
    }

    public EventLevel _subscriptionLevel { get; set; }

    // Explicit implementation of IDisposable.Dispose
    void IDisposable.Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    public virtual void Log(EventLevel CurrentLevel, string Message)
    {
        throw new NotImplementedException("No valid logger found");
    }

    // Explicit interface implementation for ILoggable.Log
    void ILoggable.Log(EventLevel Level, string Message)
    {
        throw new NotImplementedException();
    }

    public virtual void Subscribe(CLogger Logger)
    {
        throw new NotImplementedException("No valid logger found");
    }
}