﻿//Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b
//and a floating-point c and prints them in 4 virtual columns on the console.
//Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned;
//then the number a should be printed in binary form, padded with zeroes,
//then the number b should be printed with 2 digits after the decimal point, right aligned;
//the number c should be printed with 3 digits after the decimal point, left aligned. Examples:
// a    b       c       result
// 254	11.6	0.5	    |FE        |0011111110|      11.6|0.500     |
// 499	-0.5559	10000	|1F3       |0111110011|     -0.56|10000.000 |
// 0	3	    -0.1234	|0         |0000000000|         3|-0.123    |

using System;
using System.Threading;
using System.Globalization;

class FormattingNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int a;
        do
        {
            Console.Write("a = ");
            if (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid Number");
                a = -1;
            }
            if (a < 0 || a > 500){
                Console.WriteLine("The number should be between 0 - 500");
            }
        } while (a < 0 || a > 500);

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}", "a", "b", "c", "result");
        Console.WriteLine("{0,-10}{1,-10}{2,-10}|{0,-10:X}|{3}|{1,10:0.##}|{2,-10:F3}", a, b, c, Convert.ToString(a, 2).PadLeft(10, '0'));
    }
}

