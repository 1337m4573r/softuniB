//Write a program that finds the biggest of three numbers.
//Examples:
// a	 b	     c	     biggest
// 5	 2	     2	     5
//-2	-2	     1	     1
//-2	 4	     3	     4
// 0	-2.5	 5	     5
//-0.1	-0.5	-1.1	-0.1

using System;
using System.Threading;
using System.Globalization;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double biggest;
        if (a > b)
        {
            if (a > c)
            {
                biggest = a;
            }
            else
            {
                biggest = c;
            }
        }
        else
        {
            biggest = (b > c) ? b : c;
        }
        Console.WriteLine(biggest);
    }
}

