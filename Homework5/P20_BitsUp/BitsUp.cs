//This problem is from Variant 2 of C# Basics exam from 10-04-2014 Evening.
//You can test your solution on https://judge.softuni.bg/Contests/Practice/Index/3#4

using System;

class BitsUp
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int step = Convert.ToInt32(Console.ReadLine());
        byte[] numbers = new byte[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToByte(Console.ReadLine());
        }
        for (int pos = 1; pos < (n << 3); pos += step)
        {
            int byt = pos / 8;
            int bit = pos - 8 * byt;
            byte mask = (byte)(128 >> bit);
            numbers[byt] |= mask;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
