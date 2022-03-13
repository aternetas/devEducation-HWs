using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myhomeworks
{
    public static class Variables
    {
        // Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления. (task 1)
        public static void GetQuotientAndRemainder(double a, double b, out double quotient, out double remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        // Пользователь вводит 2 числа (A и B). Выведите в консоль решение (5 * a + b * b)/(b - a). (task 2)
        public static double GetResultOfFraction(double a, double b)
        {
            if (b == a)
            {
                throw new Exception("b must be != a");
            }

            double numerator = 5 * a + b * b;
            double denominator = b - a;
            double resultOfFraction = numerator / denominator;
            return resultOfFraction;
        }

        // Пользователь вводит 2 строковых(string) значения(A и B). Поменяйте содержимое переменных A и B местами. (task 3)
        public static void SwapTwoStrings(ref string a, ref string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
        }

        // Пользователь вводит 3 не равных 0 числа (A, B и С). Выведите решение(значение X) линейного уравнения стандартного вида, где A*X+B=C. (task 4)
        public static double GetXOfLinearEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("a must be != 0");
            }

            double x = (c - b) / a;
            return x;
        }

        // Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости. Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки. (task 5)
        public static string GetEquationOfLine(double x1, double x2, double y1, double y2)
        {
            if (x1 == x2)
            {
                throw new Exception("x1 must be != x2");
            }

            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - (a * x2);
            string result = $"уравнение прямой: y = {a}x + {b}";
            return result;
        }
    }
}
