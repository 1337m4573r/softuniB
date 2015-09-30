//This problem is from Variant 4 of C# Basics exam from 11-04-2014 Evening.
//You can test your solution on https://judge.softuni.bg/Contests/5/CSharp-Basics-Exam-11-April-2014-Evening .
//You are given a sequence of bytes. Consider each byte as sequence of exactly 8 bits.
//You are given also a number step.
//Write a program to extract all the bits at positions: 1, 1 + step, 1 + 2*step, ...
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
//Examples
//Input Output	Comments
//3     63      We have the following input sequence of 24 bits (3 bytes):
//2     192     00101101 01010111 11111010
//45            We take bits 1, 3, 5, …, 23 (step=2). We obtain the sequence:
//87            00111111 1100. We pad it with 4 zeroes to obtain 2 full bytes.
//250           Result: 00111111 11000000.

using System;

class CatchTheBits
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
        byte resultNum = 0;
        byte resultPos = 0;
        for (int pos = 1; pos < (n << 3); pos += step)
        {
            int byt = pos / 8;
            int bit = pos - 8 * byt;
            byte mask = (byte)(128 >> bit);
            mask &= numbers[byt];
            mask <<= bit;
            mask >>= resultPos;
            resultNum |= mask;
            resultPos++;
            if (resultPos == 8)
            {
                Console.WriteLine(resultNum);
                resultPos = 0;
                resultNum = 0;
            }
        }
        if (resultPos != 0)
        {
            Console.WriteLine(resultNum);
        }
    }
}

