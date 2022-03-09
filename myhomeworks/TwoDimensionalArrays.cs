using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myhomeworks
{
    static class TwoDimensionalArrays
    {
        // Найти минимальный элемент массива (task 1)
        public static int FindTheSmallestElement(int[,] a)
        {
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
        public static string FindIndexOfTheSmallestElement(int[,] a)
        {
            int theSmallestElement = a[0, 0];
            int minI = 0;
            int minJ = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < theSmallestElement)
                    {
                        minI = i;
                        minJ = j;
                    }
                }
            }

            string theSmallestIndex = $"[{minI}, {minJ}]";
            return theSmallestIndex;
        }

        // Найти индекс максимального элемента массива (task 4)
        public static string FindIndexOfTheBiggestElement(int[,] a)
        {
            int theBiggestElement = a[0, 0];
            int maxI = 0;
            int maxJ = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > theBiggestElement)
                    {
                        maxI = i;
                        maxJ = j;
                    }
                }
            }

            string theBiggestIndex = $"[{maxI}, {maxJ}]";
            return theBiggestIndex;
        }
    }
}
