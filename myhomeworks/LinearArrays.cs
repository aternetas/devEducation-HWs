using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myhomeworks
{
    static class LinearArrays
    {
        public static int[] Copy(int[] a)
        {
            int[] newArray = new int[a.Length];
            Array.Copy(a, newArray, a.Length);
            return newArray;
        }

        // Найти минимальный элемент массива (task 1)
        public static int FindTheSmallestElement(int[] a)
        {
            int theSmallestElement = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < theSmallestElement)
                {
                    theSmallestElement = a[i];
                }
            }
            return theSmallestElement;
        }

        // Найти максимальный элемент массива (task 2)
        public static int FindTheBiggestElement(int[] a)
        {
            int theBiggestElement = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > theBiggestElement)
                {
                    theBiggestElement = a[i];
                }
            }
            return theBiggestElement;
        }

        // Найти индекс минимального элемента массива (task 3)
        public static int FindIndexOfTheSmallestElement(int[] a)
        {
            int theSmallestIndex = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < a[theSmallestIndex])
                {
                    theSmallestIndex = i;
                }
            }
            return theSmallestIndex;
        }

        // Найти индекс максимального элемента массива (task 4)
        public static int FindIndexOfTheBiggestElement(int[] a)
        {
            int theBiggestIndex = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > a[theBiggestIndex])
                {
                    theBiggestIndex = i;
                }
            }
            return theBiggestIndex;
        }

        // Посчитать сумму элементов массива с нечетными индексами (task 5)
        public static int FindSumOfElementsWithOddIndexes(int[] a)
        {
            int sum = 0;

            for (int i = 1; i < a.Length; i += 2)
            {
                sum += a[i];
            }
            return sum;
        }

        // Сделать реверс массива (массив в обратном направлении) (task 6)
        public static int[] GetReverseArray(int[] a)
        {
            int[] arrayReverse = Copy(a);
            int n = arrayReverse.Length / 2;

            for (int i = 0; i < n; i++)
            {
                int tmp = arrayReverse[i];
                arrayReverse[i] = arrayReverse[arrayReverse.Length - (1 + i)];
                arrayReverse[arrayReverse.Length - (1 + i)] = tmp;
            }
            return arrayReverse;
        }

        // Посчитать количество нечетных элементов массива (task 7)
        public static int GetOddIndexesCount(int[] a)
        {
            int oddIndexesCount = 0;

            for (int i = 1; i < a.Length; i += 2)
            {
                if (i % 2 != 0)
                {
                    oddIndexesCount++;
                }
            }
            return oddIndexesCount;
        }
    }
}
