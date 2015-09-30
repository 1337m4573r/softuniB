//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality. Examples:
// hexadecimal  decimal
// FE           254
// 1AE3         6883
// 4ED528CBB4   338583669684

using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        //string input = "FFFFFFFFFFFFFFFF"; // 64bit(-1)
        long output = 0;
        long pow = 1;
        int nibble = 0;
        if (input.Length <= 16)
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                switch (input[i])
                {
                    case '0': nibble = 0; break;
                    case '1': nibble = 1; break;
                    case '2': nibble = 2; break;
                    case '3': nibble = 3; break;
                    case '4': nibble = 4; break;
                    case '5': nibble = 5; break;
                    case '6': nibble = 6; break;
                    case '7': nibble = 7; break;
                    case '8': nibble = 8; break;
                    case '9': nibble = 9; break;
                    case 'A': nibble = 10; break;
                    case 'B': nibble = 11; break;
                    case 'C': nibble = 12; break;
                    case 'D': nibble = 13; break;
                    case 'E': nibble = 14; break;
                    case 'F': nibble = 15; break;
                    default: return;
                }
                output += nibble * pow;
                pow <<= 4;
            }
            Console.WriteLine(output);
        }
    }
}

