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
}