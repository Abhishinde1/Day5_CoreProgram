using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic
{
    internal class UC3Power_Of_Two
    {
        static public void Powertwo()
        {
            Console.WriteLine("Enter number upto which we want power of two:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 0 && n < 31)
            {
                double pow = Math.Pow(2, n);
                Console.WriteLine("2 power {0} is {1}", n, pow);
            }
            else
            {
                Console.WriteLine("Entered number not valid");
            }
        }
    }
}

