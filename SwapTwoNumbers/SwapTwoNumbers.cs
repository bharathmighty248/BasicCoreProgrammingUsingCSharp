using System;
using System.Collections.Generic;
using System.Text;

namespace SwapTwoNumbers
{
    class SwapTwoNumbers
    {
        int num1, num2;
        public SwapTwoNumbers(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public void Swap()
        {
            Console.WriteLine("Before swaping number1 : " + num1 + " number2: " + num2);
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("After swaping number1 : " + num1 + " number2: " + num2);
        }
    }
}
