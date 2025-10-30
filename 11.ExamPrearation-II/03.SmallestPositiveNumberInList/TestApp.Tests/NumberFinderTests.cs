using System;
using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework;

namespace TestApp.Tests;

public class NumberFinderTests
{
    [Test]
    public void Test_FindSmallestPositive_ShouldReturnError_WhenListIsNull()
    {
        // Arrange
        List<int> nullList = null; // липса на стойност
        string expected = "List cannot be empty.";

        // Act
        string result = NumberFinder.FindSmallestPositive(nullList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnError_WhenListIsEmpty()
    {
        // Arrange
        List<int> emptyList = new List<int>(); // празен лист
        string expected = "List cannot be empty.";

        // Act
        string result = NumberFinder.FindSmallestPositive(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnSmallest_WhenListHasPositiveNumbers()
    {
        // Arrange
        List<int> numbers = new List<int>() { 45, 4, 8, 37, 15, 54, 9 };
        string expected = "Smallest positive number is: 4";

        // Act
        string result = NumberFinder.FindSmallestPositive(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnSmallest_WhenListHasMixedNumbers()
    {
        // Arrange
        List<int> numbers = new List<int>() { 45, -4, 8, -7, 15, 54, -99 };
        string expected = "Smallest positive number is: 8";

        // Act
        string result = NumberFinder.FindSmallestPositive(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldReturnNotFoundMessage_WhenAllNumbersAreNegativeOrZero()
    {
        // Arange
        List<int> numbers = new List<int>() { -3, -12, 0, -5, -100 };
        string expected = "No positive numbers found.";

        // Act
        string result = NumberFinder.FindSmallestPositive(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindSmallestPositive_ShouldHandleDuplicates_Correctly()
    {
        // Arrange
        List<int> numbers = new List<int>() { 42, 7, 13, -5, 7, 50 };
        string expected = "Smallest positive number is: 7";

        // Act
        string result = NumberFinder.FindSmallestPositive(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
