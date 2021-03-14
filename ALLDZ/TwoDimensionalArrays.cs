using System;
using System.Collections.Generic;
using System.Text;

namespace ALLDZ
{
    public class TwoDimensionalArrays
    {
        public static int Exercise_01(int[,] array2d)
        {
            // 1. Найти минимальный элемент массива
            if (array2d == null || array2d.GetLength(0) == 0 || array2d.GetLength(1) == 0)
            {
                throw new ArgumentNullException("Ошибка ввода двумерного массива");
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

        public static int Exercise_02(int[,] array2d)
        {
            // 2. Найти максимальный элемент массива
            if (array2d == null || array2d.GetLength(0) == 0 || array2d.GetLength(1) == 0)
            {
                throw new ArgumentNullException("Ошибка ввода двумерного массива");
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

        public static int[] Exercise_03(int[,] array2d)
        {
            // 3. Найти индекс минимального элемента массива
            if (array2d == null || array2d.GetLength(0) == 0 || array2d.GetLength(1) == 0)
            {
                throw new ArgumentNullException("Ошибка ввода двумерного массива");
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


        public static int[] Exercise_04(int[,] array2d)
        {
            // 4. Найти индекс максимального элемента массива
            if (array2d == null || array2d.GetLength(0) == 0 || array2d.GetLength(1) == 0)
            {
                throw new ArgumentNullException("Ошибка ввода двумерного массива");
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

        public static int Exercise_05(int [,] array2d)
        {
            // 5. Найти количество элементов массива, которые больше всех своих соседей одновременно
            if (array2d == null || array2d.GetLength(0) == 0 || array2d.GetLength(1) == 0)
            {
                throw new ArgumentNullException("Ошибка ввода двумерного массива");
            }


            int counter = 0;
            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    if ((i <= 0 || array2d[i, j] > array2d[i - 1, j])
                        && (i >= array2d.GetLength(0) - 1 || array2d[i, j] > array2d[i + 1, j])
                        && (j <= 0 || array2d[i, j] > array2d[i, j - 1])
                        && (j >= array2d.GetLength(1) - 1 || array2d[i, j] > array2d[i, j + 1]))
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        public static int[,] Exercise_06(int[,] array2d)
        {

            if (array2d == null || array2d.GetLength(0) == 0 || array2d.GetLength(1) == 0)
            {
                throw new ArgumentNullException("Ошибка ввода двумерного массива");
            }


            int[,] tmpArray2d = new int[array2d.GetLength(1), array2d.GetLength(0)];
            for (int i = 0; i < array2d.GetLength(1); i++)
            {
                for (int j = 0; j < array2d.GetLength(0); j++)
                {
                    tmpArray2d[i, j] = array2d[j, i];
                }
            }
            return tmpArray2d;
        }
    }
}
