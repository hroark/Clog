using Clog;
using Clog.ExampleLoggers;

namespace CloggerTests;

public class ConsoleLoggerLogTest_Pass : CLogger, IDisposable
{
    private readonly StringWriter _capturedWriter; // Renamed field to resolve ambiguity
    private readonly TextWriter _stdOutWriter; // Renamed field for consistency

    public object Captured { get; internal set; }
    public TextWriter CapturedWriter => _capturedWriter; // Updated to use renamed field

    public ConsoleLoggerLogTest_Pass()
    {
        _stdOutWriter = Console.Out ?? throw new InvalidOperationException("Console.Out cannot be null.");
        _capturedWriter = new StringWriter();
        Console.SetOut(_capturedWriter);
        Captured = string.Empty;
    }

    public void Dispose()
    {
        Console.SetOut(_stdOutWriter); // Updated to use renamed field
        _capturedWriter.Dispose(); // Updated to use renamed field
    }

    [Fact]
    public void ExecuteLogTest() // Renamed method to avoid conflict
    {
        // Arrange
        ConsoleLogger logger = new ConsoleLogger(new CLogger()); // Fixed instantiation to use ConsoleLogger directly
        string? expectedOutput = "Logger Pass";

        // Act
        Console.Write("Logger Pass");
        string? capturedConsole = _capturedWriter.ToString(); // Updated to use the correct field directly

        // Assert
        Assert.Equal(expectedOutput, capturedConsole);
    }
}