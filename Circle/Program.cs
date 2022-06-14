using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            //declaring variables
            double diameter = radius * 2;
            double pi = Math.PI;
            double area = pi * (radius * radius);

            double perimeter = pi * diameter;

            Console.WriteLine("The perimeter of circle is: " + perimeter);
            Console.WriteLine("The area of circle is: " + area);

            Console.ReadKey();

        }
    }
}