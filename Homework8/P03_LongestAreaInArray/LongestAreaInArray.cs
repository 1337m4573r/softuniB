//Write a program to find the longest area of equal elements in array of strings.
//You first should read an integer n and n strings (each at a separate line),
//then find and print the longest sequence of equal elements (first its length, then its elements).
//If multiple sequences have the same maximal length, print the leftmost of them.
//Examples:

using System;

class LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string longestSequence  = "";
        int longestSequenceRep = 0;
        string input = "";
        string inputOld = Console.ReadLine();
        int repetition = 1;
        for (int i = 1; i < n; i++)
        {
            input = Console.ReadLine();
            if (String.Compare(input, inputOld) == 0)
            {
                repetition++;
            }
            else 
            {
                if (repetition > longestSequenceRep)
                {
                    longestSequence = String.Copy(inputOld);
                    longestSequenceRep = repetition;
                }
                repetition = 1;
                inputOld = String.Copy(input);
            }   
        }
        if (repetition > longestSequenceRep)
        {
            longestSequence = String.Copy(inputOld);
            longestSequenceRep = repetition;
        }
        Console.WriteLine(longestSequenceRep);
        for (int i = 0; i < longestSequenceRep; i++)
        {
            Console.WriteLine(longestSequence);
        }
    }
}

