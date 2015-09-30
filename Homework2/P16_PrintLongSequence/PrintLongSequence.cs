//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … You might need to learn how to use loops in C# (search in Internet).

using System;

class PrintLongSequence
{
    static void Main()
    {
        const int members = 1000;
        for (int i = 2; i < members + 2; i++)
        {
            Console.Write(" {0},", i++);
            //if (i == members + 2)
            //{
            //    break;
            //}
            Console.Write(" -{0},", i);
        }
        Console.WriteLine("\b ");
    }
}

