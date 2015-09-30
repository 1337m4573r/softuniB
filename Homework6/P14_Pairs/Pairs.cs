//https://judge.softuni.bg/Contests/6/CSharp-Basics-Exam-12-April-2014-Morning
//You are given 2*N elements (even number of integer numbers).
//The first and the second element form a pair, the third and the fourth element form a pair as well, etc.
//Each pair has a value, calculated as the sum of its two elements. Your task is to write a program to check
//whether all pairs have the same value or print the max difference between two consecutive values.
//Input
//You are given at the console even number of integers, all in a single line, separated by a space.
//Output
//The output is single line, printed at the console.
//- In case all pairs have the same value, print "Yes, value=…" and the value.
//- Otherwise, print "No, maxdiff=…" and the maximal difference between two consecutive values, always a positive integer.
//Constraints
//- All input values will be integers in the range [-1000…1000] inclusive.
//- The count of elements is even number in the range [2…1000] inclusive.
//- Allowed work time for your program: 0.25 seconds.
//- Allowed memory: 16 MB.
//Examples
// Input	        Output          Comments
// 1 2 0 3 4 -1     Yes, value=3	values = {3, 3, 3} --> equal values
// 1 2 2 2          No, maxdiff=1	values = {3, 4}, different values --> max difference = 4-3 = 1
// 1 1 3 1 2 2 0 0  No, maxdiff=4	values = {2, 4, 4, 0}, differences = {2, 0, 4}, max difference = 4
// 5 5              Yes, value=10	values = {10} --> single value --> equal values
//-1 0 0 -1         Yes, value=-1	values = {-1, -1}, equal values

using System;

class Pairs
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        string[] separator = new string[] { " " };
        string[] number = numbers.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int[] num = new int[number.Length];
        num[0] = int.Parse(number[0]);
        num[1] = int.Parse(number[1]);
        if (num.Length > 2)
        {
            int diff = 0;
            for (int i = 2; i < num.Length; i = i + 2)
            {
                num[i] = int.Parse(number[i]);
                num[i + 1] = int.Parse(number[i + 1]);
                diff = Math.Max(Math.Abs((num[i - 2] + num[i - 1]) - (num[i] + num[i + 1])), diff);
            }
            if (diff != 0)
            {
                Console.WriteLine("No, maxdiff={0}", diff);
                return;
            }
        }
        Console.WriteLine("Yes, value={0}", num[0] + num[1]);
    }
}

