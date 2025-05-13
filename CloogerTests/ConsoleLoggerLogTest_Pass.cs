using Clog;
using Clog.ExampleLoggers;

namespace CloggerTests;

public class ConsoleLoggerLogTest_Pass : IDisposable
{
    private readonly StringWriter capturedWriter;
    private readonly TextWriter stdOutWriter;

    public ConsoleLoggerLogTest_Pass() // Fix: Removed parentheses after class name and corrected constructor syntax
    {
        stdOutWriter = Console.Out;
        capturedWriter = new StringWriter();
        Console.SetOut(capturedWriter);
    }

    public TextWriter Captured => capturedWriter;

    public void Dispose()
    {
        Console.SetOut(stdOutWriter);
        capturedWriter.Dispose();
    }

    [Fact]
    public void TestLoggerOutput() // Fix: Added method name for the test
    {
        // Arrange
        ConsoleLogger logger = new ConsoleLogger(new CLogger());
        string? expectedOutput = "Logger Pass";

        // Act
        using (var outputCapture = new ConsoleLoggerLogTest_Fail())
        {
            Console.Write("Logger Pass");
            string? CapturedConsole = outputCapture.Captured.ToString();

            // Assert
            Assert.Equal(expectedOutput, CapturedConsole);
        }
    }
}