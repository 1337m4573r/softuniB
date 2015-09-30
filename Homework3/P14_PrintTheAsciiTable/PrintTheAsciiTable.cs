//Find online more information about ASCII (American Standard Code for Information Interchange) and
//write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255).
//Note that some characters have a special purpose and will not be displayed as expected.
//You may skip them or display them differently.
//You may need to use for-loops (learn in Internet how).

using System;

class PrintTheAsciiTable
{
    static void Main()
    {
        string tableLine;
        Console.WriteLine("X| 0 1 2 3 4 5 6 7 8 9 A B C D E F");
        Console.WriteLine("-+--------------------------------");
        Console.WriteLine("0|   \x01 \x02 \x03 \x04 \x05 \x06         \x0b \x0c   \x0e \x0f");

        for (int row = 1; row <= 0x0f; row++)
        {
            tableLine = row.ToString("X") + "|";
            for (int col = 0; col <= 0x0f; col++)
            {
                tableLine = tableLine + " " + (char)((row<<4)+col);
            }
            Console.WriteLine(tableLine);
        }
    }
}

