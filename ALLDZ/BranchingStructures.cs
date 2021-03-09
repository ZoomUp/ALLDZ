using System;
using System.Collections.Generic;
using System.Text;

namespace ALLDZ
{
    class BranchingStructures
    {
        public static void Exercise_01()
        {
            // 1. Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
            Console.WriteLine("Задание №1");
            Console.WriteLine("Введите число A");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int numberB = Convert.ToInt32(Console.ReadLine());
            if (numberA > numberB)
            {
                Console.WriteLine("Ответ на первое задание: " + (numberA + numberB));
            }
            else if (numberA == numberB)
            {
                Console.WriteLine("Ответ на первое задание: " + (numberA * numberB));
            }
            else
            {
                Console.WriteLine("Ответ на первое задание: " + (numberA - numberB));
            }
        }

        public static void Exercise_02()
        {
            // 2. Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).
            Console.WriteLine("Задание №2");
            Console.WriteLine("Введите число X");
            int numberX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число Y");
            int numberY = Convert.ToInt32(Console.ReadLine());

            if (numberX > 0)
            {
                if (numberY > 0)
                {
                    Console.WriteLine("Ответ на второе задание: точка с координатами (" + numberX + "," + numberY + ") находится в первой четверти");
                }
                else if (numberY < 0)
                {
                    Console.WriteLine("Ответ на второе задание: точка с координатами (" + numberX + "," + numberY + ") находится в четвертой четверти");
                }
                else
                {
                    Console.WriteLine("Ответ на второе задание: точка с координатами (" + numberX + "," + numberY + ") находится на оси X");
                }

            }
            else if (numberX < 0)
            {
                if (numberY > 0)
                {
                    Console.WriteLine("Ответ на второе задание: точка с координатами (" + numberX + "," + numberY + ") находится во второй четверти");
                }
                else if (numberY < 0)
                {
                    Console.WriteLine("Ответ на второе задание: точка с координатами (" + numberX + "," + numberY + ") находится в третьей четверти");
                }
                else
                {
                    Console.WriteLine("Ответ на второе задание: точка с координатами (" + numberX + "," + numberY + ") находится на оси X");
                }
            }
            else
            {
                if (numberY == 0)
                {
                    Console.WriteLine("Ответ на второе задание: точка с координатами (" + numberX + "," + numberY + ") является началом координат");
                }
                else
                {
                    Console.WriteLine("Ответ на второе задание: точка с координатами (" + numberX + "," + numberY + ") находится на оси Y");
                }
            }
        }

        public static void Exercise_03()
        {
            // 3. Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.
            Console.WriteLine("Задание №3");
            Console.WriteLine("Введите число A");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int numberB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C");
            int numberC = Convert.ToInt32(Console.ReadLine());

            if (numberA > numberB)
            {
                if (numberA > numberC)
                {
                    if (numberB > numberC)
                    {
                        Console.WriteLine("Ответ на третье задание: " + numberA + " " + numberB + " " + numberC);
                    }
                    else
                    {
                        Console.WriteLine("Ответ на третье задание: " + numberA + " " + numberC + " " + numberB);
                    }
                }
                else
                {
                    Console.WriteLine("Ответ на третье задание: " + numberC + " " + numberA + " " + numberB);
                }
            }
            else
            {
                if (numberB > numberC)
                {
                    if (numberA > numberC)
                    {
                        Console.WriteLine("Ответ на третье задание: " + numberB + " " + numberA + " " + numberC);
                    }
                    else
                    {
                        Console.WriteLine("Ответ на третье задание: " + numberB + " " + numberC + " " + numberA);
                    }
                }
                else
                {
                    Console.WriteLine("Ответ на третье задание: " + numberC + " " + numberB + " " + numberA);
                }
            }
        }

