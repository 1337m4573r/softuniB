using System;

class BitsExchange
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint a = (n << 21) & 0x07000000;
        uint b = (n >> 21) & 0x00000038;
        n &= 0xF8FFFFC7;
        n |= a;
        n |= b;
        //Console.WriteLine(Convert.ToString(n,2).PadLeft(32,'0'));
        Console.WriteLine(n);
    }
}

