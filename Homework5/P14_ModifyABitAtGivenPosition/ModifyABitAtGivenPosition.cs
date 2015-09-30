using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        v <<= p;
        p = 1 << p;
        p = ~p;
        n &= p;
        n ^= v;
        Console.WriteLine(n);
    }
}
