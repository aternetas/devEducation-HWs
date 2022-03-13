using NUnit.Framework;
using System;

namespace myhomeworks.Test
{
    public class LinearArraysTests
    {
        [TestCase(new int[] { 0, 1, -2, 3 }, -2)]
        [TestCase(new int[] { 10 }, 10)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        public void FindTheSmallestElementTest(int[] a, int expected)
        {
            int actual = LinearArrays.FindTheSmallestElement(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {})]
        public void FindTheSmallestElementTest_WhenArrayIsEmpty_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(()=> LinearArrays.FindTheSmallestElement(a));
        }

        [TestCase(new int[] { -5, 1, -2, 0 }, 1)]
        [TestCase(new int[] { 10 }, 10)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        public void FindTheBiggestElementTest(int[] a, int expected)
        {
            int actual = LinearArrays.FindTheBiggestElement(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindTheBiggestElementTest_WhenArrayIsEmpty_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => LinearArrays.FindTheBiggestElement(a));
        }

        [TestCase(new int[] { -5, -8, 2, 0 }, 1)]
        [TestCase(new int[] { 10 }, 0)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        public void FindIndexOfTheSmallestElementTest(int[] a, int expected)
        {
            int actual = LinearArrays.FindIndexOfTheSmallestElement(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindIndexOfTheSmallestElementTest_WhenArrayIsEmpty_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => LinearArrays.FindIndexOfTheSmallestElement(a));
        }

        [TestCase(new int[] { 0, -8, 2, 78 }, 3)]
        [TestCase(new int[] { 7 }, 0)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        public void FindIndexOfTheBiggestElementTest(int[] a, int expected)
        {
            int actual = LinearArrays.FindIndexOfTheBiggestElement(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindIndexOfTheBiggestElementTest_WhenArrayIsEmpty_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => LinearArrays.FindIndexOfTheBiggestElement(a));
        }

        [TestCase(new int[] { 0, -8, 2, 10, 5 }, 2)]
        [TestCase(new int[] { 7 }, 0)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        public void FindSumOfElementsWithOddIndexesTest(int[] a, int expected)
        {
            int actual = LinearArrays.FindSumOfElementsWithOddIndexes(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindSumOfElementsWithOddIndexesTest_WhenArrayIsEmpty_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => LinearArrays.FindSumOfElementsWithOddIndexes(a));
        }

        [TestCase(new int[] { -37, -8, 2, 0, 5 }, new int[] { 5, 0, 2, -8, -37 })]
        [TestCase(new int[] { 3 }, new int[] { 3 })]
        [TestCase(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        public void ReverseArrayTest(int[] a, int[] expected)
        {
            int[] actual = LinearArrays.ReverseArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, -8, 2, 10, 5, 1 }, 3)]
        [TestCase(new int[] { 7 }, 0)]
        [TestCase(new int[] { 0, 0, 0 }, 1)]
        [TestCase(new int[] { 0 }, 0)]
        public void GetOddIndexesCountTest(int[] a, int expected)
        {
            int actual = LinearArrays.GetOddIndexesCount(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void GetOddIndexesCountTest_WhenArrayIsEmpty_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => LinearArrays.GetOddIndexesCount(a));
        }

        [TestCase(new int[] { -3, -8, 2, 0, 5 }, new int[] { 0, 5, 2, -3, -8 })]
        [TestCase(new int[] { 14, -1, 43, 1, 4, 9 }, new int[] { 1, 4, 9, 14, -1, 43 })]
        [TestCase(new int[] { 3 }, new int[] { 3 })]
        [TestCase(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        public void SwapFirstAndSecondHalfsTest(int[] a, int[] expected)
        {
            int[] actual = LinearArrays.SwapFirstAndSecondHalfs(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 21, 2, 2, 0, -3, -6 }, new int[] { -6, -3, 0, 2, 2, 21 })]
        [TestCase(new int[] { -4, -1, 5, 8, 11 }, new int[] { -4, -1, 5, 8, 11 })]
        [TestCase(new int[] { 3 }, new int[] { 3 })]
        [TestCase(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        public void SortAscendingSelectTest(int[] a, int[] expected)
        {
            int[] actual = LinearArrays.SortAscendingSelect(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 24, 0, -3, -2 }, new int[] { 24, 2, 1, 0, -2, -3 })]
        [TestCase(new int[] { 95, 72, 32, 12, -37 }, new int[] { 95, 72, 32, 12, -37 })]
        [TestCase(new int[] { 3 }, new int[] { 3 })]
        [TestCase(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        public void SortDescendingBubbleTest(int[] a, int[] expected)
        {
            int[] actual = LinearArrays.SortDescendingBubble(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
