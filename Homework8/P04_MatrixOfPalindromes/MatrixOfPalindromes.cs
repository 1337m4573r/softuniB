//Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:
//Input	Output
//      aaa aba aca	ada aea afa
//3 6	bbb bcb bdb	beb bfb bgb
//      ccc cec cdc	cfc cgc chc
//
//2 3   aaa aba aca
//      bbb bcb bdb
//
//1 1   ааа

using System;
using System.Text;

class MatrixOfPalindromes
{
    static void Main()
    {
        string yx = Console.ReadLine();
        char[] separator = new char[] {',',';',' '};
        string[] splitNumbers = yx.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int y = int.Parse(splitNumbers[0]);
        int x = int.Parse(splitNumbers[1]);
        for (int r = 0; r < y; r++)
        {
            for (int c = 0; c < x; c++)
            {
                StringBuilder element = new StringBuilder();
                element.AppendFormat("{0}{1}{0} ", (char)('a' + r), (char)('a' + r + c));
                Console.Write(element);
            }
            Console.WriteLine();
        }
    }
}
