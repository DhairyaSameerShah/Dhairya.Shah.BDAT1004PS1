// Question 3 : Implement function triangleArea(a,b,c) that takes as input the lengths of the 3 sides of a triangle and
// returns the area of the triangle. By Heron's formula, the area of a triangle with side lengths a, b, and c is
// s(s - a)(s - b)(s - c), where s = (a + b + c) / 2.

using System;

namespace DP_ProblemSet_1
{
    class Area_of_Triangle
    {
        static double triangleArea(double s1, double s2, double s3)
        {
            double side = (s1 + s2 + s3) / 2;
            return (double)Math.Sqrt(side * (side - s1) * (side - s2) * (side - s3));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Area of Triangle using Heron's Formula  \n");
            Console.Write("Enter a number for side1: ");
            double s1 = double.Parse(Console.ReadLine());
            Console.Write("Enter a number for side2: ");
            double s2 = double.Parse(Console.ReadLine());
            Console.Write("Enter a number for side3: ");
            double s3 = double.Parse(Console.ReadLine());
            double area = triangleArea(s1, s2, s3);
            Console.WriteLine("Area of Triangle is {0}.", area);
        }
    }
}
