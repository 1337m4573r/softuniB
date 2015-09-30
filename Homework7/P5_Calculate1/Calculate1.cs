//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
//Use only one loop. Print the result with 5 digits after the decimal point.
//n	 x	S
//3	 2	2.75000
//4	 3	2.07407
//5	-4	0.75781

using System;
using System.Numerics;
using System.Threading;
using System.Globalization;

class Calculate1
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double s = 1.0d;
        BigInteger factorial = 1;
        BigInteger power = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
            power = power * x;
            s += ((double)factorial / (double)power);
        }
        Console.WriteLine("{0:F5}",s);
    }
}

