using System;
using System.Collections.Generic;
using System.Text;

namespace ALLDZ
{
    public class Cycles
    {

        public static double Exercise_01(double numberA, double numberB)
        {
            // 1. Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
            double tmp = numberA;

            if (numberB > 0)
            {
                for (int i = 1; i < numberB; i++)
                {
                    numberA *= tmp;
                }
                return numberA;

            }
            else if (numberB < 0)
            {
                for (int i = -1; i > numberB; i--)
                {
                    numberA *= tmp;
                }
                return 1 / numberA;
            }
            else
            {
                return 1;
            }
        }

        public static string Exercise_02(int numberA)
        {
            // 2. Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
            string tmp = "";
            for (int i = 1; i < 1000 + 1; i++)
            {
                if (i % numberA == 0)
                {
                    tmp += i + " ";
                }
            }
            return tmp;
        }

        public static int Exercise_03(int numberA)
        {
            // 3. Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
            int tmp = 0;

            for (int i = 1; i < numberA; i++)
            {
                if (i * i < numberA)
                {
                    tmp++;
                }
            }
            return tmp;
        }

        public static int Exercise_04(int numberA)
        {
            // 4. Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
            int tmp = 0;
            for (int i = numberA - 1; i > 0; i--)
            {
                if (numberA % i == 0)
                {
                    tmp = i;
                    break;
                }
            }
            return tmp;
        }


        public static int Exercise_05(int numberA, int numberB)
        {
            // 5. Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).

            int tmp = 0;
            if (numberA > numberB)
            {
                for (int i = numberA; i >= numberB; i--)
                {
                    if (i % 7 == 0)
                    {
                        tmp += i;
                    }
                }

            }
            else
            {
                for (int i = numberB; i >= numberA; i--)
                {
                    if (i % 7 == 0)
                    {
                        tmp += i;
                    }
                }
            }
            return tmp;
        }


        public static int Exercise_06(int numberN)
        {
            // 6. Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи. В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.
            int tmp1 = 1;
            int tmp2 = 1;
            int numberFibonacci = 1;

            for (int i = 2; i < numberN; i++)
            {
                numberFibonacci = tmp1 + tmp2;
                tmp1 = tmp2;
                tmp2 = numberFibonacci;
            }

            return numberFibonacci;
        }


        public static int Exercise_07(int numberA, int numberB)
        {
            // 7. Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.

            int numberGCF = 0;
            if (numberA == numberB)
            {
                for (int i = numberA - 1; i > 0; i--)
                {
                    if (numberA % i == 0)
                    {
                        numberGCF = i;
                        break;
                    }
                }
            }
            else
            {
                while (numberGCF == 0)
                {
                    if (numberA != numberB)
                    {
                        if (numberA > numberB)
                        {
                            numberA -= numberB;
                        }
                        else
                        {
                            numberB -= numberA;
                        }
                    }
                    else
                    {
                        numberGCF = numberA;
                    }
                }
            }

            return numberGCF;
        }


        public static int Exercise_08(int numberA)
        {
            // 8. Пользователь вводит целое положительное число, которое является кубом целого числа N. Найдите число N методом половинного деления.
            int numberN = 1;
            int tmp = numberA;
            int tmp2 = 0;

            while (numberA != numberN * numberN * numberN)
            {
                if (tmp > numberA / tmp / tmp)
                {
                    tmp2 = tmp;
                    tmp /= 2;

                }
                else if (tmp < numberA / tmp / tmp)
                {
                    tmp = tmp2 + tmp;
                }
                else
                {
                    numberN = tmp;
                    break;
                }
            }
            return numberN;
        }


        public static int Exercise_09(int numberA)
        {
            // 9. Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
            int numberOdd = 0;
            int tmp;

            while (numberA / 10 > 0 || numberA % 10 > 0)
            {
                tmp = numberA % 10;
                numberA /= 10;
                if (tmp % 2 != 0)
                {
                    numberOdd++;
                }
            }
            return numberOdd;
        }


        public static int Exercise_10(int numberA)
        {
            // 10. Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321.
            int tmp = 0;
            int tmp2 = 1;
            if (numberA < 0)
            {
                tmp2 = -1;
            }
            numberA = Math.Abs(numberA);
            while (numberA / 10 > 0 || numberA % 10 > 0)
            {
                tmp = numberA % 10 + tmp;
                numberA /= 10;
                if (numberA / 10 > 0 || numberA % 10 > 0)
                {
                    tmp *= 10;
                }
            }

            return tmp * tmp2;
        }


        public static string Exercise_11(int numberN)
        {
            // 11. Пользователь вводит целое положительное число (N). Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных. 
            int numberSumOdd;
            int numberSumEven;
            int tmp;
            string tmpString = "";

            for (int i = 1; i < numberN + 1; i++)
            {
                int j = i;
                numberSumOdd = 0;
                numberSumEven = 0;
                while (j / 10 > 0 || j % 10 > 0)
                {
                    tmp = j % 10;
                    j /= 10;
                    if (tmp % 2 != 0)
                    {
                        numberSumOdd += tmp;
                    }
                    else
                    {
                        numberSumEven += tmp;
                    }


                }
                if (numberSumEven > numberSumOdd)
                {
                    tmpString += i + " ";
                }
            }
            return tmpString;
        }


        public static string Exercise_12(int numberA, int numberB)
        {
            // 12. Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
            int numberCounter = 0;
            int tmp;
            int tmp2;
            int tmp3;
            if (numberA > numberB)
            {
                tmp = numberA;
                numberA = numberB;
                numberB = tmp;
            }


            while (numberA != 0)
            {
                tmp2 = numberB;
                tmp = numberA % 10;
                numberA /= 10;
                while (tmp != tmp2 && tmp2 != 0)
                {
                    tmp3 = tmp2 % 10;
                    if (tmp == tmp3)
                    {
                        numberCounter++;
                        break;
                    }
                    tmp2 /= 10;
                }
                if (tmp == tmp2)
                {
                    numberCounter++;
                    break;
                }

            }
            if (numberCounter > 0)
            {
                return "Да";
            }
            else
            {
                return "Нет";
            }
        }
    }
}
