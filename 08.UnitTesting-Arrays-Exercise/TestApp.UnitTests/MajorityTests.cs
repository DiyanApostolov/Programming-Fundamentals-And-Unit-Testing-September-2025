using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MajorityTests
{
    [Test]
    public void Test_IsEvenOrOddMajority_EmpryArray_ReturnsZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();
        int expected = 0;

        // Act
        int result = Majority.IsEvenOrOddMajority(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_ArrayOnlyWithZeros_ReturnsZero()
    {
        // Arrange
        int[] inputArray = new int[] { 0, 0, 0, 0, 0 };
        int expected = 0;

        // Act
        int result = Majority.IsEvenOrOddMajority(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EqualOddAndEvenNumbers_ReturnsZero()
    {
        // Arrange
        int[] inputArray = new int[] { 1, 2, 3, 4, 5, 6 }; // равни множества
        int expected = 0;

        // Act
        int result = Majority.IsEvenOrOddMajority(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EvenMajority_ReturnsPositiveNumber()
    {
        // Arrange
        int[] inputArray = new int[] { 1, 2, 4, 5, 6, 8 }; 
        int expected = 2; // 4 четни, 2 нечетни => 4 - 2 = 2

        // Act
        int result = Majority.IsEvenOrOddMajority(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_OddMajority_ReturnsNegativeNumber()
    {
        // Arrange
        int[] inputArray = new int[] { 1, 3, 4, 5, 4, 8, 13 };
        int expected = -1; // 3 четни, 4 нечетни => 3 - 4 = -1

        // Act
        int result = Majority.IsEvenOrOddMajority(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // BONUS TESTS - NOT FOR JUDGE
    [Test]
    public void Test_IsEvenOrOddMajority_MajorityWithSomeZeros_ReturnsProperNumber()
    {
        // Arrange
        int[] inputArray = new int[] { 0, 1, 2, 0, 4, 5, 6, 0, 8 };
        int expected = 2; // 4 четни, 2 нечетни => 4 - 2 = 2

        // Act
        int result = Majority.IsEvenOrOddMajority(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_MajorityWithNegativeNumbers_ReturnsProperNumber()
    {
        // Arrange
        int[] inputArray = new int[] { 0, -1, -2, 0, 4, -5, 6, 8 };
        int expected = 2; // 4 четни, 2 нечетни => 4 - 2 = 2

        // Act
        int result = Majority.IsEvenOrOddMajority(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

}
