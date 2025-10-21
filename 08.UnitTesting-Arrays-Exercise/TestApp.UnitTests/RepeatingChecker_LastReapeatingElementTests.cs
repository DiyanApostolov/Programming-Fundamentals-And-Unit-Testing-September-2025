using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_LastReapeatingElementTests
{
    [Test]
    public void Test_FindLastRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        //Arrange
        int[] emptyArray = Array.Empty<int>();
        int expected = -1;

        //Act
        int result = RepeatingChecker.FindLastRepeatingElement(emptyArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        //Arrange
        int[] inputArray = new int[] { 7 };
        int expected = -1;

        //Act
        int result = RepeatingChecker.FindLastRepeatingElement(inputArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        //Arrange
        int[] inputArray = new int[] { 1, 2, 3, 4, 5 };
        int expected = -1;

        //Act
        int result = RepeatingChecker.FindLastRepeatingElement(inputArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        //Arrange
        int[] inputArray = new int[] { 42, 108, 8, -1, 8, -1 };     
        int expected = -1; // Повтарящи числа: 8, -1

        //Act
        int result = RepeatingChecker.FindLastRepeatingElement(inputArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        //Arrange
        int[] inputArray = new int[] { 3, 3, 3, 3, 3 };
        int expected = 3; // Повтарящи числа: 3

        //Act
        int result = RepeatingChecker.FindLastRepeatingElement(inputArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        //Arrange
        int[] inputArray = new int[] { 42, 108, 42, 51, 108, 51 };
        int expected = 51; // Повтарящи числа:  42, 108, 51

        //Act
        int result = RepeatingChecker.FindLastRepeatingElement(inputArray);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
