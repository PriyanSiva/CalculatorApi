using CalculatorLibrary;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest;
[TestClass]
public class CalculatorTest
{
    private readonly CalculatorService _calculator = new CalculatorService();
    [TestMethod]
    public void TestAdd()
    {
        float x = 5.0f;
        float y = 3.0f;
        float expectedSum = 8.0f;

        float actualSum = _calculator.Add(x, y);

        Assert.AreEqual(expectedSum, actualSum, "Sum is incorrect.");
    }

    [TestMethod]
    public void TestSubtract()
    {
        float x = 10.0f;
        float y = 3.0f;
        float expectedDifference = 7.0f;

        float actualDifference = _calculator.Subtract(x, y);

        Assert.AreEqual(expectedDifference, actualDifference, "Difference is incorrect.");
    }

    [TestMethod]
    public void TestMultiply()
    {
        float x = 2.0f;
        float y = 3.0f;
        float expectedProduct = 6.0f;

        float actualProduct = _calculator.Multiply(x, y);

        Assert.AreEqual(expectedProduct, actualProduct, "Product is incorrect.");
    }

    [TestMethod]
    public void TestDivide_ValidParameters()
    {
        float x = 10.0f;
        float y = 2.0f;
        float expectedQuotient = 5.0f;

        float actualQuotient = _calculator.Divide(x, y);

        Assert.AreEqual(expectedQuotient, actualQuotient, "Quotient is incorrect.");
    }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void TestDivide_ByZero()
    {
        float x = 10.0f;
        float y = 0.0f;

        float actualQuotient = _calculator.Divide(x, y);

    }

    [TestMethod]
    public void TestModulo_ValidParameters()
    {
        float x = 10.0f;
        float y = 3.0f;
        float expectedRemainder = 1.0f; 

        float actualRemainder = _calculator.Modulo(x, y);
       
        Assert.AreEqual(expectedRemainder, actualRemainder, "Remainder is incorrect.");
    }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void TestModulo_ByZero()
    {
        float x = 10.0f;
        float y = 0.0f;

        float actualRemainder = _calculator.Modulo(x, y);
    }
}
