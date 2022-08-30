using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic
{
    internal class UC2LeapYear
    {
        public static void FindleapYear()
        {
            int minNumber = 1000, maxNumber = 9999;
            Console.WriteLine("Enter Year");
            int year = int.Parse(Console.ReadLine());

            if (year >= 100 && year <= 1000)
            {
                Console.WriteLine("Valid year entered");
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    Console.WriteLine("{0}is leap year", year);
                }
                else
                {
                    Console.WriteLine("{0} is not Leap Year", year);
                }

            }
        }

    }
}
