namespace clog;

// Changed struct to enum to fix CS1519 and IDE1007 errors
public enum EventLevels
{
    Informational,
    Error,
    Warning,
    Fatal
}