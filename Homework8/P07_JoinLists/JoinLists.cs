//Write a program that takes as input two lists of integers and joins them.
//The result should hold all numbers from the first list, and all numbers from the second list,
//without repeating numbers, and arranged in increasing order.
//The input and output lists are given as integers, separated by a space, each list at a separate line.
//Examples:
//Input                 Output
//20 40 10 10 30 80     10 20 25 30 40 80
//25 20 40 30 10
//
//5 4 3 2 1             1 2 3 4 5 6
//6 3 2
//
//1                     1
//1

using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        string input;
        string[] inputSplit;
        char[] separator = new char[] { ' ' };
        input = Console.ReadLine();
        inputSplit = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        List<int> list1 = new List<int>();
        foreach (string num in inputSplit)
        {
            list1.Add(int.Parse(num));
        }
        input = Console.ReadLine();
        inputSplit = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        List<int> list2 = new List<int>();
        foreach (string num in inputSplit)
        {
            list2.Add(int.Parse(num));
        }
        var combined = list1.Concat(list2).Distinct().ToList();
        combined.Sort();
        foreach (int num in combined)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}