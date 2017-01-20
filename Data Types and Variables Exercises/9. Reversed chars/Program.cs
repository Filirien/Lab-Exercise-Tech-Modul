﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days =(int)(years * 365.2422);
            decimal hours = days * 24;
            decimal minutes = hours * 60M;
            decimal seconds = minutes * 60M;
            decimal milliseconds = seconds *1000M;
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
