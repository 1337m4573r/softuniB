using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        if (p > q)
        {
            p ^= q ^= p ^= q;
        }
        if ((p < 0) || ((q + k - 1) > 31))
        {
            Console.WriteLine("out of range");
        }
        else if ((q - p) < k)
        {
            Console.WriteLine("overlapping");
        }
        else
        {
            //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            uint a = n >> p;
            a = a << (32 - k);
            a = a >> (32 - k - p);
            n = n - a;
            a = a << (q - p);

            uint b = ((n >> q) << (32 - k)) >> (32 - k - q);
            n -= b;
            b >>= q - p;

            n |= a;
            n |= b;
            //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine(n);
            Main();
        }
    }
}

