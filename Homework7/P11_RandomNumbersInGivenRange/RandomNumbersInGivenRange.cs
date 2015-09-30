using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Random rnd = new Random();
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        if (min>max) return;
        for (int i = 0; i < n; i++)
        {
            Console.Write(rnd.Next(min, max + 1) + " ");
        }
        Console.WriteLine();
    }
}

