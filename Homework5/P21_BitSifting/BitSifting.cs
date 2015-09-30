//This problem is from Variant 3 of C# Basics exam from 11-04-2014 Morning.
//You can test your solution on https://judge.softuni.bg/Contests/Practice/Index/4#4

using System;

class BitSifting
{
    static void Main()
    {
        ulong num = ulong.Parse(Console.ReadLine());
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            num &= ~ulong.Parse(Console.ReadLine());
        }
        num = num - ((num >> 1) & 0x5555555555555555);
        num = (num & 0x3333333333333333) + ((num >> 2) & 0x3333333333333333);
        num = (((num + (num >> 4)) & 0x0F0F0F0F0F0F0F0F) * 0x0101010101010101) >> 56;
        Console.WriteLine(num);
    }
}
