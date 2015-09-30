//https://judge.softuni.bg/Contests/6/CSharp-Basics-Exam-12-April-2014-Morning
//You are given a sequence of bytes. Consider each byte as sequence of exactly 8 bits.
//You are given also a number step.
//Write a program to remove (kill) all the bits at positions: 1, 1 + step, 1 + 2*step, ...
//Print the output as a sequence of bytes.
//In case the last byte have less than 8 bits, add trailing zeroes at its right end.
//Bits in each byte are counted from the leftmost to the rightmost. Bits are numbered starting from 0.
//Input
//- The input data should be read from the console.
//- The number n stays at the first line.
//- The number step stays at the second line.
//- At each of the next n lines n bytes are given, each at a separate line. 
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console. Print the output bytes, each at a separate line.
//Constraints
//- The number n will be an integer number in the range [1…100].
//- The number step will be an integer number in the range [1…20].
//- The n numbers will be integers in the range [0…255].
//- Allowed working time for your program: 0.25 seconds.
//- Allowed memory: 16 MB.
//Example
//Input     Output      Comments
//2         90          We have the following input sequence of 16 bits (2 bytes):
//11        188         01101101 01010111. We kill the bits 1 and 12 (step=11). Obtained
//109                   sequence: 01011010 101111. Padding: 2 zeroes at the end. Result:
//87                    01011010 10111100.

using System;

class BitKiller
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
        byte result = 0;
        int position = 0;

        result = CopyBit(numbers[0], 0, result, position++);
        int maxBits = n<<3;
        for (int i = 1; i < maxBits; i++)
        {
            if ((i - 1) % step != 0)
            {
                if (position >= 8)
                {
                    position = 0;
                    Console.WriteLine(result);
                    result = 0;
                }
                result = CopyBit(numbers[i / 8], i % 8, result, position++);
            }
        }
        Console.WriteLine(result);
    }

    static byte CopyBit(byte src, int pos, byte result, int position)
    {
        int mask = 0x80 >> pos;
        mask &= src;
        mask = pos > position ? mask << (pos - position) : mask >> (position - pos);
        result |= (byte)mask;
        return result;
    }
}

