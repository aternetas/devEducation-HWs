using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myhomeworks
{
    public static class LinearArrays
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
            if (a.Length == 0)
            {
                throw new Exception("array must contain elements");
            }

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
            if (a.Length == 0)
            {
                throw new Exception("array must contain elements");
            }

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
            if (a.Length == 0)
            {
                throw new Exception("array must contain elements");
            }

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
            if (a.Length == 0)
            {
                throw new Exception("array must contain elements");
            }

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
            if (a.Length == 0)
            {
                throw new Exception("array must contain elements");
            }

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
            if (a.Length == 0)
            {
                throw new Exception("array must contain elements");
            }

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

        // Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312. (task 8)
        public static int[] SwapFirstAndSecondHalfs(int[] a)
        {
            int[] result = Copy(a);
            int n = result.Length / 2;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int tmp = result[i];
                result[i] = result[n + 1 + count];
                result[n + 1 + count] = tmp;
                count++;
            }
            return result;
        }

        // Отсортировать массив по возрастанию одним из способов: пузырьком (Bubble), выбором (Select) или вставками (Insert). (task 9)
        public static int[] SortAscendingSelect(int[] a)
        {
            int[] arraySortSelect = Copy(a);
            int lenght = arraySortSelect.Length;

            for (int i = 0; i < lenght - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < lenght; j++)
                {
                    if (arraySortSelect[j] < arraySortSelect[min])
                    {
                        min = j;
                    }
                }

                int tmp = arraySortSelect[i];
                arraySortSelect[i] = arraySortSelect[min];
                arraySortSelect[min] = tmp;
            }
            return arraySortSelect;
        }

        // Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании):  пузырьком(Bubble), выбором (Select) или вставками (Insert). (task 10)
        public static int[] SortDescendingBubble(int[] a)
        {
            int[] arraySortBubble = Copy(a);
            int lenght = arraySortBubble.Length;

            for (int i = 0; i < lenght; i++)
            {
                for (int j = lenght - 1; j > i; j--)
                {
                    if (arraySortBubble[j] > arraySortBubble[j - 1])
                    {
                        int tmp = arraySortBubble[j];
                        arraySortBubble[j] = arraySortBubble[j - 1];
                        arraySortBubble[j - 1] = tmp;
                    }
                }
            }
            return arraySortBubble;
        }
    }
}
