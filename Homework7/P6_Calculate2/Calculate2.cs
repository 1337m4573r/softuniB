//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop. Examples:
//n	k	n!/k!
//5	2	60
//6	5	6
//8	3	6720

using System;
using System.Numerics;

class Calculate2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n <= 2 || n >= 100) return;
        int k = int.Parse(Console.ReadLine());
        if (k <= 1 || k > n) return;
        BigInteger factorial = 1;
        for (int i = k + 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}

