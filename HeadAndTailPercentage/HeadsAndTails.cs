using System;
using System.Collections.Generic;
using System.Text;

namespace HeadAndTailPercentage
{
    class HeadsAndTails
    {
        public void Percentage()
        {
            double heads = 0;
            double tails = 0;
            double headsPercentage = 0;
            double tailsPercentage = 0;
            double total = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int i = 1;
            while (i <= total)
            {
                i++;
                double result = random.NextDouble();
                if (result < 0.5)
                    tails++;
                else
                    heads++;
            }
            Console.WriteLine("Heads: " + heads);
            Console.WriteLine("Tails: " + tails);
            headsPercentage = (heads / total) * 100;
            tailsPercentage = (tails / total) * 100;
            Console.WriteLine("Heads Percentage: " + headsPercentage);
            Console.WriteLine("Tails Percentage: " + tailsPercentage);
        }
    }
}
