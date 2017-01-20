using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            bool equal = false;
             if (a == (b + 0.000001) || a == b || a == (b - 0.000001))
            {
                equal = true;
                Console.WriteLine(equal);
            }
        
            else
	        {
                Console.WriteLine(equal);
            }
        }
    }
}

