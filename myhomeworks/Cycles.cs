using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myhomeworks
{
    public static class Cycles
    {
        // Пользователь вводит 2 числа (A и B). Возвести число A в степень B. (task 1)
        public static int RaiseNumToAPower(int a, int b)
        {
            if (b < 0)
            {
                throw new Exception("b must be >= 0");
            }
            int result = 1;
            int num = Math.Abs(a);
            if (a == 0)
            {
                result = 0;
            }
            if (b == 0)
            {
                return result;
            }
            for (int i = 1; i <= b; i++)
            {
                result *= num;
            }
            if (a < 0 && b % 2 != 0)
            {
                result *= -1;
            }
            return result;
        }

        //Пользователь вводит 1 число(A). Вывести все числа от 1 до 1000, которые делятся на A. (task 2)
        public static int[] WriteAllNumbersWhichAreDividedByA(int a)
        {
            if (a < 1 || a > 1000)
            {
                throw new Exception("0 < a < 1001");
            }

            int count = 0;
            for (int i = a; i <= 1000; i += a)
            {
                count++;
            }
            int[] result = new int[count];
            int index = 0;
            for (int i = a; i <= 1000; i += a)
            {
                result[index] = i;
                index++;
            }
            return result;
        }

        // Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A. (task 3)
        public static int GetCountOfPositiveNumbers(int a)
        {
            if (a <= 0)
            {
                throw new Exception("a must be > 0");
            }

            int countOfNumbers = 0;
            for (int i = 1; i < a; i++)
            {
                while (countOfNumbers * countOfNumbers < a)
                {
                    countOfNumbers++;
                }
            }         
            return countOfNumbers - 1;
        }

        // Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A. (task 4)
        public static int GetBiggestDivisor(int a)
        {
            int biggestDivisor = 0;
            if (a == 0)
            {
                return biggestDivisor;
            }
            if (a < 0)
            {
                a *= -1;
            }
            for (int i = a - 1; i != 1; i--)
            {
                if (a % i == 0 && a / i == 2)
                {
                    biggestDivisor = i;
                }
            }
            return biggestDivisor;
        }

        // Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A). (task 5)
        public static int GetSumOfAllNumbersWhichDivideBySeven(int a, int b)
        {
            int sum = 0;
            if (a > b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        // Пользователь вводит 1 положительное число (N). Выведите N-ое число ряда фибоначчи. В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1. (task 6)
        public static int GetValueNOfFibonacci(int N)
        {
            int firstNumOfFibonacci = 1;
            int secondNumOfFibonacci = 1;
            int valueNOfFibonacci = 0;
            int i = 2;

            if (N == 1 || N == 2)
            {
                valueNOfFibonacci = 1;
            }
            while (i < N)
            {
                valueNOfFibonacci = firstNumOfFibonacci + secondNumOfFibonacci;
                firstNumOfFibonacci = secondNumOfFibonacci;
                secondNumOfFibonacci = valueNOfFibonacci;
                i++;
            }
            return valueNOfFibonacci;
        }

        // Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида. (task 7)
        public static int GetGreatestCommonDivisor(int a, int b)
        {
            int gcd = 0;

            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == b)
            {
                gcd = a;
            }

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                    gcd = a;
                }
                else
                {
                    b = b - a;
                    gcd = b;
                }
            }

            return gcd;
        }

        // Пользователь вводит 1 число. Найти количество нечетных цифр этого числа. (task 9)
        public static int FindOddsCountOfNumber(int a)
        {
            int oddsCount = 0;

            if (a < 0)
            {
                a = Math.Abs(a);
            }
            if (a % 2 == 0)
            {
                oddsCount = a / 2;
            }
            else
            {
                oddsCount = a / 2 + 1;
            }

            return oddsCount;
        }

        // Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321. (task 10)
        public static string FindMirroredNumber(int a)
        {
            int tmp = 1;
            string mirroredNumber = "";
            int aa = 0;

            if (a == 0)
            {
                mirroredNumber = "0";
            }

            if (a > 0)
            {
                while (a != 0)
                {
                    tmp = a % 10;
                    a /= 10;
                    mirroredNumber += tmp;
                }
            }

            if (a < 0)
            {
                aa = Math.Abs(a);
                while (aa != 0)
                {
                    tmp = aa % 10;
                    aa /= 10;
                    mirroredNumber += tmp;
                }
                mirroredNumber += "-";
            }

            return mirroredNumber;
        }
    }
}
