using System;

namespace QuotientAndRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            QuotientAndRemainder quotient = new QuotientAndRemainder(100, 6);
            quotient.Quotient();
            QuotientAndRemainder remainder = new QuotientAndRemainder(100, 6);
            remainder.Remainder();
        }
    }
}
