using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int digits = 0;
            bool special = false;
            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                digits = num;
                while (num > 0)
                {
                    sumOfDigits += num % 10;
                    num = num / 10;
                }
                special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{digits} -> {special}");
                sumOfDigits = 0;
                num = digits;
            }

        }
    }
}
