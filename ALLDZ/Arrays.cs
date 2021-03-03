using System;
using System.Collections.Generic;
using System.Text;

namespace ALLDZ
{
    class Arrays
    {
        public static void Exercise_01()
        {
            // 1. Найти минимальный элемент массива
            Console.WriteLine("Первое задание.");


            int[] arrayZ1 = new int[20];
            Random random = new Random();

            for (int i = 0; i < arrayZ1.Length; i++)
            {
                arrayZ1[i] = random.Next(-100, 101);
            }
            for (int i = 0; i < arrayZ1.Length; i++)
            {
                Console.Write(arrayZ1[i] + " ");
            }

            int minZ1 = arrayZ1[0];

            for (int i = 0; i < arrayZ1.Length; i++)
            {
                if (minZ1 > arrayZ1[i])
                {
                    minZ1 = arrayZ1[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Ответ на первое задание: " + minZ1);
        }


        public static void Exercise_02()
        {
            // 2. Найти максимальный элемент массива
            Console.WriteLine();
            Console.WriteLine("Второе задание.");

            int[] arrayZ2 = new int[20];
            Random random2 = new Random();

            for (int i = 0; i < arrayZ2.Length; i++)
            {
                arrayZ2[i] = random2.Next(-100, 101);
            }
            for (int i = 0; i < arrayZ2.Length; i++)
            {
                Console.Write(arrayZ2[i] + " ");
            }

            int minZ2 = arrayZ2[0];

            for (int i = 0; i < arrayZ2.Length; i++)
            {
                if (minZ2 < arrayZ2[i])
                {
                    minZ2 = arrayZ2[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Ответ на второе задание: " + minZ2);
        }


        public static void Exercise_03()
        {
            // 3. Найти индекс минимального элемента массива
            Console.WriteLine();
            Console.WriteLine("Третье задание.");

            int[] arrayZ3 = new int[20];
            Random random3 = new Random();

            for (int i = 0; i < arrayZ3.Length; i++)
            {
                arrayZ3[i] = random3.Next(-100, 101);
            }
            for (int i = 0; i < arrayZ3.Length; i++)
            {
                Console.Write(arrayZ3[i] + " ");
            }

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

            Console.WriteLine();
            Console.WriteLine("Ответ на третье задание: " + minZ3index);
        }


        public static void Exercise_04()
        {
            // 4. Найти индекс максимального элемента массива
            Console.WriteLine();
            Console.WriteLine("Четвертое задание.");

            int[] arrayZ4 = new int[20];
            Random random4 = new Random();

            for (int i = 0; i < arrayZ4.Length; i++)
            {
                arrayZ4[i] = random4.Next(-100, 101);
            }
            for (int i = 0; i < arrayZ4.Length; i++)
            {
                Console.Write(arrayZ4[i] + " ");
            }

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

            Console.WriteLine();
            Console.WriteLine("Ответ на четвертое задание: " + minZ4index);
        }


        public static void Exercise_05()
        {
            // 5. Посчитать сумму элементов массива с нечетными индексами
            Console.WriteLine();
            Console.WriteLine("Пятое задание.");

            int[] arrayZ5 = new int[20];
            Random random5 = new Random();

            for (int i = 0; i < arrayZ5.Length; i++)
            {
                arrayZ5[i] = random5.Next(-100, 101);
            }
            for (int i = 0; i < arrayZ5.Length; i++)
            {
                Console.Write(arrayZ5[i] + " ");
            }

            int sumIndexOdd = 0;

            for (int i = 0; i < arrayZ5.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sumIndexOdd += arrayZ5[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Ответ на пятое задание: " + sumIndexOdd);
        }


        public static void Exercise_06()
        {
            // 6. Сделать реверс массива (массив в обратном направлении)
            Console.WriteLine();
            Console.WriteLine("Шестое задание.");

            int[] arrayZ6 = new int[21];
            Random random6 = new Random();

            for (int i = 0; i < arrayZ6.Length; i++)
            {
                arrayZ6[i] = random6.Next(-100, 101);
            }
            for (int i = 0; i < arrayZ6.Length; i++)
            {
                Console.Write(arrayZ6[i] + " ");
            }

            int tmpZ6;

            for (int i = 0; i < arrayZ6.Length / 2; i++)
            {
                tmpZ6 = arrayZ6[i];
                arrayZ6[i] = arrayZ6[arrayZ6.Length - i - 1];
                arrayZ6[arrayZ6.Length - i - 1] = tmpZ6;

            }
            Console.WriteLine("Ответ на пятое задание:");
            for (int i = 0; i < arrayZ6.Length; i++)
            {
                Console.Write(arrayZ6[i] + " ");
            }
            Console.WriteLine();
        }


        public static void Exercise_07()
        {
            // 7. Посчитать количество нечетных элементов массива
            Console.WriteLine();
            Console.WriteLine("Седьмое задание.");

            int[] arrayZ7 = new int[21];
            Random random7 = new Random();


            for (int i = 0; i < arrayZ7.Length; i++)
            {
                arrayZ7[i] = random7.Next(-100, 101);
            }
            for (int i = 0; i < arrayZ7.Length; i++)
            {
                Console.Write(arrayZ7[i] + " ");
            }

            int countIndexOdd = 0;

            for (int i = 0; i < arrayZ7.Length; i++)
            {
                if (i % 2 != 0)
                {
                    countIndexOdd++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Ответ на седьмое задание: " + countIndexOdd);
            Console.WriteLine();
        }


        public static void Exercise_08()
        {
            // 8. Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
            Console.WriteLine();
            Console.WriteLine("Восьмое задание.");

            int[] arrayZ8 = new int[21];
            Random random8 = new Random();

            for (int i = 0; i < arrayZ8.Length; i++)
            {
                arrayZ8[i] = random8.Next(-100, 101);
            }
            for (int i = 0; i < arrayZ8.Length; i++)
            {
                Console.Write(arrayZ8[i] + " ");
            }

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
            Console.WriteLine();
            Console.WriteLine("Ответ на восьмое задание:");
            for (int i = 0; i < arrayZ8.Length; i++)
            {
                Console.Write(arrayZ8[i] + " ");
            }
            Console.WriteLine();

        }


        public static void Exercise_09()
        {
            // 9. Отсортировать массив по возрастанию одним из способов:  пузырьком(Bubble), выбором (Select) или вставками (Insert)) 
            Console.WriteLine();
            Console.WriteLine("Девятое задание(Bubble).");

            int[] arrayZ9 = new int[21];
            Random random9 = new Random();

            for (int i = 0; i < arrayZ9.Length; i++)
            {
                arrayZ9[i] = random9.Next(-100, 101);
            }
            for (int i = 0; i < arrayZ9.Length; i++)
            {
                Console.Write(arrayZ9[i] + " ");
            }

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

            Console.WriteLine();
            Console.WriteLine("Ответ на девятое задание:");
            for (int i = 0; i < arrayZ9.Length; i++)
            {
                Console.Write(arrayZ9[i] + " ");
            }
            Console.WriteLine();
        }


        public static void Exercise_10()
        {
            // 10. Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании) :  пузырьком(Bubble), выбором (Select) или вставками (Insert))
            Console.WriteLine();
            Console.WriteLine("Десятое задание(Insert).");

            int[] arrayZ10 = new int[21];
            Random random10 = new Random();

            for (int i = 0; i < arrayZ10.Length; i++)
            {
                arrayZ10[i] = random10.Next(-100, 101);
            }
            for (int i = 0; i < arrayZ10.Length; i++)
            {
                Console.Write(arrayZ10[i] + " ");
            }

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
            Console.WriteLine();
            Console.WriteLine("Ответ на десятое задание:");
            for (int i = 0; i < arrayZ10.Length; i++)
            {
                Console.Write(arrayZ10[i] + " ");
            }
        }


    }
}
