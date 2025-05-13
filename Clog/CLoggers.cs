// ***********************************************************************
// Assembly         : Clog
// Author           : HRoark
// Created          : 05-03-2025
//
// Last Modified By : HRoark
// Last Modified On : 05-09-2025
// ***********************************************************************

namespace Clog;

/// <summary>
/// This class is a collection of Cloggers.
/// Implements the <see cref="CLogger" />
/// Implements the <see cref="ICLogger" />
/// </summary>
/// <seealso cref="CLogger" />
/// <seealso cref="ICLogger" />
public class CLoggers : ILoggable, ICLogger
{
    private bool disposedValue;

    /// <summary>
    /// The loggers
    /// </summary>
    protected List<CLogger> _loggers = [];

    /// <summary>
    /// Releases unmanaged and - optionally - managed resources.
    /// </summary>
    /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }

            disposedValue = true;
        }
    }

    /// <summary>The main logger class</summary>
    protected CLogger? GetActiveLoggers()
    {
        foreach (var logger in _loggers)
        {
            return logger;
        }
        return null;
    }

    /// <summary>

    public virtual void Log(EventLevel CurrentLevel, string Message)
    {
        throw new NotImplementedException("No valid logger found");
    }

    /// <summary>
    /// Subscribes the specified logger.
    /// </summary>
    /// <param name="logger">The logger.</param>
    public void Subscribe(CLogger logger)
    {
        _loggers.Add(logger);
    }

    /// <summary>
    /// Unsubscribes the specified logger.
    /// </summary>
    /// <param name="logger">The logger.</param>
    public void Unsubscribe(CLogger logger)
    {
        _loggers.Remove(logger);
    }
}