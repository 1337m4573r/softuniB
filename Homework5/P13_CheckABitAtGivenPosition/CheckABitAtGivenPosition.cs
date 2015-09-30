using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine(((n >> p) & 1) == 1);
    }
}

