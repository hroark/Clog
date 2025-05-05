namespace Clog;

// Changed struct to enum to fix CS1519 and IDE1007 errors
public enum EventLevel
{
    Informational,
    Error,
    Warning,
    Fatal
}