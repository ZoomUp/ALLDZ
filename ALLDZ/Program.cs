using System;

namespace ALLDZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            double numberA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double numberB = Convert.ToDouble(Console.ReadLine());

            Variables.Exercise_01(numberA, numberB);


        }
    }
}