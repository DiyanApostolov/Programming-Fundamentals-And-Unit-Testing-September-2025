using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange
        string[] inputArray = new string[] { "Hello" };
        string[] expectedArray = new[] { "olleH" };

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expectedArray));
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        //Arrange
        string[] inputArray = new string[] { "Dido", "Gosho", "Dimitrichko" };
        string[] expectedArray = new string[] { "odiD", "ohsoG", "okhcirtimiD" };

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expectedArray));
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        //Arrange
        string[] inputArray = new string[] { "Dido#$", "*^@", "s7r@Hil" };
        string[] expectedArray = new string[] { "$#odiD", "@^*", "liH@r7s" };

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expectedArray));
    }

    // BONUS TEST - NOT FOR JUDGE
    [Test]
    public void Test_ReverseStrings_WithSingleCharacterString_ReturnsReversedString()
    {
        // Arrange
        string[] inputArray = new string[] { "H", "a" };
        string[] expectedArray = new[] { "H", "a" };

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expectedArray)); // проверява дали съвпадат елементиоте и по индекс

        Assert.That(result, Is.EquivalentTo(expectedArray)); // просто проверява дали елементите от едната колекжия ги има и в другата колкеция, но може да са разбъркани
    }
}
