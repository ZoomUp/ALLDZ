using System;
using System.Collections.Generic;
using System.Text;

namespace ALLDZ
{
    public class Arrays
    {
        public static int Exercise_01(int[] arrayZ1)
        {
            // 1. Найти минимальный элемент массива
            int minZ1 = arrayZ1[0];

            for (int i = 0; i < arrayZ1.Length; i++)
            {
                if (minZ1 > arrayZ1[i])
                {
                    minZ1 = arrayZ1[i];
                }
            }
            return minZ1;
        }


        public static int Exercise_02(int[] arrayZ2)
        {
            // 2. Найти максимальный элемент массива
            int minZ2 = arrayZ2[0];

            for (int i = 0; i < arrayZ2.Length; i++)
            {
                if (minZ2 < arrayZ2[i])
                {
                    minZ2 = arrayZ2[i];
                }
            }
            return minZ2;
        }


        public static int Exercise_03(int[] arrayZ3)
        {
            // 3. Найти индекс минимального элемента массива
            int minZ3 = arrayZ3[0];
            int minZ3index = 0;

            for (int i = 0; i < arrayZ3.Length; i++)
            {
                if (minZ3 > arrayZ3[i])
                {
                    minZ3 = arrayZ3[i];
                    minZ3index = i;
                }
            }

            return minZ3index;
        }


        public static int Exercise_04(int[] arrayZ4)
        {
            // 4. Найти индекс максимального элемента массива
            int minZ4 = arrayZ4[0];
            int minZ4index = 0;

            for (int i = 0; i < arrayZ4.Length; i++)
            {
                if (minZ4 < arrayZ4[i])
                {
                    minZ4 = arrayZ4[i];
                    minZ4index = i;
                }
            }

            return minZ4index;
        }


        public static int Exercise_05(int[] arrayZ5)
        {
            // 5. Посчитать сумму элементов массива с нечетными индексами
            int sumIndexOdd = 0;

            for (int i = 0; i < arrayZ5.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sumIndexOdd += arrayZ5[i];
                }
            }

            return sumIndexOdd;
        }


        public static int[] Exercise_06(int[] arrayZ6)
        {
            // 6. Сделать реверс массива (массив в обратном направлении)
            int tmpZ6;

            for (int i = 0; i < arrayZ6.Length / 2; i++)
            {
                tmpZ6 = arrayZ6[i];
                arrayZ6[i] = arrayZ6[arrayZ6.Length - i - 1];
                arrayZ6[arrayZ6.Length - i - 1] = tmpZ6;

            }
            return arrayZ6;
        }


        public static int Exercise_07(int[] arrayZ7)
        {
            // 7. Посчитать количество нечетных элементов массива
            int countIndexOdd = 0;

            for (int i = 0; i < arrayZ7.Length; i++)
            {
                if (i % 2 != 0)
                {
                    countIndexOdd++;
                }
            }

            return countIndexOdd;
        }


        public static int[] Exercise_08(int[] arrayZ8)
        {
            // 8. Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
            int tmpZ8;

            for (int i = 0; i < arrayZ8.Length / 2; i++)
            {
                if (arrayZ8.Length % 2 != 0)
                {
                    tmpZ8 = arrayZ8[i];
                    arrayZ8[i] = arrayZ8[i + 1 + arrayZ8.Length / 2];
                    arrayZ8[i + 1 + arrayZ8.Length / 2] = tmpZ8;

                }
                else
                {
                    tmpZ8 = arrayZ8[i];
                    arrayZ8[i] = arrayZ8[i + arrayZ8.Length / 2];
                    arrayZ8[i + arrayZ8.Length / 2] = tmpZ8;
                }
            }
            return arrayZ8;

        }


        public static int[] Exercise_09(int[] arrayZ9)
        {
            // 9. Отсортировать массив по возрастанию одним из способов:  пузырьком(Bubble), выбором (Select) или вставками (Insert)) 
            for (int i = 0; i < arrayZ9.Length; i++)
            {
                for (int j = 0; j < arrayZ9.Length - i - 1; j++)
                {
                    if (arrayZ9[j] > arrayZ9[j + 1])
                    {
                        int tmp = arrayZ9[j + 1];
                        arrayZ9[j + 1] = arrayZ9[j];
                        arrayZ9[j] = tmp;
                    }
                }
            }
            return arrayZ9;
        }


        public static int[] Exercise_10(int[] arrayZ10)
        {
            // 10. Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании) :  пузырьком(Bubble), выбором (Select) или вставками (Insert))
            for (int i = arrayZ10.Length - 1; i > 0; i--)
            {
                for (int j = i; j < arrayZ10.Length; j++)
                {
                    if (arrayZ10[j - 1] < arrayZ10[j])
                    {
                        int tmp = arrayZ10[j - 1];
                        arrayZ10[j - 1] = arrayZ10[j];
                        arrayZ10[j] = tmp;
                    }
                }
            }
            return arrayZ10;
        }
    }
}
