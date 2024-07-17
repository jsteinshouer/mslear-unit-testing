namespace LearnMyCalculatorApp.Tests;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnMyCalculatorApp;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void CalculatorNullTest()
    {
        var calculator = new Calculator();
        Assert.IsNotNull(calculator);
        // Assert.IsTrue(false); // Will fail the test
    }

    [TestMethod]
    public void AddTest()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var actual = calculator.Add(1, 1);

        // Assert
        Assert.AreEqual(2, actual);
    }

    [TestMethod]
    public void SubtractTest()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var actual = calculator.Subtract(10, 5);

        // Assert
        Assert.AreEqual(5, actual);
    }

    [TestMethod]
    public void MultiplyTest()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var actual = calculator.Multiply(7, 7);

        // Assert
        Assert.AreEqual(49, actual);
    }

    [TestMethod]
    public void DivideTest()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var actual = calculator.Divide(4, 2);

        // Assert
        Assert.AreEqual(2, actual);
    }
}