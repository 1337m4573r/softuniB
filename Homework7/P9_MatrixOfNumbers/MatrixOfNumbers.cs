//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20)
//and prints a matrix like in the examples below. Use two nested loops. Examples:
// n	matrix      n	matrix      n   matrix
//      1 2             1 2 3           1 2 3 4
// 2    3 4         3   2 3 4       4   2 3 4 5
//                      3 4 5           3 4 5 6
//                                      4 5 6 7

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n < 1 || n > 20) return;

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <= i + n - 1; j++)
            {
                Console.Write(n < 6 ? "{0,-1} " : "{0,-4:D2}", j);
            }
            Console.WriteLine();
        }
    }
}

