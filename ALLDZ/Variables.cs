using System;
using System.Collections.Generic;
using System.Text;

namespace ALLDZ
{
    public class Variables
    {

        public static double Exercise_01(double numberA, double numberB)
        {
            //1. Пользователь вводит 2 числа (A и B). Выведите в консоль решение (5*A+B*B)/(B-A)
            if (numberA == numberB)
            {
                throw new Exception("B - A = 0, происходит деление на ноль.");
            }
            double otvet1 = (5 * numberA + numberB * numberB) / (numberB - numberA);

            return otvet1;
        }

        public static double[] Exercise_02(double numberA, double numberB)
        {
            //2. Пользователь вводит 2 значения(A и B). Поменяйте содержимое переменных A и B местами.
            double numberK = numberB;
            numberB = numberA;
            numberA = numberK;

            double[] arr = new double[2] {numberA, numberB};

            return arr;
        }


        public static double[] Exercise_03(double numberA, double numberB)
        {
            //3. Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления.
            if (numberB == 0)
            {
                throw new Exception("B = 0, происходит деление на ноль.");
            }
            double division = numberA / numberB;
            double remainder = numberA % numberB;
            double[] arr = new double[2] { division, remainder };
            return arr;
        }


        public static string Exercise_04(double numberA, double numberB, double numberC)
        {
            //4. Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.
            if (numberA == 0)
            {
                if (numberB == numberC)
                {
                    return "Бесконечно решений";
                }
                else
                {
                    return "Нет решений";
                }
                
            }
            else
            {
                double numberX = (numberC - numberB) / numberA;
                return numberX.ToString();
            }
            
            

        }

        public static string Exercise_05(double numberX1, double numberX2, double numberY1, double numberY2)
        {
            //5. Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости. Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.

            if (numberX1 == numberX2 || numberY1 == numberY2)
            {
                return "Влом";
            }
            else
            {
                double numberA = (numberY2 - numberY1) / (numberX2 - numberX1);
                double numberB = numberY1 - numberA * numberX1;
                if (numberB < 0)
                {
                    return "Y=" + numberA + "X+(" + numberB + ")";
                }
                else
                {
                    return "Y=" + numberA + "X+" + numberB;
                }
            }
            
        }
    }
}
