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
                .Select(int.Parse)
                .ToArray();
            var firstNum = 0;
            var secondNum = 0;

            var checker = true;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = i+1; k < nums.Length; k++)
                {
                        firstNum = nums[i];
                        secondNum = nums[k];
                        var sum = firstNum + secondNum;
                        if (nums.Contains(sum))
                        {
                            Console.WriteLine($"{firstNum} + {secondNum} == {sum}");
                            checker = false;
                        }
                }
            }
            if (checker)
            {
                Console.WriteLine("No");
            }
        }
    }
}