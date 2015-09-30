//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements. Don’t use arrays and the built-in sorting functionality.
//Examples:
// a	 b	     c       result
// 5	 1	     2	     5 2 1
//-2	-2	     1	     1 -2 -2
//-2	 4	     3	     4 3 -2
// 0	-2.5     5	     5 0 -2.5
//-1.1	-0.5	-0.1	-0.1 -0.5 -1.1
// 10	 20      30	     30 20 10
// 1	 1       1	     1 1 1

using System;
using System.Threading;
using System.Globalization;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a >= b)
        {
            if (a >= c)
            {
                if (b >= c)
                {
                    Console.WriteLine(a + " " + b + " " + c);
                }
                if (b < c)
                {
                    Console.WriteLine(a + " " + c + " " + b);
                }
            }
            if (a < c)
            {
                Console.WriteLine(c + " " + a + " " + b);
            }
        }
        if (a < b)
        {
            if (b >= c)
            {
                if (a >= c)
                {
                    Console.WriteLine(b + " " + a + " " + c);
                }
                if (a < c)
                {
                    Console.WriteLine(b + " " + c + " " + a);
                }
            }
            if (b < c)
            {
                Console.WriteLine(c + " " + b + " " + a);
            }
        }
    }
}

