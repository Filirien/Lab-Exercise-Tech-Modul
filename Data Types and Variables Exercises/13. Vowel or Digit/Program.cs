﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());
            if (n == 'a' || n == 'e' || n == 'i' || n == 'o' || n == 'u' || n == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if (n > 47 && n < 58)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }

        }
    }
}

