namespace s
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {

        public static void Main()
        {
            var reveredString = Console.ReadLine()
                .Split(' ')
                .ToArray();
            Array.Reverse(reveredString);
            Console.WriteLine(string.Join(" ",reveredString));
        }
    }
}
