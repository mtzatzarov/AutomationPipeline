using System.IO;
using Newtonsoft.Json;
using NUnit.Framework;

[TestFixture]
public class IntegrationTests
{
    private class TestParameters
    {
        public int A { get; set; }
        public int B { get; set; }
        public int ExpectedResult { get; set; }
    }

    [Test]
    public void AddAndLog_ValidInput_ReturnsSumAndLogs()
    {
        // Arrange
        Calculator calculator = new Calculator();
        Logger logger = new Logger();
        CalculatorWithLogging calculatorWithLogging = new CalculatorWithLogging(calculator, logger);

        // Read test parameters from config file
        TestParameters parameters = ReadTestParameters("AddAndLogTest");

        // Act
        int result = calculatorWithLogging.AddAndLog(parameters.A, parameters.B);

        // Assert
        Assert.That(result, Is.EqualTo(parameters.ExpectedResult));
        // Add your assertions for logging
    }

    [Test]
    public void SubtractAndLog_ValidInput_ReturnsDifferenceAndLogs()
    {
        // Arrange
        Calculator calculator = new Calculator();
        Logger logger = new Logger();
        CalculatorWithLogging calculatorWithLogging = new CalculatorWithLogging(calculator, logger);

        // Read test parameters from config file
        TestParameters parameters = ReadTestParameters("SubtractAndLogTest");

        // Act
        int result = calculatorWithLogging.SubtractAndLog(parameters.A, parameters.B);

        // Assert
        Assert.That(result, Is.EqualTo(parameters.ExpectedResult));
        // Add your assertions for logging
    }

    private TestParameters ReadTestParameters(string testName)
    {
        string configFilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "config.json");
        string json = File.ReadAllText(configFilePath);
        dynamic config = JsonConvert.DeserializeObject(json);

        return new TestParameters
        {
            A = config[testName].a,
            B = config[testName].b,
            ExpectedResult = config[testName].expectedResult
        };
    }
}
