using NUnit.Framework;
using System;

namespace myhomeworks.Test
{
    public class VariablesTests
    {
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
    }
}
