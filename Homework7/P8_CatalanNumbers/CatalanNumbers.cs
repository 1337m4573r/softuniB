//In combinatorics, the Catalan numbers are calculated by the following formula:

//Write a program to calculate the nth Catalan number by given n (1 < n < 100). Examples:
// n	Catalan(n)
// 0	1
// 5	42
// 10	16796
// 15	9694845

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n <= 1 || n >= 100) //constraints
        {
            if (n == 0 || n == 1) Console.WriteLine(1); //f*ck the constraints
            return;
        }
        BigInteger dividend = 1;
        BigInteger divisor = 1;
        for (int k = 2; k <= n; k++)
        {
            dividend *= n + k;
            divisor *= k;
        }
        Console.WriteLine(dividend / divisor);
    }
}

