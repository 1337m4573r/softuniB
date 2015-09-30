//This problem come from C# Basics practical exam (10 April 2014 Morning).
//You may submit your solution here: http://judge.softuni.bg/Contests/2/CSharp-Basics-Exam-10-April-2014-Morning.
//Petya often plays with numbers. Her recent game was to play with 9-digit numbers and calculate
//their sums of digits, as well as to split them into triples with special properties.
//Help her to calculate very special numbers called “nine-digit magic numbers”.
//You are given two numbers: diff and sum. Using the digits from 1 to 7 generate all 9-digit numbers in format
//abcdefghi, such that their sub-numbers abc, def and ghi have a difference diff (ghi-def = def-abc = diff),
//their sum of digits is sum and abc ≤ def ≤ ghi.
//Numbers holding these properties are also called “nine-digit magic numbers”.
//Your task is to write a program to print these numbers in increasing order.
//Input
//- The input data should be read from the console.
//- The number sum stays at the first line.
//- The number diff stays at the second line.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console. Print all nine-digit magic numbers matching given
//difference diff and given sum of digits sum, in increasing order, each at a separate line.
//In case no nine-digit magic numbers exits, print “No”.
//Constraints
//- The number sum will be a positive integer number in the range [0…100].
//- The number diff will be a positive integer number in the range [0…1000].
//- Allowed working time for your program: 0.25 seconds.
//- Allowed memory: 16 MB.

using System;

class P18_NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = Convert.ToInt32(Console.ReadLine());
        int diff = Convert.ToInt32(Console.ReadLine()); //up to 333
        if (sum % 3 == 0 && sum >= 9 && sum <= 63 && diff <= 333)
        {
            int abc, def, ghi;
            int defMin = Math.Max((108 + sum / 3), (111 + diff + 2) - (111 + diff + 2 - sum / 3) % 3);
            int defMax = Math.Min((756 + sum / 3), (777 - diff) - (777 - diff - sum / 3) % 3);
            uint magicNumber;
            uint magicSum = 0;
            bool magicFound = false;
            for (def = defMin; def <= defMax; def += 3)
            {
                ghi = def + diff;
                abc = def - diff;
                magicNumber = (uint)(abc * 1000000 + def * 1000 + ghi);
                magicSum = magicNumber % 10;
                for (uint i = magicNumber; (i / 10) != 0; magicSum += i % 10)
                {
                    if ((i % 10) - 1 > 6)
                    {
                        magicSum = 0;
                        break;
                    }
                    i = i / 10;
                }
                if (magicSum == sum)
                {
                    magicFound = true;
                    Console.WriteLine(magicNumber);
                }
            }
            if (magicFound)
            {
                return;
            }
        }
        Console.WriteLine("No");
    }
}

