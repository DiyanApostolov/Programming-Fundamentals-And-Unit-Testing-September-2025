using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.Tests;

public class MessagingTests
{
    [Test]
    public void Test_GetMessage_WithValidInput_ReturnsExpectedMessage()
    {
        //Arrange
        List<int> numbers = new List<int> { 31, 12, 11, 13, 14 };
        string text = "Desislava";
        string expected = "sisvD";

        //Act
        string result = Messaging.GetMessage(numbers, text);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMessage_EmptyList_ReturnsEmptyString()
    {
        //Arrange
        List<int> numbers = new List<int>();
        string text = "Desislava";

        //Act
        string result = Messaging.GetMessage(numbers, text);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetMessage_EmptyString_ReturnsEmptyString()
    {
        //Arrange
        List<int> numbers = new List<int> { 31, 12, 11, 13, 14 };
        string text = "";

        //Act
        string result = Messaging.GetMessage(numbers, text);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetMessage_NullList_ReturnsEmptyString()
    {
        //Arrange
        List<int> numbers = null;
        string text = "Desislava";

        //Act
        string result = Messaging.GetMessage(numbers, text);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetMessage_NullString_ReturnsEmptyString()
    {
        //Arrange
        List<int> numbers = new List<int> { 31, 12, 11, 13, 14 };
        string text = null;

        //Act
        string result = Messaging.GetMessage(numbers, text);

        //Assert
        Assert.That(result, Is.Empty);
    }
}
