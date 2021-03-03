using System;
using System.Collections.Generic;
using System.Text;

namespace ALLDZ
{
    class Variables
    {

        public static void Exercise_01()
        {
            //1. Пользователь вводит 2 числа (A и B). Выведите в консоль решение (5*A+B*B)/(B-A)
            Console.WriteLine("Введите число A");
            double numberA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double numberB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число C");
            double numberC = Convert.ToDouble(Console.ReadLine());
            double otvet1 = (5 * numberA + numberB * numberB) / (numberB - numberA);
            Console.WriteLine("Ответ на первое задание: " + otvet1);                       
        }

        public static void Exercise_02()
        {
            //2. Пользователь вводит 2 значения(A и B). Поменяйте содержимое переменных A и B местами.
            Console.WriteLine("Введите число A");
            double numberA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double numberB = Convert.ToDouble(Console.ReadLine());
            
            double numberK = numberB;
            numberB = numberA;
            numberA = numberK;

            Console.WriteLine("Ответ на второе задание: A = " + numberA + ", число B = " + numberB);
        }


        public static void Exercise_03()
        {
            //3. Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления.
            Console.WriteLine("Введите число A");
            double numberA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double numberB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ на третье задание: результат деления A/B = " + numberA / numberB + ", остаток от деления = " + numberA % numberB);
        }


        public static void Exercise_04()
        {
            //4. Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.
            Console.WriteLine("Введите число A");
            double numberA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double numberB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число C");
            double numberC = Convert.ToDouble(Console.ReadLine());

            double numberX = (numberC - numberB) / numberA;
            Console.WriteLine("Ответ на четвертое задание: значение X для уравнения A*X+B=C равно " + numberX);
        }

        public static void Exercise_05()
        {
            //5. Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости. Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.
            Console.WriteLine("Введите значение X1");
            double numberX1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y1");
            double numberY1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение X2");
            double numberX2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y2");
            double numberY2 = Convert.ToDouble(Console.ReadLine());

            double numberA = (numberY2 - numberY1) / (numberX2 - numberX1);
            double numberB = numberY1 - numberA * numberX1;
            if (numberB < 0)
            {
                Console.WriteLine("Ответ на пятое задание: Y = " + numberA + "X + (" + numberB + ")");
            }
            else
            {
                Console.WriteLine("Ответ на пятое задание: Y = " + numberA + "X +" + numberB);
            }
        }        
    }
}
