//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality. Examples:
// decimal      hexadecimal
// 254          FE
// 6883         1AE3
// 338583669684	4ED528CBB4

using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        string output = "";
        char nibble;
        for (long i = 0; i <= 16; i++)
        {
            switch (input&15L)
            {
                case 0: nibble = '0'; break;
                case 1: nibble = '1'; break;
                case 2: nibble = '2'; break;
                case 3: nibble = '3'; break;
                case 4: nibble = '4'; break;
                case 5: nibble = '5'; break;
                case 6: nibble = '6'; break;
                case 7: nibble = '7'; break;
                case 8: nibble = '8'; break;
                case 9: nibble = '9'; break;
                case 10: nibble = 'A'; break;
                case 11: nibble = 'B'; break;
                case 12: nibble = 'C'; break;
                case 13: nibble = 'D'; break;
                case 14: nibble = 'E'; break;
                case 15: nibble = 'F'; break;
                default: return;
            }

            output = nibble + output;
            if ((input >>= 4) == 0) break;
        }
        Console.WriteLine(output);
    }
}

