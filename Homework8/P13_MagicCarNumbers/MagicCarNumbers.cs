//https://judge.softuni.bg/Contests/9/CSharp-Basics-Exam-14-April-2014-Evening
//Cars in Sofia have registration numbers in format "CAabcdXY" where a, b, c and d
//are digits from 0 to 9 and X and Y are letters from the following subset of the Latin alphabet:
//'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T' and 'X'.
//Examples of car numbers from Sofia are "CA8517TX", "CA2277PC", "CA0710XC", "CA1111AC",
//while "CC7512FJ" in not valid car number from Sofia.
//Local people are keen to choose special numbers for their cars, know as magic car numbers.
//They calculate the weight of a car number as follows:
//they sum its digits and letters, assuming that letters have the following values:
//'A' = 10, 'B' = 20, 'C' = 30, 'E' = 50, 'H' = 80, 'K' = 110, 'M' = 130, 'P' = 160, 'T' = 200, 'X' = 240.
//For example the weight("CA6511BM") = 30 + 10 + 6 + 5 + 1 + 1 + 20 + 130 = 203.
//A magic car number is a car number that has a special magic weight (e.g. 256 or 512 for developers)
//and its number is in some of the formats "CAaaaaXY", "CAabbbXY", "CAaaabXY", "CAaabbXY", "CAababXY" and "CAabbaXY",
//where a and b are two different digits and X and Y are letters from
//the Latin alphabet subset { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' }.
//Your task is to write a program that calculates how many cars can be registered in Sofia for given magic weight.
//Input
//The input data should be read from the console. It will consist of a single value: the magic weight.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console. It is a single value: the number of cars matching given magic value.
//Constraints
//- All input numbers will be integers in the range [1…1000].
//- Allowed working time for your program: 0.25 seconds.
//- Allowed memory: 16 MB.
//Examples
//Input	Output
//555	2
//512	18
//95	46

using System;

class MagicCarNumbers
{
    static void Main()
    {
        int[] lettersWeight = new int[10] { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };
        int magicWeight = int.Parse(Console.ReadLine());
        magicWeight -= 40;
        int count = 0;
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                int weight = magicWeight - (lettersWeight[x] + lettersWeight[y]);
                if (0 <= weight && weight <= 36)
                {
                    for (int a = 0; a <= 9; a++)
                    {
                        if ((a << 2) == weight)
                        {
                            count++;
                        }
                        else
                        {
                            for (int b = a + 1; b <= 9; b++)
                            {
                                if ((a + a + a + b) == weight)
                                {
                                    count += 2;
                                }
                                else if ((a + b + b + b) == weight)
                                {
                                    count += 2;
                                }
                                else if ((a + a + b + b) == weight)
                                {
                                    count += 6;
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
}
