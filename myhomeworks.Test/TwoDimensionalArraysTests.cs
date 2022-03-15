using NUnit.Framework;
using System;

namespace myhomeworks.Test
{
    public class TwoDimensionalArraysTests
    {
        [TestCase(Enums.TwoDimensionalArraysMockType.ZeroOnly, 0)]
        [TestCase(Enums.TwoDimensionalArraysMockType.First, -15)]
        public void FindTheSmallestElementTest(Enums.TwoDimensionalArraysMockType type, int expected)
        {
            int[,] a = TwoDimensionalArraysMock.GetMock(type);
            int actual = TwoDimensionalArrays.FindTheSmallestElement(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(Enums.TwoDimensionalArraysMockType.Empty)]
        public void FindTheSmallestElementTest_WhenArrayIsEmpty_ShouldThrowException(Enums.TwoDimensionalArraysMockType type)
        {
            int[,] a = TwoDimensionalArraysMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensionalArrays.FindTheSmallestElement(a));
        }

        [TestCase(Enums.TwoDimensionalArraysMockType.ZeroOnly, 0)]
        [TestCase(Enums.TwoDimensionalArraysMockType.First, 14)]
        public void FindTheBiggestElementTest(Enums.TwoDimensionalArraysMockType type, int expected)
        {
            int[,] a = TwoDimensionalArraysMock.GetMock(type);
            int actual = TwoDimensionalArrays.FindTheBiggestElement(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(Enums.TwoDimensionalArraysMockType.Empty)]
        public void FindTheBiggestElementTest_WhenArrayIsEmpty_ShouldThrowException(Enums.TwoDimensionalArraysMockType type)
        {
            int[,] a = TwoDimensionalArraysMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensionalArrays.FindTheBiggestElement(a));
        }
    }
}
