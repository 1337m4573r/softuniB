//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality. Examples:
// decimal      binary
// 0            0
// 3            11
// 43691        1010101010101011
// 236476736    1110000110000101100101000000

using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        string output = "";
        for (int i = 0; i < 64; i++)
        {
            output = ((input & 1) == 0 ? '0' : '1') + output;
            if ((input >>= 1) == 0) break;
        }
        Console.WriteLine(output);
    }
}

