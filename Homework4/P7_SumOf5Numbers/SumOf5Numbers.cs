//Write a program that enters 5 numbers (given in a single line, separated by a space),
//calculates and prints their sum. Examples:
//numbers	        sum
//1 2 3 4 5         15
//10 10 10 10 10	50
//1.5 3.14 8.2 -1 0	11.84

using System;
using System.Threading;
using System.Globalization;

class SumOf5Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string numbers = Console.ReadLine();
        string[] separator = new string[] { " " };
        string[] num = numbers.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        double sum = 0.0D;
        for (int i = 0; i < 5; i++)
        {
            sum += double.Parse(num[i]);
        }
        Console.WriteLine(sum);
    }
}

