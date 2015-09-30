using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine((n & 1) != 0);
    }
}

