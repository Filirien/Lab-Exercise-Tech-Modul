namespace ArraysDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new string[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ",arr));

        }
    }
}

