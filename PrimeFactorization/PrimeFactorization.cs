using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeFactorization
{
    class PrimeFactorization
    {
        public void PrimeFactors()
        {
            Console.WriteLine("Give The Number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime Factors of " + number + " are: ");
            for (int i=2; i<=number; i++)   //For Finding Factores
            {
                if ((number % i) == 0)
                {
                    int count = 0;
                    for(int j=1; j<=i; j++)  //For Finding Only Prime Factores From Above Factores
                    {
                        int factor = i % j;
                        if (factor == 0)
                            count++;
                    }
                    if (count == 2)
                        Console.WriteLine(i);
                }
            }
        }
    }
}
