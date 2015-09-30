//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints
//a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
//Examples:
// n    matrix      n   matrix		n	matrix
// 2    1 2         3   1 2 3       4    1  2  3  4
//      3 4             8 9 4           12 13 14  5
//                      7 6 5           11 16 15  6
//                                      10  9  8  7

using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n < 1 || n > 20) return;
        int[,] matrix = new int[n, n];
        int elements = n - 1;
        int x = 0;
        int y = 0;
        int num = 1;
        do
        {
            matrix[y, x] = num;
            for (int i = 0; i < elements; i++)
            {
                matrix[y, x++] = num++;
            }
            for (int i = 0; i < elements; i++)
            {
                matrix[y++, x] = num++;
            }
            for (int i = elements; i > 0; i--)
            {
                matrix[y, x--] = num++;
            }
            for (int i = elements; i > 0; i--)
            {
                matrix[y--, x] = num++;
            }
            x++;
            y++;
            elements -= 2;
        } while (elements >= 0);

        //print
        for (y = 0; y < n; y++)
        {
            for (x = 0; x < n; x++)
            {
                if(n>=10)
                {
                    Console.Write("{0,3} ", matrix[y, x]);
                }
                else if (n >= 3)
                {
                    Console.Write("{0,2} ", matrix[y, x]);
                }
                else
                {
                    Console.Write("{0} ", matrix[y, x]);
                }
            }
            Console.WriteLine();
        }
    }
}

