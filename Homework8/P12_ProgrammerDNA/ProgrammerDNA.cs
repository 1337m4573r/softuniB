//https://judge.softuni.bg/Contests/9/CSharp-Basics-Exam-14-April-2014-Evening
//Your task is to make a program that can print simple DNA chains of various lengths.
//Simple DNA chains consist of sequence of diamond blocks containing
//only letters from A to G (see the example on the right).
//Letters are chained alphabetically: A is followed by B, then C, D, E, F, G, then again A and so on.
//Each DNA block is with size 7.
//Input
//The input data should be read from the console.
//- On the first line an integer number N specifying the length of the DNA chain will be given.
//- On the second line the starting letter of the chain will be given (capital letter from A to G).
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//Following the examples below print exactly N lines of the programmer's DNA.
//Use only capital letters from A to G and “.” for the empty space.
//Constraints
//- N will always be a positive number between 7 and 999 inclusive.
//- Allowed working time for your program: 0.1 seconds.
//- Allowed memory: 16 MB.
//Examples
//Input     Output              Input	Output
//7         ...B...             10      ...F...
//B         ..CDE..             F       ..GAB..
//          .FGABC.                     .CDEFG.
//          DEFGABC                     ABCDEFG
//          .DEFGA.                     .ABCDE.
//          ..BCD..                     ..FGA..
//          ...E...                     ...B...
//                                      ...C...
//                                      ..DEF..
//                                      .GABCD.

using System;

class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string letters = "ABCDEFGABCDEF";
        int index = (Convert.ToChar(Console.ReadLine()) - 65);

        for (int i = 0; i < n; i++)
        {
            switch (i % 7)
            {
                case 0: Console.WriteLine("...{0}...", letters[index++]); break;
                case 1: Console.WriteLine("..{0}{1}{2}..", letters[index++], letters[index++], letters[index++]); break;
                case 2: Console.WriteLine(".{0}{1}{2}{3}{4}.", letters[index++], letters[index++], letters[index++], letters[index++], letters[index++]); break;
                case 3: Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", letters[index++], letters[index++], letters[index++], letters[index++], letters[index++], letters[index++], letters[index++]); break;
                case 4: Console.WriteLine(".{0}{1}{2}{3}{4}.", letters[index++], letters[index++], letters[index++], letters[index++], letters[index++]); break;
                case 5: Console.WriteLine("..{0}{1}{2}..", letters[index++], letters[index++], letters[index++]); break;
                case 6: Console.WriteLine("...{0}...", letters[index++]); break;               
                //default: break;
            }
            index %= 7;
        }
    }
}