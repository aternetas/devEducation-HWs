using NUnit.Framework;
using System;

namespace myhomeworks.Test
{
    public class IfElseTests
    {
        [TestCase(8.76, 3.1, 11.86)]
        [TestCase(5, 5, 25)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(-3, 8, -11)]
        public void GetResultOfNumbersComparisonTest(double a, double b, double expected)
        {
            double actual = IfElse.GetResultOfNumbersComparison(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, $"Координаты (0, 0) принадлежат центру координатной плоскости")]
        [TestCase(0, -7, $"Координаты (0, -7) принадлежат оси ординат (y)")]
        [TestCase(3, 0, $"Координаты (3, 0) принадлежат оси абсцисс (x)")]
        [TestCase(6, 3, $"Координаты (6, 3) принадлежат первой четверти")]
        [TestCase(-7, 5, $"Координаты (-7, 5) принадлежат второй четверти")]
        [TestCase(-9, -4, $"Координаты (-9, -4) принадлежат третьей четверти")]
        [TestCase(10, -10, $"Координаты (10, -10) принадлежат четвёртой четверти")]
        public void GetQuadrantOfCoordinateSystemTest(double x, double y, string expected)
        {
            string actual = IfElse.GetQuadrantOfCoordinateSystem(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1, 4, new int[] {0, 1, 4})]
        [TestCase(4, -6, -10, new int[] { -10, -6, 4 })]
        [TestCase(2, 9, 0, new int[] { 0, 2, 9 })]
        [TestCase(1, 0, 2, new int[] { 0, 1, 2 })]
        [TestCase(-5, 8, 3, new int[] { -5, 3, 8 })]
        [TestCase(10, 4, 6, new int[] { 4, 6, 10 })]
        public void WriteNumbersInAscendingOrderTest(int a, int b, int c, int[] expected)
        {
            int[] actual = IfElse.WriteNumbersInAscendingOrder(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 14, 2, new double[] { -0.14589803375031529, -6.8541019662496847 })]
        [TestCase(-4, 28, -49, new double[] { 56 })]
        public void GetXOfQuadraticEquationTest(double a, double b, double c, double[] expected)
        {
            double[] actual = IfElse.GetXOfQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 5, 10)]
        public void GetXOfQuadraticEquationTest_WhenAIsEqualZero_ShouldThrowException(double a, double b, double c)
        {
            Assert.Throws<Exception>(()=> IfElse.GetXOfQuadraticEquation(a, b, c));
        }

        [TestCase(16, 5, 2)]
        public void GetXOfQuadraticEquationTest_WhenDiscriminantIsLessZero_ShouldThrowException(double a, double b, double c)
        {
            Assert.Throws<Exception>(() => IfElse.GetXOfQuadraticEquation(a, b, c));
        }

        [TestCase(13, "тринадцать")]
        [TestCase(50, "пятьдесят")]
        [TestCase(86, "восемьдесят шесть")]
        public void WriteNumberbyLettersTest(int a, string expected)
        {
            string actual = IfElse.WriteNumberbyLetters(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8)]
        [TestCase(-5)]
        public void WriteNumberbyLettersTest_WhenAIsLessThanTen_ShouldThrowException(int a)
        {
            Assert.Throws<Exception>(() => IfElse.WriteNumberbyLetters(a));
        }

        [TestCase(100)]
        [TestCase(1000)]
        public void WriteNumberbyLettersTest_WhenAIsMoreThanNinetyNine_ShouldThrowException(int a)
        {
            Assert.Throws<Exception>(() => IfElse.WriteNumberbyLetters(a));
        }
    }
}