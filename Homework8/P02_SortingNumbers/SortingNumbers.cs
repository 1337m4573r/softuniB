//Write a program that reads a number n and a sequence of n integers, sorts them and prints them. Examples:
// Input    Output          Input   Output
//   5       -3              3       0
//   3        0              0       0
//  -3        2              1       1
//   2        3              0
// 122      122
//   0

using System;
using System.Collections.Generic;

class SortingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}

