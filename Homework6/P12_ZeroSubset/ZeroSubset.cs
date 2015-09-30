//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.
//Examples:
//numbers           result
//3 -2 1 1 8	    -2 + 1 + 1 = 0

//3 1 -7 35 22	    no zero subset

//                  1 + -1 = 0
//1 3 -4 -2 -1      1 + 3 + -4 = 0
//                  3 + -2 + -1 = 0

//                  1 + -1 = 0
//1 1 1 -1 -1	    1 + 1 + -1 + -1 = 0
//                  1 + -1 + 1 + -1 = 0
//                  ...

//0 0 0 0 0         0 + 0 + 0 + 0 + 0 = 0

//Hint: you may check for zero each of the 32 subsets with 32 if statements.

using System;

class ZeroSubset
{
    static void Main()
    {
        Console.WriteLine("Enters 5 numbers given in a single line, separated by a space:");
        string numbers = Console.ReadLine();
        //string numbers = "3 -13 1 1 8";
        string[] separator = new string[] { " " };
        string[] number = numbers.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int[] num = new int[5];
        for (int i = 0; i < 5; i++)
        {
            num[i] = int.Parse(number[i]);
        }
        bool isFound = false;

        for (int a = 0; a <= 4; a++)
        {
            for (int b = a + 1; b <= 4; b++)
            {
                if ((num[a] + num[b]) == 0)
                {
                    isFound = true;
                    Console.WriteLine("{0} + {1} = 0", num[a], num[b]);
                }
                for (int c = b + 1; c <= 4; c++)
                {
                    if ((num[a] + num[b] + num[c]) == 0)
                    {
                        isFound = true;
                        Console.WriteLine("{0} + {1} + {2} = 0", num[a], num[b], num[c]);
                    }
                    for (int d = c + 1; d <= 4; d++)
                    {
                        if ((num[a] + num[b] + num[c] + num[d]) == 0)
                        {
                            isFound = true;
                            Console.WriteLine("{0} + {1} + {2} + {3} = 0", num[a], num[b], num[c], num[d]);
                        }
                        for (int e = d + 1; e <= 4; e++)
                        {
                            if ((num[a] + num[b] + num[c] + num[d] + num[e]) == 0)
                            {
                                isFound = true;
                                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", num[a], num[b], num[c], num[d], num[e]);
                            }
                        }
                    }
                }
            }
        }
        if (!isFound)
        {
            Console.WriteLine("no zero subset");
        }
    }
}

