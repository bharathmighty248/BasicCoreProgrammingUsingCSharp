using System;
using System.Collections.Generic;
using System.Text;

namespace PowerOfNTable
{
    class TwoPowerN
    {
        public void TwoPowerNTable()
        {
            Console.WriteLine("Give the Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= number)
            {
                Console.WriteLine("2" + " ^ " + i + " = " + Math.Pow(2, i));
                i++;
            }
        }
    }
}
