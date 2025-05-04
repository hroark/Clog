using clog;

namespace Clog;

internal abstract class Logger
{
    protected EventLevels _logLevel;
    protected Logger? _nextLogger;

    protected Logger(EventLevels Level)
    {
        _logLevel = Level;
    }

    protected abstract void Log(EventLevels EventLevel, string message);

    public void AddLogger(Logger Logger)
    {
        _nextLogger = Logger;
    }

    public virtual void LogMessage(EventLevels LogLevel, string Message)
    {
        if ((LogLevel & _logLevel) != 0)
        {
            Log(LogLevel, Message);
        }

        if (_nextLogger != null)
        {
            _nextLogger.Log(LogLevel, Message);
        }
    }

    public virtual void Setup()
    {
    }

    public virtual void TearDown()
    {
    }
}