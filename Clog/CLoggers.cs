//using System.Collections;
//using System.Reflection.Emit;
//using System.Runtime.CompilerServices;
//using System.Security.Cryptography.X509Certificates;

//namespace Clog;

///// <summary>The main logger class</summary>
//public abstract class CLoggers : IEnumerable
//{
//    protected Dictionary<EventLevel, Clogger> _logLevels = new(); // Initialize the list to avoid null reference
//    protected CLoggers? _nextLogger; // Mark as nullable to satisfy CS8618

//    protected CLoggers()
//    {
//        List<EventLevel> loggers = new List<EventLevel>();
//        PublicKey Clog
//    }
//    internal void CreateLoggers(CLoggers Loggers)
//    {
//        foreach (EventLevel ResiterLevel in _nextLogger._logLevels)
//        {
//            try
//            {
//                _logLevels.Add(ResiterLevel);
//                _nextLogger = Logger;
//            }
//            catch (Exception ex)
//            {
//                //TODO - something when handling the error since we might have the same EnentLevel
//            }
//        }
//    }
//    public virtual void Log(EventLevel LogLevel, string Message)
//    {
//            // we are registered at this level
//            if ((EventLevels & LogLevel) != 0) // check the enumeration value it can register for
//            {
//                Log(EventLevel, Message);
//            }

//            // pass it onto the nextLogger because this one can't handle it
//            if (_nextLogger != null)
//            {
//                _nextLogger.Log(EventLevel, Message);
//            }

//    }

//    public virtual void Setup()
//    {
//    }

//    public virtual void TearDown()
//    {
//    }

//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        IEnumerator IEnumerable.GetEnumerator()

//        return (IEnumerator)GetEnumerator();

//    }
//}