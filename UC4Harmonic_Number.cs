using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic
{
    internal class UC4Harmonic_Number
    {
        public static void Number()
        {
            int n = 5;
            double value = 0.0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                value += 1 / (float)i;
            }
            Console.WriteLine("Sum of Series upto {0} terms : {1} ", n, value);
        }
    }
}

