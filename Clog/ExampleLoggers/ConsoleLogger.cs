namespace Clog.ExampleLoggers;

public class ConsoleLogger : CLogger
{
    public ConsoleLogger(CLogger NewWatcher) : base(NewWatcher)
    {
        _subscriptionLevel = NewWatcher._subscriptionLevel;
    }

    public override void Log(EventLevel CurrentLevel, string Message)
    {
        if (CurrentLevel == _subscriptionLevel)
        {
            Console.WriteLine(Message);
        }
    }
}