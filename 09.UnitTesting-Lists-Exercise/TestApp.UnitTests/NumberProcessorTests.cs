using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> input = new List<int>() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        // Arrange
        List<int> input = new List<int>() { 9, 49, 81 };
        List<double> expected = new List<double>() { 3, 7, 9 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        // Arrange
        List<int> input = new() { 0 };
        List<double> expected = new() { 0 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        // Arrange
        List<int> emptyList = new List<int>();

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(emptyList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // BONUS TESTS - NOT FOR JUDGE
    [Test]
    public void Test_ProcessNumbers_ListWithEvenAndOddNumbers()
    {
        // Arrange
        List<int> input = new List<int>() { 9, 4, 49, 81, 10 };
        List<double> expected = new List<double>() { 3, 16, 7, 9, 100 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ProcessNumbers_NotEqualSquare()
    {
        // Arrange
        List<int> input = new List<int>() { 7, 13 };
        List<double> expected = new List<double>() { 2.64, 3.60 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        double firstElementInResult = Math.Round(result[0], 2);
        double secondElementInResult = Math.Round(result[1], 2);

        // Assert
        Assert.That(firstElementInResult, Is.EqualTo(expected[0]).Within(0.01));
        Assert.That(secondElementInResult, Is.EqualTo(expected[1]).Within(0.01));
    }
}
