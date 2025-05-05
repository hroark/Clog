using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clog;

public abstract class CLogger
{
    protected EventLevel _level;

    protected void HandleLog(EventLevel eventLevel, string message)
    {
        if (_level == eventLevel)
        {
            Log(eventLevel, message);
        }
        else
        {
            _nextLogger?.HandleLog(eventLevel, message);
        }
    }

    public CLogger? _nextLogger; // Mark as nullable to satisfy CS8618

    /// <summary>Initializes a new instance of the <see cref="CLoggers" /> class.</summary>
    /// <param name="LevesTohandle">The levels to handle.</param>
    public CLogger(EventLevel LevelTohandle)
    {
        _level = LevelTohandle;
    }

    // protected abstract Task LogAsynch(EventLevel eventLevel, string message);
    public abstract void Log(EventLevel eventLevel, string message);

    public void SetNext(CLogger nextLogger)
    {
        _nextLogger = nextLogger;
    }
}