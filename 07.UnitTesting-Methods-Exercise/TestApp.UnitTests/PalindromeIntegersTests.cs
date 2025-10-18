using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{
    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        // Arrange
        List<int> emptyList = new List<int>();

        // Act
        // вдигаме инстанция на класа PalindromeIntegers, защото метода не е статичен
        PalindromeIntegers instantion = new PalindromeIntegers();

        List<int> result = instantion.FindPalindromes(emptyList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {
        // Arrange
        List<int> emptyList = new List<int>() { 123, 365, 102, 34, 554 };

        // Act
        // вдигаме инстанция на класа PalindromeIntegers, защото метода не е статичен
        PalindromeIntegers instantion = new PalindromeIntegers();

        List<int> result = instantion.FindPalindromes(emptyList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> onlySingleDigitsList = new List<int>() { 1, 3, 7, 4, 5 };       

        // Act
        // вдигаме инстанция на класа PalindromeIntegers, защото метода не е статичен
        PalindromeIntegers instantion = new PalindromeIntegers();

        List<int> result = instantion.FindPalindromes(onlySingleDigitsList);

        // Assert
        CollectionAssert.AreEqual(result, onlySingleDigitsList);
    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> allPalindromesList = new List<int>() { 101, 33, 7337, 585 };

        // Act
        // вдигаме инстанция на класа PalindromeIntegers, защото метода не е статичен
        PalindromeIntegers instantion = new PalindromeIntegers();

        List<int> result = instantion.FindPalindromes(allPalindromesList);

        // Assert
        CollectionAssert.AreEqual(result, allPalindromesList);
    }

    [Test]
    public void Test_FindPalindromes_PalimdromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        // Arrange
        List<int> mixedCaseList = new List<int>() { 101, 335, 7537, 585, 423 };
        List<int> expected = new List<int>() { 101, 585 };

        // Act
        // вдигаме инстанция на класа PalindromeIntegers, защото метода не е статичен
        PalindromeIntegers instantion = new PalindromeIntegers();

        List<int> result = instantion.FindPalindromes(mixedCaseList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
