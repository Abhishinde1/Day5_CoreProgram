using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic
{
    internal class UC9Vowel
    {
        public static void Findvowel()
        {
            char z;
            Console.WriteLine("Enter Alphabet");
            z = Convert.ToChar(Console.ReadLine());

            switch (z)
            {
                case 'a':
                    Console.WriteLine("Alphabet is vowel");
                    break;
                case 'A':
                    Console.WriteLine("Alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("Alphabet is vowel");
                    break;
                case 'E':
                    Console.WriteLine("Alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("Alphabet is vowel");
                    break;
                case 'I':
                    Console.WriteLine("Alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("Alphabet is vowel");
                    break;
                case 'O':
                    Console.WriteLine("Alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("Alphabet is vowel");
                    break;
                case 'U':
                    Console.WriteLine("Alphabet is vowel");
                    break;
                default:
                    Console.WriteLine("Alphabet is consonant");
                    break;
            }
        }
    }
}

