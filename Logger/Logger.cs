using clog.Interfaces;

namespace Clog;

internal abstract class Logger : ILoggable
{
    private ILogger _nextLogger;

    public virtual object AddLogger(object request)
    {
        if (this._nextHandler != null)
        {
            return _nextLogger.Handle(request);
        }
        else
        {
            return null;
        }
    }

    public virtual Task Log(LogLevels logLevel, string message)
    {
    }

    public ILogger SetNextLogger(ILogger logger)
    {
        _nextLogger = logger;

        return logger;
    }

    public virtual void Setup()
    {
    }

    public virtual void TearDown()
    {
    }
}