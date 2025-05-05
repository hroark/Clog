using Clog;
using LoggerTypes;
using Xunit;

namespace ClogTests
{
    public class WriteToInformationalFileLoggerTest
    {
        [Fact]
        public void WriteToInformational()
        {
            CLogger fileLogger = new FileLogger("testlog.txt", EventLevel.Informational, true);
            /// fileLogger.SetNext(fileLogger);

            fileLogger.Log(EventLevel.Informational, "This is a test log message.");

            //let's check if the file exists and contains the expected message
            if (File.Exists("testlog.txt"))
            {
                string[] lines = File.ReadAllLines("testlog.txt");
                Assert.Contains(lines, line => line.Contains("This is a test log message."));
            }
            else
            {
                Assert.Fail("Log file was not created.");
            }
        }
    }
}