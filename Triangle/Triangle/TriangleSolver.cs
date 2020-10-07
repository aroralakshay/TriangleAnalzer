using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    public static class TriangleSolver
    {
        public static string Analyze(int a, int b, int c)
        {
           
            if (a >= 1 && b >= 1 && c >= 1)
            {
                    if (a == b && a == c)
                    {
                        return "Equilateral triangle";
                    }
                    else if (a == b || a == c || b == c)
                    {
                        return "Isosceles triangle";
                    }
                    else
                    {
                        return "Scalene triangle";
                    }
                }
                else
                {
                    return "All the sides of triangle must be entered as 1 or greater";
                }
        } 
    }
}
