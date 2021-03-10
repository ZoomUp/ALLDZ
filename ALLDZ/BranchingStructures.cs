using System;
using System.Collections.Generic;
using System.Text;

namespace ALLDZ
{
    public class BranchingStructures
    {
        public static int Exercise_01(int numberA, int numberB)
        {
            // 1. Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.

            if (numberA > numberB)
            {
                return (numberA + numberB);
            }
            else if (numberA == numberB)
            {
                return (numberA * numberB);
            }
            else
            {
                return (numberA - numberB);
            }
        }

        public static int Exercise_02(int numberX, int numberY)
        {
            // 2. Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).

            if (numberX > 0)
            {
                if (numberY > 0)
                {
                    return 1;
                }
                else if (numberY < 0)
                {
                    return 4;
                }
                else
                {
                    // Если 0 - то значит, что лежит на оси.
                    return 0;
                }

            }
            else if (numberX < 0)
            {
                if (numberY > 0)
                {
                    return 2;
                }
                else if (numberY < 0)
                {
                    return 3;
                }
                else
                {
                    // Если 0 - то значит, что лежит на оси.
                    return 0;
                }
            }
            else
            {
                if (numberY == 0)
                {
                    // Если 0 - то значит, что лежит на оси.
                    return 0;
                }
                else
                {
                    // Если 0 - то значит, что лежит на оси.
                    return 0;
                }
            }
        }

        public static int[] Exercise_03(int numberA, int numberB, int numberC)
        {
            // 3. Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.
            int[] arr;
            if (numberA > numberB)
            {
                if (numberA > numberC)
                {
                    if (numberB > numberC)
                    {
                        arr = new int[3] { numberC, numberB, numberA };
                        return arr;
                    }
                    else
                    {
                        arr = new int[3] { numberB, numberC, numberA };
                        return arr;
                    }
                }
                else
                {
                    arr = new int[3] { numberB, numberA, numberC };
                    return arr;
                }
            }
            else
            {
                if (numberB > numberC)
                {
                    if (numberA > numberC)
                    {
                        arr = new int[3] { numberC, numberA, numberB };
                        return arr;                        
                    }
                    else
                    {   arr = new int[3] { numberA, numberC, numberB };
                        return arr;
                    }
                }
                else
                {   arr = new int[3] { numberA, numberB, numberC };
                    return arr;
                }
            }
        }

        public static string Exercise_04(double numberA4, double numberB4, double numberC4)
        {
            // 4. Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где A*X*X+B*X+C=0.

            double numberX1;
            double numberX2;
            // exception на нули
            if (numberA4 == 0)
            {
                throw new Exception("A = 0, это уже не квадратное уравнение");
            }

            double numberDiskriminant = numberB4 * numberB4 - 4 * numberA4 * numberC4;
            
            if (numberDiskriminant > 0)
            {
                numberX1 = (-numberB4 + Math.Sqrt(numberDiskriminant)) / (2 * numberA4);
                numberX2 = (-numberB4 - Math.Sqrt(numberDiskriminant)) / (2 * numberA4);
                return "X1=" + numberX1 + ", X2=" + numberX2;
            }
            else if (numberDiskriminant == 0)
            {
                numberX1 = -numberB4 / (2 * numberA4);
                return "X=" + numberX1;
            }
            else
            {
                return "корней нет";
            }
        }

        public static string Exercise_05(int numberDvuhznachnoe)
        {
            // 5. Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.


            if (numberDvuhznachnoe < 10 || numberDvuhznachnoe > 99)
            {
                throw new Exception("Ошибка, нужно было ввести двузначное число");
            }

            int numberOstatok = numberDvuhznachnoe % 10;
            int numberDesyatok = numberDvuhznachnoe / 10;

            string tmp;

            string propis1 = " один";
            string propis2 = " два";
            string propis3 = " три";
            string propis4 = " четыре";
            string propis5 = " пять";
            string propis6 = " шесть";
            string propis7 = " семь";
            string propis8 = " восемь";
            string propis9 = " девять";
            string propis20 = "Двадцать";
            string propis30 = "Тридцать";
            string propis40 = "Сорок";
            string propis50 = "Пятьдесят";
            string propis60 = "Шестьдесят";
            string propis70 = "Семьдесят";
            string propis80 = "Восемьдесят";
            string propis90 = "Девяносто";


            if (numberDesyatok == 1)
            {
                if (numberOstatok == 0)
                {
                     tmp = "Десять";
                }
                else if (numberOstatok == 1)
                {
                     tmp = "Одиннадцать";
                }
                else if (numberOstatok == 2)
                {
                     tmp = "Двенадцать";
                }
                else if (numberOstatok == 3)
                {
                     tmp = "Тринадцать";
                }
                else if (numberOstatok == 4)
                {
                     tmp = "Четырнадцать";
                }
                else if (numberOstatok == 5)
                {
                     tmp = "Пятнадцать";
                }
                else if (numberOstatok == 6)
                {
                     tmp = "Шестнадцать";
                }
                else if (numberOstatok == 7)
                {
                     tmp = "Семнадцать";
                }
                else if (numberOstatok == 8)
                {
                     tmp = "Восемнадцать";
                }
                else
                {
                     tmp = "Девятнадцать";
                }
                return tmp;
            }
            else
            {
                if (numberDesyatok == 2)
                {
                    tmp = propis20;
                }
                else if (numberDesyatok == 3)
                {
                    tmp = propis30;
                }
                else if (numberDesyatok == 4)
                {
                    tmp = propis40;
                }
                else if (numberDesyatok == 5)
                {
                    tmp = propis50;
                }
                else if (numberDesyatok == 6)
                {
                    tmp = propis60;
                }
                else if (numberDesyatok == 7)
                {
                    tmp = propis70;
                }
                else if (numberDesyatok == 8)
                {
                    tmp = propis80;
                }
                else
                {
                    tmp = propis90;
                }

                if (numberOstatok == 0)
                {
                    return tmp;
                }
                else if (numberOstatok == 1)
                {
                     tmp += propis1;
                }
                else if (numberOstatok == 2)
                {
                     tmp += propis2;
                }
                else if (numberOstatok == 3)
                {
                     tmp += propis3;
                }
                else if (numberOstatok == 4)
                {
                     tmp += propis4;
                }
                else if (numberOstatok == 5)
                {
                     tmp += propis5;
                }
                else if (numberOstatok == 6)
                {
                     tmp += propis6;
                }
                else if (numberOstatok == 7)
                {
                     tmp += propis7;
                }
                else if (numberOstatok == 8)
                {
                     tmp += propis8;
                }
                else if (numberOstatok == 9)
                {
                     tmp += propis9;
                }
                return tmp;
            }            
        }
    }
}
