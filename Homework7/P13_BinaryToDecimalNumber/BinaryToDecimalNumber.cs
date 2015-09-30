//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality. Examples:
// binary                       decimal
// 0                            0
// 11                           3
// 1010101010101011             43691
// 1110000110000101100101000000 236476736

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        //string input = "1111111111111111111111111111111111111111111111111111111111111111"; // 64bit(-1)
        long output = 0;
        long pow = 1;
        if (input.Length <= 64)
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == '1')
                {
                    output += pow;
                }
                else if (input[i] != '0')
                {
                    return;
                }
                pow <<= 1;
            }
            Console.WriteLine(output);
        }
    }
}

