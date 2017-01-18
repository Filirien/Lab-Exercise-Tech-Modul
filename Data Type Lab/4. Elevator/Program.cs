using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double persons = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());
            double courses = Math.Ceiling(persons / capacity);
            Console.WriteLine(courses);
        }
    }
}
