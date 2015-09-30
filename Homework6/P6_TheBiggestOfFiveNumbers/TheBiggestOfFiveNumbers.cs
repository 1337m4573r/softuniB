//Write a program that finds the biggest of five numbers by using only five if statements.
//Examples:
// a	 b	     c	     d	     e	     biggest
// 5	 2	     2	     4	     1	     5
//-2	-22	     1	     0	     0	     1
//-2	 4	     3	     2	     0	     4
// 0	-2.5	 0	     5	     5	     5
//-3	-0.5	-1.1	-2	    -0.1	-0.1

using System;
using System.Threading;
using System.Globalization;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double biggest = a;
        if (biggest < b) 
        {
            biggest = b;
        }
        if (biggest < c)
        {
            biggest = c;
        }
        if (biggest < d)
        {
            biggest = d;
        }
        if (biggest < e)
        {
            biggest = e;
        }
        Console.WriteLine(biggest);
    }
}

