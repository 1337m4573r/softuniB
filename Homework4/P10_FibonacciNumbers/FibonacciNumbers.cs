﻿//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
//(at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note that you may need to learn how to use loops. Examples:
//n     comments
//1     0
//3     0 1 1
//10	0 1 1 2 3 5 8 13 21 34

using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 1;
        int sumOld = 0;
        if (n >= 1)
        {
            Console.Write("0 ");
        }
        if (n >= 2)
        {
            Console.Write("1 ");
        }
        for (int i = 2; i < n; i++)
        {
            sum += sumOld;
            sumOld = sum - sumOld;
            Console.Write(sum + " ");
        }
        Console.WriteLine("");
    }
}

