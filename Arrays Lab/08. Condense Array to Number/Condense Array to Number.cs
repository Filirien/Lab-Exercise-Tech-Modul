﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace _08.Condense_Array_to_Number
{
    public class Program
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            while (nums.Length > 1)
            {
                var condensed = new int[nums.Length - 1];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }
                nums = condensed;

            }

            Console.WriteLine(nums[0]);
        }
    }
}
