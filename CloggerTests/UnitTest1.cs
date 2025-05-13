using Xunit;

namespace Clog.Tests
{
    public class UnitTest1
    {
        [Fact()]
        public void LoggerSubscptionTest()
        {
            FileLogger fileLogger = new FileLogger(EventLevel.Informational);
            Xunit.Assert.Fail("This test needs an implementation");
        }

        [Fact()]
        public void LoggerUnsubsribeTest()
        {
            Xunit.Assert.Fail("This test needs an implementation");
        }
    }
}

namespace CloggerTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
        }
    }
}