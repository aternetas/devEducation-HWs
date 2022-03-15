using NUnit.Framework;
using System;

namespace myhomeworks.Test
{
    public class VariablesTests
    {
        [TestCase(15, 3, 5, 0)]
        [TestCase(0, 1, 0, 0)]
        [TestCase(-10, 3, -3.3333333333333335, -1)]
        [TestCase(-43.4, -4, 10.85d, -3.3999999999999986)]
        public void GetQuotientAndRemainderTest(double a, double b, double expectedQ, double expectedR)
        {
            double actualQ;
            double actualR;
            Variables.GetQuotientAndRemainder(a, b, out actualQ, out actualR);
            Assert.AreEqual(actualQ, expectedQ);
            Assert.AreEqual(actualR, expectedR);
        }

        [TestCase(4, 0)]
        public void GetQuotientAndRemainderTest_WhenBIsEqualZero_ShouldThrowException(double a, double b)
        {
            double result1;
            double result2;
            Assert.Throws<Exception>(() => Variables.GetQuotientAndRemainder(a, b, out result1, out result2));
        }

        [TestCase(32.2, 53.1, 142.6129186602871)]
        [TestCase(0, 1, 1)]
        [TestCase(1, 0, -5)]
        [TestCase(3, 5, 20)]
        public void GetResultOfFractionTest(double a, double b, double expected)
        {
            double actual = Variables.GetResultOfFraction(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        public void GetResultOfFractionTest_WhenBIsEqualA_ShouldThrowException(double a, double b)
        {
            Assert.Throws<Exception>(() => Variables.GetResultOfFraction(a, b));
        }

        [TestCase("abc", "qwe", "qwe", "abc")]
        [TestCase("55", "99", "99", "55")]
        [TestCase("", "", "", "")]
        public void SwapTwoStringsTest(string a, string b, string expectedA, string expectedB)
        {
            Variables.SwapTwoStrings(ref a, ref b);
            Assert.AreEqual(a, expectedA);
            Assert.AreEqual(b, expectedB);
        }

        [TestCase(5, 2, 1, -0.2)]
        [TestCase(-12.5, 22.4, 1.786, 1.6491199999999997)]
        [TestCase(1, 0, 0, 0)]
        [TestCase(1, 1, 1, 0)]
        [TestCase(-1, -1, -1, 0)]
        public void GetXOfLinearEquationTest(double a, double b, double c, double expected)
        {
            double actual = Variables.GetXOfLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 5, -4)]
        public void GetXOfLinearEquationTest_WhenAIsEqualZero_ShouldThrowException(double a, double b, double c)
        {
            Assert.Throws<Exception>(()=> Variables.GetXOfLinearEquation(a, b, c));
        }

        [TestCase(1, 0, 1, 1, "уравнение прямой: y = 1")]
        [TestCase(0, 4, 3, 10, "уравнение прямой: y = 1,75x + 3")]
        [TestCase(0, 2, 0, 0, "уравнение прямой: y = 0")]
        [TestCase(1, -1, -1, -1, "уравнение прямой: y = -1")]
        public void GetEquationOfLineTest(double x1, double x2, double y1, double y2, string expected)
        {
            string actual = Variables.GetEquationOfLine(x1, x2, y1, y2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, 5, 2)]
        public void GetEquationOfLineTest(double x1, double x2, double y1, double y2)
        {
            Assert.Throws<Exception>(()=> Variables.GetEquationOfLine(x1, x2, y1, y2));
        }
    }
}
