using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class EvenNumbersTests
{
    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsErrorMessage_WhenStartIsGreaterThanEnd()
    {
        //Arrange
        int start = 10;
        int end = 2;
        string expected = "Start number should be smaller than end number.";

        //Act
        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsErrorMessage_WhenStartIsNegative()
    {
        //Arrange
        int start = -2;
        int end = 10;
        string expected = "Start number should be positive number.";

        //Act
        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEmptyResult_WhenStartAndEndAreEqualOddNumbers()
    {
        //Arrange
        int start = 3;
        int end = 3;
        string expected = "Empty result";

        //Act
        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsSingleEvenNumber_WhenStartAndEndAreEqualEvenNumbers()
    {
        //Arrange
        int start = 2;
        int end = 2;
        string expected = "2";

        //Act
        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEvenNumbers_WhenRangeHasEvens()
    {
        //Arrange
        int start = 1;
        int end = 10;
        string expected = "2, 4, 6, 8, 10";

        //Act
        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEvenNumbers_WhenStartAndEndAreEvenNumbers()
    {
        //Arrange
        int start = 2;
        int end = 8;
        string expected = "2, 4, 6, 8";

        //Act
        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEvenNumbers_WhenStartAndEndAreOddNumbers()
    {
        //Arrange
        int start = 3;
        int end = 9;
        string expected = "4, 6, 8";

        //Act
        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
