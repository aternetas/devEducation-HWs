using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myhomeworks
{
    public static class TwoDimensionalArrays
    {
        // Найти минимальный элемент массива (task 1)
        public static int FindTheSmallestElement(int[,] a)
        {
            if (a.Length == 0)
            {
                throw new Exception("array must contain elements");
            }

            int theSmallestElement = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < theSmallestElement)
                    {
                        theSmallestElement = a[i, j];
                    }
                }
            }
            return theSmallestElement;
        }

        // Найти максимальный элемент массива (task 2)
        public static int FindTheBiggestElement(int[,] a)
        {
            if (a.Length == 0)
            {
                throw new Exception("array must contain elements");
            }

            int theBiggestElement = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > theBiggestElement)
                    {
                        theBiggestElement = a[i, j];
                    }
                }
            }
            return theBiggestElement;
        }

        // Найти индекс минимального элемента массива (task 3)
        public static int[] FindIndexOfTheSmallestElement(int[,] a)
        {
            if (a.Length == 0)
            {
                throw new Exception("array must contain elements");
            }

            int[] result = new int[2] { 0, 0 };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < a[result[0], result[1]])
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }

        // Найти индекс максимального элемента массива (task 4)
        public static int[] FindIndexOfTheBiggestElement(int[,] a)
        {
            if (a.Length == 0)
            {
                throw new Exception("array must contain elements");
            }

            int[] result = new int[2] { 0, 0 };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > a[result[0], result[1]])
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }

        // Найти количество элементов массива, которые больше всех своих соседей одновременно (task 5)
        public static int GetElementsBiggerItsNeighboursCount(int[,] a)
        {
            if (a.Length == 0)
            {
                throw new Exception("array must contain elements");
            }

            int count = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; i < a.GetLength(1); j++)
                {
                    if (
                        (i == 0 || a[i, j] > a[i - 1, j])
                        && (i == a.GetLength(0) - 1 || a[i, j] > a[i + 1, j])
                        && (j == 0 || a[i, j] > a[i, j - 1])
                        && (j == a.GetLength(1) - 1 || a[i, j] > a[i, j + 1])
                       )
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
