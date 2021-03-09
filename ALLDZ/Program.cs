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
            Console.WriteLine("Введите число A");
            double numberC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double numberD = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine(Variables.Exercise_05(numberA, numberB, numberC, numberD));

        }
    }
}