using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myhomeworks
{
    static class FirstHw
    {
        // Пользователь вводит 2 числа (A и B). Выведите в консоль решение (5 * a + b * b)/(b - a).
        public static double GetResultOfFraction(double a, double b)
        {
            double numerator = 5 * a + b * b;
            double denominator = b - a;
            double resultOfFraction = numerator / denominator;
            return resultOfFraction;

        }

        // Пользователь вводит 3 не равных 0 числа (A, B и С). Выведите решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.
        public static double GetXOfLinearEquation(double a, double b, double c)
        {
            double x = (c - b) / a;
            return x;
        }

        // Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости. Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.
        public static string GetEquationOfLine(double x1, double x2, double y1, double y2)
        {
            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - (a * x2);
            string result = $"уравнение прямой: y = {a}x + {b}";
            return result;
        }
    }
}
