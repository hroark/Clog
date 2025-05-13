using Clog;
using Clog.ExampleLoggers;

namespace CloggerTests;

public class ConsoleLoggerLogTest_Fail : CLogger, IDisposable
{
    private readonly StringWriter _capturedWriter; // Renamed field to resolve ambiguity
    private readonly TextWriter _stdOutWriter; // Renamed field for consistency

    public ConsoleLoggerLogTest_Fail()
    {
        _stdOutWriter = Console.Out ?? throw new InvalidOperationException("Console.Out cannot be null.");
        _capturedWriter = new StringWriter();
        Console.SetOut(_capturedWriter);
        Test_ConsoleLoggerLog_Fail(); // Call the test method directly
    }

    public object Captured { get; internal set; }
    public TextWriter CapturedWriter => _capturedWriter; // Updated to use renamed field

    public void Dispose()
    {
        Console.SetOut(_stdOutWriter); // Updated to use renamed field
        _capturedWriter.Dispose(); // Updated to use renamed field
    }

    [Fact]
    public void Test_ConsoleLoggerLog_Fail() // Renamed method to avoid conflict with class name
    {
        // Arrange
        ConsoleLogger logger = new ConsoleLogger(new CLogger());// Fixed instantiation to use ConsoleLogger directly
        string? expectedOutput = "Logger Fail";
        // Act
        using (ConsoleLoggerLogTest_Fail outputCapture = new ConsoleLoggerLogTest_Fail())
        {
            Console.Write("Logger");
            // Now you can look in this exact copy of what you've been outputting.
            string? capturedConsole = outputCapture.CapturedWriter.ToString(); // Updated to use renamed property
            Assert.Equal(expectedOutput, capturedConsole);
        }
    }

    //[Fact]
    //public void Test_ConsoleLoggerLog_Pass() // Renamed method for consistency
    //{
    //    // Arrange
    //    ConsoleLogger logger = new ConsoleLogger(); // Fixed instantiation to use ConsoleLogger directly
    //    string? expectedOutput = "Logger Pass";
    //    // Act
    //    using (var outputCapture = new ConsoleLoggerLogTest_Fail())
    //    {
    //        Console.Write("Logger Pass");
    //        // Now you can look in this exact copy of what you've been outputting.
    //        string? capturedConsole = outputCapture.CapturedWriter.ToString(); // Updated to use renamed property
    //        Assert.Equal(expectedOutput, capturedConsole);
    //    }
}