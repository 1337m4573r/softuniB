//This problem is from Variant 3 of C# Basics exam from 11-04-2014 Morning.
//You can test your solution on https://judge.softuni.bg/Contests/4/CSharp-Basics-Exam-11-April-2014-Morning .
//You are given a number diff.
//Write a program to generate all sequences of 8 letters, each from the set { 's', 'n', 'k', 'p' },
//such that the weight of the first 4 letters differs from the weight of the second 4 letters exactly by diff.
//These sequences are called “magic strings”. Print them in alphabetical order.
//The weight of a single letter is calculated as follows:
//weight('s') = 3; weight('n') = 4;  weight('k') = 1;  weight('p') = 5.
//The weight of a sequence of 4 letters is the calculated as sum of the weights of these 4 individual letters.
//Input
//- The input data should be read from the console.
//- The number diff stays at the first line.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console as a sequence of strings in alphabetical order. Each string should stay on a separate line. In case no magic strings exist, print “No”.
//Constraints
//- The number diff will be an integer number in the range [0…100].
//- Allowed working time for your program: 0.25 seconds.
//- Allowed memory: 16 MB.
//Examples
//Input	Output      Comments
//16	kkkkpppp    weight('kkkk') = 4; weight('pppp') = 20; diff = 16
//      ppppkkkk	weight('pppp') = 20; weight('kkkk') = 4; diff = 16
//Input	Output	    Comments
//20	No	        No magic strings match the specified difference diff

using System;

class MagicStrings
{
    const int letters = 4;
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        if (diff <= 16)
        {
            char[] letter = new char[letters] { 'k', 'n', 'p', 's' };
            byte[] weight = new byte[letters] { 1, 4, 5, 3 };
            bool isFound = false;
            for (int a = 0; a < letters; a++)
            {
                for (int b = 0; b < letters; b++)
                {
                    int ab = weight[a] + weight[b];
                    for (int c = 0; c < letters; c++)
                    {
                        int abc = ab + weight[c];
                        for (int d = 0; d < letters; d++)
                        {
                            int abcd = abc + weight[d];
                            for (int e = 0; e < letters; e++)
                            {
                                for (int f = 0; f < letters; f++)
                                {
                                    int ef = weight[e] + weight[f];
                                    for (int g = 0; g < letters; g++)
                                    {
                                        int efg = ef + weight[g];
                                        for (int h = 0; h < letters; h++)
                                        {
                                            int efgh = efg + weight[h];
                                            if (Math.Abs(abcd - efgh) == diff)
                                            {
                                                //Console.WriteLine("weight('{0}') = {1}; weight('{2}') = {3}; diff = {4}",
                                                //    "" + letter[a] + letter[b] + letter[c] + letter[d], abcd,
                                                //    "" + letter[e] + letter[f] + letter[g] + letter[h], efgh, diff);
                                                Console.WriteLine("" + letter[a] + letter[b] + letter[c] + letter[d] + letter[e] + letter[f] + letter[g] + letter[h]);
                                                isFound = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (isFound)
            {
                return;
            }
        }
        Console.WriteLine("No");
    }
}

