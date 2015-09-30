//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
//Examples:
// n     randomized numbers 1…n
// 3     2 1 3
// 10    3 4 8 2 6 7 9 1 10 5 
//Note that the above output is just an example.
//Due to randomness, your program most probably will produce different results.
//You might need to use arrays.

using System;
using System.Collections.Generic;

class RandomizeTheNumbers1toN
{
    static void Main()
    {
        Random rnd = new Random();
        List<int> numbers = new List<int>();
        int n = int.Parse(Console.ReadLine());
        numbers.Add(0);
        for (int i = 1, j = 0; i <= n; i++)
        {
            j = rnd.Next(0, numbers.Count);
            numbers.Insert(j, i);
        }
        numbers.RemoveAt(numbers.Count - 1);
        foreach (Object obj in numbers)
            Console.Write("{0} ", obj);
        Console.WriteLine();
    }
}

