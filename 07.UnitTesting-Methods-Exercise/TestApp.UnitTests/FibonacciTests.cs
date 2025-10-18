using NUnit.Framework;
using System;
using TestApp;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [TestCase(0, 0)]
    [TestCase(1, 1)]
    [TestCase(-2, -2)]
    public void Test_CalculateFibonacci_ZeroInput(int inputNumber, int expected)
    {
        // Arrange
        //int inputNumber = 0;
        //int expected = 0;

        // Act
        int result = Fibonacci.CalculateFibonacci(inputNumber);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arrange
        int inputNumber = 17;
        int expected = 1597;

        // Act
        int result = Fibonacci.CalculateFibonacci(inputNumber);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}