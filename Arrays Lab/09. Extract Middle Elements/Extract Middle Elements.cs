namespace _09.Extract_Middle_Elements
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
                .Select(int.Parse)
                .ToArray();
            var n = nums.Count();
            if (n==1)
            {
                Console.WriteLine("{ "+string.Join("",nums[0])+" }");
            }
            else if (n%2==0)
            {
                Console.WriteLine("{ "+string.Join(", ",nums[n/2-1],nums[n/2])+" }");
            }
            else 
            {
                Console.WriteLine("{ "+string.Join(", ", nums[n/ 2 - 1], nums[n/ 2],nums[n/2+1])+" }");
            }
        }
    }
}
