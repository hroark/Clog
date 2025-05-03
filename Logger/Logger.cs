using AFG.Logger.Interfaces;

namespace AFG.Logger;

abstract class Logger : ILoggable
{
    private ILogger _nextLogger;

    public ILogger SetNextLogger(ILogger logger)
    {
        this._nextLogger = logger;

        return logger;
    }

    public virtual object AddLogger(object request)
    {
        if (this._nextHandler != null)
        {
            return this._nextLogger.Handle(request);
        }
        else
        {
            return null;
        }
    }

    public virtual void Setup()
    {
    }

    public virtual void TearDown()
    {
        
    }

    public virtual Task Log(LogLevels logLevel, string message)
    {
    }
}