using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine((n >> 3) & 1);
    }
}

