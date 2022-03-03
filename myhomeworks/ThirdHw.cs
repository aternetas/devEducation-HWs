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
    }
}
