//Write a program that reads from the console a sequence of n integer numbers and returns the minimal,
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below. Examples:
// input    output       input  output
// 3        min = 1      2      min = -1
// 2        max = 5     -1      max = 4
// 5        sum = 8      4      sum = 3
// 1        avg = 2.67          avg = 1.50
	
using System;

    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                int num = int.Parse(Console.ReadLine());
                int min = num;
                int max = num;
                int sum = num;
                for (int i = 1; i < n; i++)
                {
                    num = int.Parse(Console.ReadLine());
                    if (num < min)
                    {
                        min = num;
                    }
                    else if (num > max)
                    {
                        max = num;
                    }
                    sum += num;
                }
                Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:F2}\n", min, max, sum, (double)sum / n);
            }
        }
    }

