//This problem is from Variant 3 of C# Basics exam from 11-04-2014 Morning. 
//You can test your solution on https://judge.softuni.bg/Contests/4/CSharp-Basics-Exam-11-April-2014-Morning .
//You are given n numbers. Find an element that is equal to the sum of all of the other elements.
//Input
//Input data should be read from the console.
//- At the only line in the input a sequence of integers stays (numbers separated one from another by a space).
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output data must be printed on the console. At the only line of the output print the result.
//- Print "Yes, sum=…" if there is an element that is equal to the sum of all other elements, along with this sum.
//- Print "No, diff=…" if there is no element that is equal to the sum of all other elements. Print also the minimum
//possible difference between an element from the sequence and the sum of all other elements (always a positive number).
//Constraints
//- All input numbers are integers in the range [0 … 2 000 000 000].
//- The count n of the input integers is in the range [2 ... 1 000].
//- Allowed working time for your program: 0.1 seconds.
//- Allowed memory: 16 MB.
//Examples
//Input	            Output	        Comments
//3 4 1 1 2 12 1	Yes, sum=12	    3 + 4 + 1 + 2 + 1 + 1 = 12
//6 1 2 3	        Yes, sum=6
//1 1 10	        No, diff=8
//5 5 1	            No, diff=1
//1 1 1	            No, diff=1
//0 0	            Yes, sum=0

using System;

class SumOfElements
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        string[] separator = new string[] { " " };
        string[] splitNumbers = numbers.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int[] num = new int[splitNumbers.Length];
        long sum = 0;
        for (int i = 0; i < splitNumbers.Length; i++)
        {
            num[i] = int.Parse(splitNumbers[i]);
            sum += num[i];
        }
        long diff = sum;
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] == sum - num[i])
            {
                Console.WriteLine("Yes, sum=" + num[i]);
                return;
            }
            if (diff > Math.Abs(sum - ((long)num[i] << 1)))
            {
                diff = Math.Abs(sum - num[i] - num[i]);
            }
        }
        Console.WriteLine("No, diff=" + diff);
    }
}

