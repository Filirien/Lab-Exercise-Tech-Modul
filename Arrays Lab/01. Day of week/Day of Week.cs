namespace ArraysDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            if (n > 0 && n <= 7)
            {
                var days = new string[]{ "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
                Console.WriteLine(days[n-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}

