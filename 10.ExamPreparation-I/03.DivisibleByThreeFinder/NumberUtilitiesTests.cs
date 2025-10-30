using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class NumberUtilitiesTests
{
    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenNoNumbersDivisibleByThree()
    {
        //Arrange
        List<int> numbers = new List<int> { 1, 2, 5, 7, 10 };

        //Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenListIsEmpty()
    {
        //Arrange
        List<int> numbers = new(); //new List<int>();

        //Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenListIsNull()
    {
        //Arrange
        List<int> numbers = null;

        //Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnSingleNumber_WhenOnlyOneDivisibleByThree()
    {
        //Arrange
        List<int> numbers = new List<int> { 1, 2, 6, 7, 10 };
        string expected = "6";

        //Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnOnlyNumbersDivisibleByThree_WhenListHasMixedValues()
    {
        //Arrange
        List<int> numbers = new List<int> { 1, 2, 6, 7, 10, 12, 17, 21 };
        string expected = "6, 12, 21";

        //Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldHandleNegativeNumbersCorrectly()
    {
        //Arrange
        List<int> numbers = new List<int> { -1, -2, -6, -7, -10, -12, -17, -21 };
        string expected = "-6, -12, -21";

        //Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnUniqueNumbers_WhenListHasDuplicates()
    {
        //Arrange
        List<int> numbers = new List<int> { 1, 2, 6, 6, 7, 10, 12, 12, 17, 21, 21 };
        string expected = "6, 12, 21";

        //Act
        string result = NumberUtilities.GetDivisibleByThree(numbers);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

}
