using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myhomeworks
{
    static class ThirdHw
    {   
        // Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
        public static int GetCountOfPositiveNumbers(int a)
        {
            int countOfNumbers = 0;

            while(countOfNumbers * countOfNumbers < a)
            {
                countOfNumbers++;
            }
            
            return countOfNumbers - 1;
        }

        // Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
        public static int GetBiggestDivisor(int a)
        {
            if (a < 0)
            {
                a *= -1;
            }

            int biggestDivisor = 0;

            for (int i = a - 1; i != 1; i--)
            {
                if (a % i == 0 && a / i == 2)
                {
                    biggestDivisor = i;
                }
            }
            return biggestDivisor;
        }

        // Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).
        public static int GetSumOfAllNumbers(int a, int b)
        {
            int sum = 0; 
            int i = 0; 

            if (a < b)
            {
                for (i = a; i < b; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }
            else
            {
                for (i = b; i < a; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }
            return sum;
        }
    }
}
