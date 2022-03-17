using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myhomeworks
{
    public static class IfElse
    {
        // Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B. (task 1)
        public static double GetResultOfNumbersComparison(double a, double b)
        {
            double result = 0;

            if(a > b)
            {
                result = a + b;   
            }
            else if(a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }
            return result;
        }

        // Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y). (task 2)
        public static string GetQuadrantOfCoordinateSystem(double x, double y)
        {
            string quadrant = "";
            if (x == 0 && y == 0)
            {
                quadrant += "центру координатной плоскости";
            }
            else if (x == 0 && y != 0)
            {
                quadrant += "оси ординат (y)";
            }
            else if (x != 0 && y == 0)
            {
                quadrant += "оси абсцисс (x)";
            }

            if (x > 0 && y > 0)
            {
                quadrant += "первой четверти";
            }
            else if (x < 0 && y > 0)
            {
                quadrant += "второй четверти";
            }
            else if (x < 0 && y < 0)
            {
                quadrant += "третьей четверти";
            }
            else if (x > 0 && y < 0)
            {
                quadrant += "четвёртой четверти";
            }
            string result = $"Координаты ({x}, {y}) принадлежат {quadrant}";
            return result;
        }

        // Пользователь вводит 3 числа(A, B и С). Выведите их в консоль в порядке возрастания. (task 3)
        public static int[] WriteNumbersInAscendingOrder(int a, int b, int c)
        {
            int[] result = new int[3] { a, b, c };
            if ((a >= b && b >= c) && (b >= c))
            {
                result[0] = c;
                result[1] = b;
                result[2] = a; //cba
            }
            else if ((b >= a && a >= c) && (a >= c))
            {
                result[0] = c;
                result[1] = a;
                result[2] = b; //cab
            }
            else if ((c >= a && c >= b) && (a >= b))
            {
                result[0] = b;
                result[1] = a;
                result[2] = c; //bac
            }
            else if ((b >= c && b >= a) && (c >= a))
            {
                result[0] = a;
                result[1] = c;
                result[2] = b; //acb
            }
            else if ((a >= c && a >= b) && (c >= b))
            {
                result[0] = b;
                result[1] = c;
                result[2] = a; //bca
            }
            return result;
        }

        // Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где ax²+bx+c=0 (task 4)
        public static double[] GetXOfQuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("a must be !=  0");
            }

            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            double[] result1= new double[2];
            double[] result2= new double[1];
            double squareRoot = Math.Sqrt(discriminant);
            if (discriminant > 0)
            {
                result1[0] = (-b + squareRoot) / (2 * a);
                result1[1] = (-b - squareRoot) / (2 * a);
                return result1;
            }
            else if (discriminant == 0)
            {
                result2[0] = -b / 2 * a;
                return result2;
            }
            else
            {
                throw new Exception("корни отсутствуют");
            }
        }

        // Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”. (task 5)
        public static string WriteNumberbyLetters(int a)
        {
            if (a < 10 || a > 99)
            {
                throw new Exception("only two-digit positive numbers");
            }

            int decade = a / 10;
            int unit = a % 10;
            string numberbyLetters = "";
            if (a >= 20)
            {
                switch (decade)
                {
                    case 2:
                        numberbyLetters += "двадцать";
                        break;
                    case 3:
                        numberbyLetters += "тридцать";
                        break;
                    case 4:
                        numberbyLetters += "сорок";
                        break;
                    case 5:
                        numberbyLetters += "пятьдесят";
                        break;
                    case 6:
                        numberbyLetters += "шестьдесят";
                        break;
                    case 7:
                        numberbyLetters += "семьдесят";
                        break;
                    case 8:
                        numberbyLetters += "восемьдесят";
                        break;
                    case 9:
                        numberbyLetters += "девяносто";
                        break;

                }

                switch (unit)
                {
                    case 1:
                        numberbyLetters += " один";
                        break;
                    case 2:
                        numberbyLetters += " два";
                        break;
                    case 3:
                        numberbyLetters += " три";
                        break;
                    case 4:
                        numberbyLetters += " четыре";
                        break;
                    case 5:
                        numberbyLetters += " пять";
                        break;
                    case 6:
                        numberbyLetters += " шесть";
                        break;
                    case 7:
                        numberbyLetters += " семь";
                        break;
                    case 8:
                        numberbyLetters += " восемь";
                        break;
                    case 9:
                        numberbyLetters += " девять";
                        break;

                }
            }
            else
            {
                switch (a)
                {
                    case 11:
                        numberbyLetters += "одиннадцать";
                        break;
                    case 12:
                        numberbyLetters += "двенадцать";
                        break;
                    case 13:
                        numberbyLetters += "тринадцать";
                        break;
                    case 14:
                        numberbyLetters += "четырнадцать";
                        break;
                    case 15:
                        numberbyLetters += "пятнадцать";
                        break;
                    case 16:
                        numberbyLetters += "шестнадцать";
                        break;
                    case 17:
                        numberbyLetters += "семнадцать";
                        break;
                    case 18:
                        numberbyLetters += "восемнадцать";
                        break;
                    case 19:
                        numberbyLetters += "девятнадцать";
                        break;
                }
                
            }

            return numberbyLetters;
        }
    }
}
