using System;
using System.Collections.Generic;
using System.Text;

namespace ALLDZ
{
    class ConsoleInputOfIntNumbers
    {
        public static int InputOfIntNumbers(string number)
        {
            Console.WriteLine("Введите число A");
            int numberA = Convert.ToInt32(Console.ReadLine());
            return numberA;
        }

    }
}
