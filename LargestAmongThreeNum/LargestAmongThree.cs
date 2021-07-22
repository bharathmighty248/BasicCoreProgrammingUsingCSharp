using System;
using System.Collections.Generic;
using System.Text;

namespace LargestAmongThreeNum
{
    class LargestAmongThree
    {
        int num1, num2, num3;
        public LargestAmongThree(int num1, int num2, int num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }
        public void LargestAmongThreeNumbers()
        {
            if ((num1 > num2) && (num1 > num3))
                Console.WriteLine(num1 + " is Largest Among Three Numbers");
            else if ((num2 > num1) && (num2 > num3))
                Console.WriteLine(num2 + " is Largest Among Three Numbers");
            else if ((num3 > num1) && (num3 > num2))
                Console.WriteLine(num3 + " is Largest Among Three Numbers");
        }
    }
}
