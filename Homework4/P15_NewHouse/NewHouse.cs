//This problem is from Variant 4 of C# Basics exam from 11-04-2014 Evening.
//You can test your solution on https://judge.softuni.bg/Contests/5/CSharp-Basics-Exam-11-April-2014-Evening .
//Little Joro likes to build huts.
//After he built all the huts in his whole village, he decided to go to the big city and start building houses.
//But his knowledge of how to do this is limited.
//Help Joro to design the façade of a beautiful house by printing it to the console.
//The house must have a roof and one floor.
//The roof must contains only the symbols ‘*’ and ‘-’ and the floor
//must contains the symbols ‘*’ and ‘|’ (see the examples below).
//Input
//- The input data should be read from the console.
//- At the only input line you are given an integer number N (always an odd number) showing the height of the house (without the roof).
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//- The output should be printed on the console.
//- You should print the house on the console, just like in the examples below. Each row can contain only the following characters: “-” (dash), “*” (asterisk) and “|” (pipe). 
//Constraints
//- The number N will be a positive odd integer number between 3 and 101, inclusive.
//- Allowed working time for your program: 0.25 seconds.
//- Allowed memory: 16 MB.

using System;

class NewHouse
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i < (N + 1); i += 2)
        {
            string roofLine = StringRepeat((N - i) / 2, '-') + StringRepeat(i, '*') + StringRepeat((N - i) / 2, '-');
            Console.WriteLine(roofLine);
        }
        for (int i = 0; i < N; i ++)
        {
            string floorLine = "|" + StringRepeat(N-2, '*') + "|";
            Console.WriteLine(floorLine);
        }

    }
    static string StringRepeat(int times, char pattern)
    {
        return new String(pattern, times);
    }
}

