namespace CalculatorTest;

using NUnit.Framework;
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

  [Test]
    public void Add_TwoNumbers_ReturnsSum()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Add(3, 7);

        // Assert
        Assert.That(result, Is.EqualTo(10));
    }

    [Test]
    public void Subtract_TwoNumbers_ReturnsDifference()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Subtract(10, 4);

        // Assert
        Assert.That(result, Is.EqualTo(6));
    }
}