        public static void Exercise_04()
        {
            // 4. Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где A*X*X+B*X+C=0.
            Console.WriteLine("Задание №4");
            Console.WriteLine("Введите число A");
            double numberA4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double numberB4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число C");
            double numberC4 = Convert.ToDouble(Console.ReadLine());

            double numberX1;
            double numberX2;
            // exception на нули

            double numberDiskriminant = numberB4 * numberB4 - 4 * numberA4 * numberC4;
            Console.WriteLine(numberDiskriminant);
            if (numberDiskriminant > 0)
            {
                numberX1 = (-numberB4 + Math.Sqrt(numberDiskriminant)) / (2 * numberA4);
                numberX2 = (-numberB4 - Math.Sqrt(numberDiskriminant)) / (2 * numberA4);
                Console.WriteLine("Ответ на четвертое задание: X1 = " + numberX1 + ", X2 = " + numberX2);
            }
            else if (numberDiskriminant == 0)
            {
                numberX1 = -numberB4 / (2 * numberA4);
                Console.WriteLine("Ответ на четвертое задание: X = " + numberX1);
            }
            else
            {
                Console.WriteLine("Ответ на четвертое задание: корней нет.");
            }
        }

        public static void Exercise_05()
        {
            // 5. Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.
            Console.WriteLine("Задание №5");
            Console.WriteLine("Введите двухзначное число");
            int numberDvuhznachnoe = Convert.ToInt32(Console.ReadLine());

            int numberOstatok = numberDvuhznachnoe % 10;
            int numberDesyatok = numberDvuhznachnoe / 10;

            String propis1 = " один";
            String propis2 = " два";
            String propis3 = " три";
            String propis4 = " четыре";
            String propis5 = " пять";
            String propis6 = " шесть";
            String propis7 = " семь";
            String propis8 = " восемь";
            String propis9 = " девять";
            String propis20 = "Двадцать";
            String propis30 = "Тридцать";
            String propis40 = "Сорок";
            String propis50 = "Пятьдесят";
            String propis60 = "Шестьдесят";
            String propis70 = "Семьдесят";
            String propis80 = "Восемьдесят";
            String propis90 = "Девяносто";


            if (numberDesyatok == 1)
            {
                if (numberOstatok == 0)
                {
                    Console.WriteLine("Десять");
                }
                if (numberOstatok == 1)
                {
                    Console.WriteLine("Одиннадцать");
                }
                if (numberOstatok == 2)
                {
                    Console.WriteLine("Двенадцать");
                }
                if (numberOstatok == 3)
                {
                    Console.WriteLine("Тринадцать");
                }
                if (numberOstatok == 4)
                {
                    Console.WriteLine("Четырнадцать");
                }
                if (numberOstatok == 5)
                {
                    Console.WriteLine("Пятнадцать");
                }
                if (numberOstatok == 6)
                {
                    Console.WriteLine("Шестнадцать");
                }
                if (numberOstatok == 7)
                {
                    Console.WriteLine("Семнадцать");
                }
                if (numberOstatok == 8)
                {
                    Console.WriteLine("Восемнадцать");
                }
                if (numberOstatok == 9)
                {
                    Console.WriteLine("Девятнадцать");
                }
            }
            else
            {
                if (numberDesyatok == 2)
                {
                    Console.Write(propis20);
                }
                else if (numberDesyatok == 3)
                {
                    Console.Write(propis30);
                }
                else if (numberDesyatok == 4)
                {
                    Console.Write(propis40);
                }
                else if (numberDesyatok == 5)
                {
                    Console.Write(propis50);
                }
                else if (numberDesyatok == 6)
                {
                    Console.Write(propis60);
                }
                else if (numberDesyatok == 7)
                {
                    Console.Write(propis70);
                }
                else if (numberDesyatok == 8)
                {
                    Console.Write(propis80);
                }
                else
                {
                    Console.Write(propis90);
                }

                if (numberOstatok == 1)
                {
                    Console.WriteLine(propis1);
                }
                else if (numberOstatok == 2)
                {
                    Console.WriteLine(propis2);
                }
                else if (numberOstatok == 3)
                {
                    Console.WriteLine(propis3);
                }
                else if (numberOstatok == 4)
                {
                    Console.WriteLine(propis4);
                }
                else if (numberOstatok == 5)
                {
                    Console.WriteLine(propis5);
                }
                else if (numberOstatok == 6)
                {
                    Console.WriteLine(propis6);
                }
                else if (numberOstatok == 7)
                {
                    Console.WriteLine(propis7);
                }
                else if (numberOstatok == 8)
                {
                    Console.WriteLine(propis8);
                }
                else if (numberOstatok == 9)
                {
                    Console.WriteLine(propis9);
                }

            }
        }
    }
}
