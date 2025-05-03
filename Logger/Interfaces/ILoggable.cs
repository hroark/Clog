namespace clog.Interfaces;

public interface ILoggable
{
    object Log(object request);

    ILoggable NextLogger(ILoggable logger);
}