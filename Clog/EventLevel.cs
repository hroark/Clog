namespace Clog;

// Changed struct to enum to fix CS1519 and IDE1007 errors
public enum EventLevel
{
    None,
    Informational,
    Error,
    Warning,
    Fatal,
    All
}

[AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
public class LoggerLevelAttribute(EventLevel eventLevel) : Attribute
{
    public EventLevel Level { get; set; } = eventLevel;
}