//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators. Examples:
// a	    b	    c	    result
// 5	    2	    2	    +
//-2	   -2	    1	    +
//-2	    4	    3	    -
// 0	   -2.5	    4	    0
//-1	   -0.5	   -5.1	    -

using System;
using System.Threading;
using System.Globalization;

class MultiplicationSign
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a == 0.0D || b == 0.0D || c == 0.0D)
        {
            Console.WriteLine('0');
            return;
        }
        bool isPositive = true;
        if (a < 0.0D)
        {
            isPositive = !isPositive;
        }
        if (b < 0.0D)
        {
            isPositive = !isPositive;
        }
        if (c < 0.0D)
        {
            isPositive = !isPositive;
        }
        Console.WriteLine(isPositive ? '+' : '-');
    }
}

