using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] inputArray = new char[] { 'a', 'T', '7', '#', '3', '$', '0' };
        char[] expectedArray = new char[] { 'a', 'T', '#', '$' };

        // Act
        char[] result = Fake.RemoveStringNumbers(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expectedArray));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] inputArray = new char[] { 'a', 'T', '#', 'Z', '$' };

        // Act
        char[] result = Fake.RemoveStringNumbers(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(inputArray));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] emptyArray = Array.Empty<char>();

        // Act
        char[] result = Fake.RemoveStringNumbers(emptyArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // BONUS TEST - NOT FOR JUDGE
    [Test]
    public void Test_RemoveStringNumbers_ArrayOnlyWithNumbers_ReturnsEmptyArray()
    {
        // Arrange
        char[] emptyArray = new char[] { '7', '2', '0', '5', '2' };

        // Act
        char[] result = Fake.RemoveStringNumbers(emptyArray);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
