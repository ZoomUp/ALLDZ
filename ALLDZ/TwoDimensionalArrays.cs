using System;
using System.Collections.Generic;
using System.Text;

namespace ALLDZ
{
    class TwoDimensionalArrays
    {
        public static int Exercise_01()
        {
            // 1. Найти минимальный элемент массива
            int[,] array2d = new int[10, 5];

            Random random = new Random();

            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    array2d[i, j] = random.Next(10, 100);
                }

            }

            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    Console.Write("{0} ", array2d[i, j]);
                }
                Console.WriteLine();

            }
            int minZ1 = array2d[0, 0];



            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    if (minZ1 > array2d[i, j])
                    {
                        minZ1 = array2d[i, j];
                    }
                }

            }

            return minZ1;
        }

        public static int Exercise_02()
        {
            // 2. Найти максимальный элемент массива
            int[,] array2d = new int[10, 5];

            Random random = new Random();

            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    array2d[i, j] = random.Next(10, 100);
                }

            }

            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    Console.Write("{0} ", array2d[i, j]);
                }
                Console.WriteLine();

            }
            int maxZ1 = array2d[0, 0];



            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    if (maxZ1 < array2d[i, j])
                    {
                        maxZ1 = array2d[i, j];
                    }
                }

            }

            return maxZ1;
        }

        public static int[] Exercise_03()
        {
            // 3. Найти индекс минимального элемента массива
            int[,] array2d = new int[10, 5];

            Random random = new Random();

            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    array2d[i, j] = random.Next(10, 101);
                }

            }

            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    Console.Write("{0} ", array2d[i, j]);
                }
                Console.WriteLine();

            }


            int minZ1 = array2d[0, 0];
            int minIndex0 = 0;
            int minIndex1 = 0;


            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    if (minZ1 > array2d[i, j])
                    {
                        minZ1 = array2d[i, j];
                        minIndex0 = i;
                        minIndex1 = j;
                    }
                }

            }
            int[] arrayMinIndex = new int[2] {minIndex0, minIndex1};

            return arrayMinIndex;
        }


        public static int[] Exercise_04()
        {
            // 4. Найти индекс максимального элемента массива
            int[,] array2d = new int[10, 5];

            Random random = new Random();

            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    array2d[i, j] = random.Next(10, 101);
                }

            }

            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    Console.Write("{0} ", array2d[i, j]);
                }
                Console.WriteLine();

            }


            int maxZ1 = array2d[0, 0];
            int maxIndex0 = 0;
            int maxIndex1 = 0;


            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    if (maxZ1 < array2d[i, j])
                    {
                        maxZ1 = array2d[i, j];
                        maxIndex0 = i;
                        maxIndex1 = j;
                    }
                }

            }
            int[] arrayMaxIndex = new int[2] { maxIndex0, maxIndex1 };

            return arrayMaxIndex;
        }

        public static int Exercise_05(int [,] arr)
        {
            // 5. Найти количество элементов массива, которые больше всех своих соседей одновременно

            int counter = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i <= 0 || arr[i, j] > arr[i - 1, j])
                        && (i >= arr.GetLength(0) - 1 || arr[i, j] > arr[i + 1, j])
                        && (j <= 0 || arr[i, j] > arr[i, i - 1])
                        && (j >= arr.GetLength(1) - 1 || arr[i, j] > arr[i, j + 1]))
                    {
                        counter++;

                        Console.WriteLine($"{arr[i, j]} i={i}, j={j}");
                    }
                }
            }
            return counter;
        }



    }
}
