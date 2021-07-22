using System;
using System.Collections.Generic;
using System.Text;

namespace HarmonicNum
{
    class HarmonicNum
    {
        public void HarmonicOf()
        {
            Console.WriteLine("Give the Number");
            double number = Convert.ToDouble(Console.ReadLine());
            double harmonicNumber = 0;
            double i = 1;
            while (i <= number)
            {
                double harmonic = 1 / i;
                harmonicNumber += harmonic;
                i++;
            }
            Console.WriteLine("Harmonic Value of Number " + number + " is " + harmonicNumber);
        }
    }
}
