//Write a program that reads a sequence of integers and finds in it the longest non-decreasing subsequence.
//In other words, you should remove a minimal number of numbers from the starting sequence,
//so that the resulting sequence is non-decreasing.
//In case of several longest non-decreasing sequences, print the leftmost of them.
//The input and output should consist of a single line, holding integer numbers separated by a space.
//Examples:
//Input                                 Output
//1                                     1
//7 3 5 8 -1 6 7	                    3 5 6 7
//1 1 1 2 2 2                           1 1 1 2 2 2
//1 1 1 3 3 3 2 2 2 2	                1 1 1 2 2 2 2
//11 12 13 3 14 4 15 5 6 7 8 7 16 9 8   3 4 5 6 7 8 16

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LongestNonDecreasingSubsequence
{
    public static int[] number;
    public static List<int> seq;
    public static List<int> longestSubSeq;

    static void Main()
    {
        string numbers = Console.ReadLine();
        char[] separator = new char[] { ',', ';', ' ' };
        string[] splitNumbers = numbers.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        number = new int[splitNumbers.Length];
        for (int i = 0; i < splitNumbers.Length; i++)
        {
            number[i] = int.Parse(splitNumbers[i]);
        }
        seq = new List<int>();
        longestSubSeq = new List<int>();
        if (number.Length == 1)
        {
            longestSubSeq.Add(number[0]);
        }
        for (int i = 1; i < number.Length; i++)
        {
            seq.Clear();
            seq.Add(number[i - 1]);
            BuildSubSeq(i);
        }
        foreach (int num in longestSubSeq)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
    }

    static void BuildSubSeq(int j)
    {
        for (; j < number.Length; j++)
        {
            if (seq.Last() <= number[j])
            {
                seq.Add(number[j]);
                BuildSubSeq(j + 1);
                seq.RemoveAt(seq.Count - 1);
            }
        }
        if (seq.Count > longestSubSeq.Count)
        {
            longestSubSeq = new List<int>(seq);
        }
    }
}

