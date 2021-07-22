using System;
using System.Collections.Generic;
using System.Text;

namespace EvenOrOdd
{
    class EvenorOdd
    {
        public void EvenOrOdd()
        {
            Console.WriteLine("Give The Number To Check");
            int number = Convert.ToInt32(Console.ReadLine());
            if ((number % 2) == 0)
                Console.WriteLine(number + " is an Even Number");
            else
                Console.WriteLine(number + " is an Odd Number");
        }
    }
}
