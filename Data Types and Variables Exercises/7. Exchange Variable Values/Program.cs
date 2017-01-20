using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:");
            Console.WriteLine($"a = { firstNum}");
            Console.WriteLine($"b = { secondNum}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = { secondNum}");
            Console.WriteLine($"b = { firstNum}");


        }
    }
}
