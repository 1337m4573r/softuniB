//This problem is from Variant 2 of C# Basics exam from 10-04-2014 Evening.
//You can test your solution on https://judge.softuni.bg/Contests/Practice/Index/3#1

using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sumOdd = 0;
        int sumEven = 0;
        for (int i = 0; i < n; i++)
        {
            sumOdd += int.Parse(Console.ReadLine());
            sumEven += int.Parse(Console.ReadLine());
        }
        n = sumOdd-sumEven;
        if (n==0)
        {
            Console.WriteLine("Yes, sum=" + sumOdd);
        }
        else if (n > 0)
        {
            Console.WriteLine("No, diff=" + n);
        }
        else
        {
            Console.WriteLine("No, diff=" + (sumEven - sumOdd));
        }
    }
}