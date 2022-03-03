using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myhomeworks
{
    static class SecondHw
    {
        // Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
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

        // Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).
        public static string GetQuadrantOfCoordinateSystem(double x, double y)
        {
            string quadrant = "";
            if (x > 0 && y > 0)
            {
                quadrant += "первой";
            }
            else if (x < 0 && y > 0)
            {
                quadrant += "второй";
            }
            else if (x < 0 && y < 0)
            {
                quadrant += "третьей";
            }
            else if (x > 0 && y < 0)
            {
                quadrant += "четвёртой";
            }
            string result = $"Координаты ({x}, {y}) принадлежат {quadrant} четверти";
            return result;
        }

        // Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.
        public static string WriteNumberbyLetters(int a)
        {
            int decade = a / 10;
            int unit = a % 10;
            string NumberbyLetters = "";

            if (a >= 20)
            {
                switch (decade)
                {
                    case 2:
                        NumberbyLetters += "двадцать";
                        break;
                    case 3:
                        NumberbyLetters += "тридцать";
                        break;
                    case 4:
                        NumberbyLetters += "сорок";
                        break;
                    case 5:
                        NumberbyLetters += "пятьдесят";
                        break;
                    case 6:
                        NumberbyLetters += "шестьдесят";
                        break;
                    case 7:
                        NumberbyLetters += "семьдесят";
                        break;
                    case 8:
                        NumberbyLetters += "восемьдесят";
                        break;
                    case 9:
                        NumberbyLetters += "девяносто";
                        break;

                }

                switch (unit)
                {
                    case 1:
                        NumberbyLetters += " один";
                        break;
                    case 2:
                        NumberbyLetters += " два";
                        break;
                    case 3:
                        NumberbyLetters += " три";
                        break;
                    case 4:
                        NumberbyLetters += " четыре";
                        break;
                    case 5:
                        NumberbyLetters += " пять";
                        break;
                    case 6:
                        NumberbyLetters += " шесть";
                        break;
                    case 7:
                        NumberbyLetters += " семь";
                        break;
                    case 8:
                        NumberbyLetters += " восемь";
                        break;
                    case 9:
                        NumberbyLetters += " девять";
                        break;

                }
            }
            else
            {
                switch (a)
                {
                    case 11:
                        NumberbyLetters += "одиннадцать";
                        break;
                    case 12:
                        NumberbyLetters += "двенадцать";
                        break;
                    case 13:
                        NumberbyLetters += "тринадцать";
                        break;
                    case 14:
                        NumberbyLetters += "четырнадцать";
                        break;
                    case 15:
                        NumberbyLetters += "пятнадцать";
                        break;
                    case 16:
                        NumberbyLetters += "шестнадцать";
                        break;
                    case 17:
                        NumberbyLetters += "семнадцать";
                        break;
                    case 18:
                        NumberbyLetters += "восемнадцать";
                        break;
                    case 19:
                        NumberbyLetters += "девятнадцать";
                        break;
                }
                
            }

            return NumberbyLetters;
        }
    }
}
