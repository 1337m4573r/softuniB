//Write a program that reads the coefficients a, b and c of a quadratic
//equation ax2 + bx + c = 0 and solves it (prints its real roots). Examples:
//a     b	c	roots
//2	    5	-3	x1=-3; x2=0.5
//-1	3	0	x1=3; x2=0
//-0.5	4	-8	x1=x2=4
//5	    2	8	no real roots

using System;
using System.Threading;
using System.Globalization;

class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("ax2 + bx + c = 0\na = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10}", "a", "b", "c", "roots");
        string roots = "";
        double determine;

        if (a == 0D)
        {
            if (b == 0D)
            {
                if (c == 0D)
                {
                    roots = "no real roots"; //no valid actualy
                }
                else
                {
                    roots = "no real roots";
                }
            }
            else
            {
                roots = "x1=x2=" + (-c / b).ToString();
            }
        }
        else
        {
            determine = (b * b) - (4 * a * c);
            if (determine < 0D)
            {
                roots = "no real roots";
            }
            else if (determine == 0D)
            {
                roots = "x1=x2=" + (-b / (2 * a)).ToString();
            }
            else
            {
                roots = "x1=" + ((-b - Math.Sqrt(determine))/(2*a)).ToString();
                roots += "; x2=" + ((-b + Math.Sqrt(determine)) / (2 * a)).ToString();
            }
        }
        Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10}", a, b, c, roots);
    }
}

