namespace Clog;

internal interface ILoggable
{
    void Log(EventLevel eventLevel, string Message);
}