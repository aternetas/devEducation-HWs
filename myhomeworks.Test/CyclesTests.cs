using NUnit.Framework;
using System;

namespace myhomeworks.Test
{
    public class CyclesTests
    {
        [TestCase(0, 6, 0)]
        [TestCase(5, 0, 1)]
        [TestCase(1, 1, 1)]
        [TestCase(5, 2, 25)]
        [TestCase(-5, 2, 25)]
        public void RaiseNumToAPowerTest(int a, int b, int expected)
        {
            int actual = Cycles.RaiseNumToAPower(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, -2)]
        public void RaiseNumToAPowerTest_WhenBIsLessZero_ShouldThrowException(int a, int b)
        {
            Assert.Throws<Exception>(()=> Cycles.RaiseNumToAPower(a, b));
        }

        [TestCase(200, new int[] { 200, 400, 600, 800, 1000 })]
        public void WriteAllNumbersWhichAreDividedByATest(int a, int[] expected)
        {
            int[] actual = Cycles.WriteAllNumbersWhichAreDividedByA(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(1005)]
        public void WriteAllNumbersWhichAreDividedByATest_WhenAIsBigger1000OrLess1_ShouldThrowException(int a)
        {
            Assert.Throws<Exception>(() => Cycles.WriteAllNumbersWhichAreDividedByA(a));
        }

        [TestCase(5, 2)]
        [TestCase(10, 3)]
        [TestCase(100, 9)]
        public void GetCountOfPositiveNumbersTest(int a, int expected)
        {
            int actual = Cycles.GetCountOfPositiveNumbers(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void GetCountOfPositiveNumbersTest_WhenAIsLessZero_ShouldThrowException(int a)
        {
            Assert.Throws<Exception>(() => Cycles.GetCountOfPositiveNumbers(a));
        }

        [TestCase(0, 0)]
        [TestCase(100, 50)]
        [TestCase(-30, 15)]
        public void GetBiggestDivisorTest(int a, int expected)
        {
            int actual = Cycles.GetBiggestDivisor(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        public void GetBiggestDivisorTest_WhenAIsEqual1_ShouldThrowException(int a)
        {
            Assert.Throws<Exception>(() => Cycles.GetBiggestDivisor(a));
        }

        [TestCase(1, -30, -70)]
        [TestCase(0, 0, 0)]
        [TestCase(-7, 21, 35)]
        public void GetSumOfAllNumbersWhichAreDividedBySevenTest(int a, int b, int expected)
        {
            int actual = Cycles.GetSumOfAllNumbersWhichAreDividedBySeven(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}