using System;
using System.Collections.Generic;
using System.Linq;
namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main()
        {
            var firstNums = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToArray();
            var secondNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var len1 = firstNums.Length;
            var len2 = secondNums.Length;
            var maxLen = Math.Max(len1, len2);
            var result = new int[maxLen];

            for (int i = 0; i < maxLen; i++)
            {
                result[i] = firstNums[i % len1] + secondNums[i % len2];
            }
            Console.WriteLine(string.Join(" ", result));

        }

    }
}
