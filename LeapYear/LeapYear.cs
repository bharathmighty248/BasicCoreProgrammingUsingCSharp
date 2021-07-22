using System;
using System.Collections.Generic;
using System.Text;

namespace LeapYear
{
    class LeapYear
    {
        public void LeapYearCheck()
        {
            Console.WriteLine("Give the Year");
            int year = Convert.ToInt32(Console.ReadLine());
            string result;

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                result = "True";
            else
                result = "False";

            switch (result)
            {
                case "True":
                    Console.WriteLine(year + ": is a Leap Year");
                    break;
                case "False":
                    Console.WriteLine(year + ": is Not a LeapYear");
                    break;
            }
        }
    }
}
