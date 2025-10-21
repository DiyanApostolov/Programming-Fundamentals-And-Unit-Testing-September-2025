using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_FirstReapeatingElementTests
{
    [Test]
    public void Test_FindFirstRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        // Arange
        int[] emptyArray = Array.Empty<int>();
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        // Arange
        int[] emptyArray = new int[] { 7 };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        // Arange
        int[] emptyArray = new int[] { 7, 42, 3, -5 };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        // Arange
        int[] emptyArray = new int[] { -1, 42, 3, -1 };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        // Arange
        int[] emptyArray = new int[] { 7, 7, 7, 7, 7 };
        int expected = 7;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        // Arange
        int[] emptyArray = new int[] { 7, 17, 3, 7, 8, 3, 5 }; // повтарящи се: 7 и 3
        int expected = 7;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
