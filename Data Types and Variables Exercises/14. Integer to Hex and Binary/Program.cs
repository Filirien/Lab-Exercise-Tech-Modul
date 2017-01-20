using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decValue = int.Parse(Console.ReadLine());
            string hexValue = decValue.ToString("X");
            string binary = Convert.ToString(decValue, 2);
            Console.WriteLine(hexValue);
            Console.WriteLine(binary);
        }
    }
}
