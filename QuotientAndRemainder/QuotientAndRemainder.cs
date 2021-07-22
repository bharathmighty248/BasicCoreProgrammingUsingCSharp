using System;
using System.Collections.Generic;
using System.Text;

namespace QuotientAndRemainder
{
    class QuotientAndRemainder
    {
        int divident, divisor;
        public QuotientAndRemainder(int divident, int divisor)
        {
            this.divident = divident;
            this.divisor = divisor;
        }
        public void Quotient()
        {
            int quotient = divident / divisor;
            Console.WriteLine("Quotient is " + quotient);
        }
        public void Remainder()
        {
            int remainder = divident % divisor;
            Console.WriteLine("Remainder is " + remainder);
        }
    }
}
