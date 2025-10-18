using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool result = Email.IsValidEmail(validEmail);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("@abv.bg")]
    [TestCase("didoabv.bg")]
    [TestCase("didoa@")]
    public void Test_IsValidEmail_InvalidEmail(string invalidEmail)
    {
        // Arrange
        //string invalidEmail = "@abv.bg";

        // Act
        bool result = Email.IsValidEmail(invalidEmail);

        // Assert
        Assert.That(result, Is.False);
    }

    [TestCase(" ")]
    [TestCase(null)]
    public void Test_IsValidEmail_NullInput(string email)
    {
        // Arrange

        // Act
        bool result = Email.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.False);
    }
}
