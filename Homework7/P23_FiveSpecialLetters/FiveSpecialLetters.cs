//https://judge.softuni.bg/Contests/7/CSharp-Basics-Exam-12-April-2014-Evening
//We are given two numbers: start and end.
//Write a program to generate all sequences of 5 letters, each from the set { 'a', 'b', 'c', 'd', 'e' },
//such that the weight of these 5 letters is a number in the range [start … end] inclusively.
//Print them in alphabetical order, in a single line, separated by a space.
//The weight of a single letter is calculated as follows: 
//weight('a') = 5; weight('b') = -12;  weight('c') = 47;  weight('d') = 7;  weight('e') = -32.
//The weight of a sequence of letters c1c2…cn is the calculated by first removing
//all repeating letters (from right to left) and then calculate the formula:
//weight(c1c2…cn) = 1*weight(c1) + 2*weight(c2) + … + n*weight(cn)
//For example, the weight of "bcddc" is calculated as follows:
//First we remove the repeating letters and we get "bcd".
//Then we apply the formula: 1*weight('b') + 2*weight('c') + 3*weight('d') = 1*(-12) + 2*47 + 3*7 = 103.
//Another example: weight("cadea") = weight("cade") = 1*47 + 2*5 + 3*7 - 4*32 = -50.
//Input
//The input data should be read from the console. It will consist of 2 lines:
//-	The number start stays at the first line.
//-	The number end stays at the second line.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console as a sequence of strings in alphabetical order.
//Each string should be separated than the next string by a single space.
//In case no 5-letter strings exist with a weight in the specified range, print “No”.
//Constraints
//-	The numbers start and end will be an integers in the range [-10000…10000].
//-	Allowed working time for your program: 0.25 seconds.
//-	Allowed memory: 16 MB.
//Examples
//  Input	Output	        Comments
//  40      bcead bdcea     weight("bcead") = 41
//  42                      weight("bdcea") = 40
//  Input	Output
//  -1      bcdea cebda eaaad eaada eaadd eaade eaaed eadaa eadad
//  1       eadae eadda eaddd eadde eadea eaded eadee eaead eaeda
//          eaedd eaede eaeed eeaad eeada eeadd eeade eeaed eeead
//  Input	Output
//  300     No
//  400

using System;

class FiveSpecialLetters
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        char[] letters = new char[5] { 'a', 'b', 'c', 'd', 'e' };
        sbyte[] weights = new sbyte[5] { 5, -12, 47, 7, -32 };
        bool isFound = false;

        for (int i = 0; i < 5; i++)
        {
            int mul1 = 1;
            int weights1 = weights[i];
            for (int j = 0; j < 5; j++)
            {
                int mul2 = mul1;
                int weights2 = weights1;
                if (letters[j] != letters[i])
                {
                    mul2++;
                    weights2 += weights[j] * mul2;
                }
                for (int k = 0; k < 5; k++)
                {
                    int mul3 = mul2;
                    int weights3 = weights2;
                    if ((letters[k] != letters[j]) && (letters[k] != letters[i]))
                    {
                        mul3++;
                        weights3 += weights[k] * mul3;
                    }
                    for (int l = 0; l < 5; l++)
                    {
                        int mul4 = mul3;
                        int weights4 = weights3;
                        if ((letters[l] != letters[k]) && (letters[l] != letters[j]) && (letters[l] != letters[i]))
                        {
                            mul4++;
                            weights4 += weights[l] * mul4;
                        }
                        for (int m = 0; m < 5; m++)
                        {
                            int mul5 = mul4;
                            int weights5 = weights4;
                            if ((letters[m] != letters[l]) && (letters[m] != letters[k]) && (letters[m] != letters[j]) && (letters[m] != letters[i]))
                            {
                                mul5++;
                                weights5 += weights[m] * mul5;
                            }
                            if (start <= weights5 && weights5 <= end)
                            {
                                isFound = true;
                                Console.Write("{0}{1}{2}{3}{4} ", letters[i], letters[j], letters[k], letters[l], letters[m]);
                            }
                        }
                    }
                }
            }
        }
        if(!isFound)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine();
        }
    }
}