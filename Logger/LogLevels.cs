namespace AFG.Logger

    public class LogLevels
{
    public LogLevels()
    {
        EventLevels = new();
    }

    public void OverrideLogLevels(List<string> levels)
    {
        EventLevels.Clear();

        foreach (string level in levels)
        {
            EventLevels.Add(level);
        }
    }

    public List<string> GetLogLevels()
    {
        return EventLevels;
    }
    public void AddLogLevel(string level)
    {
        if (!EventLevels.Contains(level))
        {
            EventLevels.Add(level);
        }
    }
    public void RemoveLogLevel(string level)
    {
        if (EventLevels.Contains(level))
        {
            EventLevels.Remove(level);
        }
    }