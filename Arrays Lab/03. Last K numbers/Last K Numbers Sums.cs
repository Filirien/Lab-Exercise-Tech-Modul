namespace s
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("0");
                return;
            }
            var seq = new int[n];
            seq[0] = 1;
            for (int i = 1; i < seq.Length; i++)
            {
                var sum = 0;
                for (int j = 1; j <= k; j++)
                {
                    if (i - j >= 0)
                    {
                        sum += seq[i-j];
                    }
                }
                seq[i] = sum;
            }
            Console.WriteLine(string.Join(" ", seq));

        }
    }
}
