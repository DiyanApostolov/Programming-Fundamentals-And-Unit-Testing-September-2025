using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class TextCensorTests
{
    [Test]
    public void CensorWord_ShouldReturnError_WhenSentenceIsNull()
    {
        //Arrange
        string sentence = null;
        string wordToCensor = "word";
        string errorMessage = "Sentence cannot be empty.";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        // Assert
        Assert.That(result, Is.EqualTo(errorMessage));
    }

    [Test]
    public void CensorWord_ShouldReturnError_WhenSentenceIsWhitespace()
    {
        //Arrange
        string sentence = "   ";
        string wordToCensor = "word";
        string errorMessage = "Sentence cannot be empty.";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        // Assert
        Assert.That(result, Is.EqualTo(errorMessage));
    }

    [Test]
    public void CensorWord_ShouldReturnError_WhenWordIsNull()
    {
        // Arrange
        string sentence = "This is a bad word";
        string wordToCensor = null;
        string errorMessage = "Word to censor cannot be empty.";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        // Assert
        Assert.That(result, Is.EqualTo(errorMessage));
    }

    [Test]
    public void CensorWord_ShouldReturnError_WhenWordIsWhitespace()
    {
        // Arrange
        string sentence = "This is a bad word";
        string wordToCensor = "  ";
        string errorMessage = "Word to censor cannot be empty.";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        // Assert
        Assert.That(result, Is.EqualTo(errorMessage));
    }

    [Test]
    public void CensorWord_ShouldReplaceSingleOccurrence()
    {
        // Arrange
        string sentence = "This is a bad word";
        string wordToCensor = "bad";
        string expected = "This is a *** word";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReplaceMultipleOccurrences()
    {
        // Arrange
        string sentence = "bad habbits are bad";
        string wordToCensor = "bad";
        string expected = "*** habbits are ***";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void CensorWord_ShouldReturnOriginal_WhenWordNotFound()
    {
        // Arrange
        string sentence = "This is a bad word";
        string wordToCensor = "invalid";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        // Assert
        Assert.That(result, Is.EqualTo(sentence));
    }

    [Test]
    public void CensorWord_ShouldReplaceCaseInsensitive()
    {
        // Arrange
        string sentence = "This is a bad Bad BAD bAd words.";
        string wordToCensor = "bad";
        string expected = "This is a *** *** *** *** words.";

        // Act
        string result = TextCensor.CensorWord(sentence, wordToCensor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}