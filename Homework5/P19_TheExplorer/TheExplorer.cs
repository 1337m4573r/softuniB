//This problem is from Variant 3 of C# Basics exam from 11-04-2014 Morning.
//You can test your solution on https://judge.softuni.bg/Contests/Practice/Index/4#2

using System;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{0}", new String('-', n >> 1));
        for (int i = (n-3) / 2; i > 0; i--)
        {
            Console.WriteLine("{0}*{1}*{0}", new String('-', i), new String('-', (n -(i << 1) - 2)));
        }
        for (int i = 0, j = n-2; j >= 1; i++, j = j - 2)
        {
            Console.WriteLine("{0}*{1}*{0}", new String('-', i), new String('-', j));
        }
        Console.WriteLine("{0}*{0}", new String('-', n >> 1));
    }
}
