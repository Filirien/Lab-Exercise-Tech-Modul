namespace s
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {

        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var numbersAwayFromZero = new int [nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                numbersAwayFromZero[i] = (int)Math.Round(nums[i],MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]} -> {numbersAwayFromZero[i]}");
            }
        }
    }
}
