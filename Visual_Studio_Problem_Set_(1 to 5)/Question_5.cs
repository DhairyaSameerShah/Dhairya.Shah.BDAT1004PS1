// Question 5 (a): Write a function inside(x,y,x1,y1,x2,y2) that returns True or False depending on whether the point (x,y)
// lies in the rectangle with lower left corner (x1,y1) and upper right corner (x2,y2).

// Question 5 (b) : Use function inside() from part a. to write an expression that tests whether the point (1,1) lies in
// both of the following rectangles: one with lower left corner (0.3, 0.5) and upper right corner (1.1, 0.7) and the other
// with lower left corner (0.5, 0.2) and upper right corner (1.1, 2).


using System;

namespace DP_ProblemSet_1
{
    class Question_5
    {
        static bool inside(double x, double y, double x1, double y1, double x2, double y2)
        {
            if (x > x1 && x < x2 && y > y1 && y < y2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("<----------------------------------------- Answer 5.a -------------------------------------->");
            bool rectanlge1 = inside(1, 1, 0, 0, 2, 3);
            Console.WriteLine("Does the points (1, 1) lies within the rectange ? {0} \n", rectanlge1);
            bool rectanlge2 = inside(-1, -1, 0, 0, 2, 3);
            Console.WriteLine("Does the points (-1, -1) lies within the rectange ? {0} \n \n", rectanlge2);

            Console.WriteLine("<----------------------------------------- Answer 5.b -------------------------------------->");
            bool rectangle3 = inside(1, 1, 0.3, 0.5, 1.1, 0.7);
            bool rectangle4 = inside(1, 1, 0.5, 0.2, 1.1, 2);
            if (rectangle3 == true && rectangle4 == true)
            {
                Console.WriteLine("Points (1, 1) lies in both the rectangles. \n");
            }
            else
            {
                Console.WriteLine("Points (1, 1) does not lies in either of rectangle. \n");
            }
        }
    }
}
