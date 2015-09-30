//https://judge.softuni.bg/Contests/6/CSharp-Basics-Exam-12-April-2014-Morning
//Consider we are given a date in format dd-mm-yyyy, e.g. 17-03-2007.
//We calculate the weight of this date by joining together all its digits,
//multiplying each digit by each of the other digits and finally sum all obtained products.
//In our case we will have 8-digits: 17032007, so the weight is
//1*7 + 1*0 + 1*3 + 1*2 + 1*0 + 1*0 + 1*7 + 7*0 + 7*3 + 7*2 + 7*0 + 7*0 + 7*7 + 0*3 +
//0*2 + 0*0 + 0*0 + 0*7 + 3*2 + 3*0 + 3*0 + 3*7 + 2*0 + 2*0 + 2*7 + 0*0 + 0*7 + 0*7 = 144.
//Your task is to write a program that finds all magic dates: dates between two fixed years matching given magic weight. The dates should be printed in increasing order in format dd-mm-yyyy. We use the traditional calendar (years have 12 months, each having 28, 29, 30 or 31 days, etc.). Years start from 1 January and end in 31 December.
//Input
//The input data should be read from the console. It consists of 3 lines:
//- The first line holds an integer number – start year.
//- The second line holds an integer number – end year.
//- The third line holds an integer number – magic weight.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console as a sequence of dates in format dd-mm-yyyy in alphabetical order. Each string should stay on a separate line. In case no magic dates exist, print “No”.
//Beware that the regional settings at your computer and at the judge's computer may be different!
//Constraints
//- The start and end year are integers in the range [1900-2100].
//- The magic weight is an integer number in range [1…1000].
//- Allowed working time for your program: 0.25 seconds.
//- Allowed memory: 16 MB.
//Examples
//Input Output          Input   Output      Input   Output
//2007  17-03-2007      2003    No          2011    01-01-2011
//2007  13-07-2007      2004                2012    10-01-2011
//144   31-07-2007      1500                14      01-10-2011
//                                                  10-10-2011

using System;

class MagicDates
{
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());
        int a, b, c, d, e, f, g, h;
        int abcd, abcdef, abcdefgh;
        bool isDateValid;
        bool isDateFound = false;

        for (int yyyy = startYear; yyyy <= endYear; yyyy++)
        {
            d = yyyy % 10;
            c = (yyyy % 100) / 10;
            b = (yyyy / 100) % 10;
            a = yyyy / 1000;
            abcd = d * (a + b + c) + c * (a + b) + b * a;
            for (int mm = 1; mm <= 12; mm++)
            {
                f = mm % 10;
                e = mm / 10;
                abcdef = abcd + f * (a + b + c + d + e) + e * (a + b + c + d);

                for (int dd = 1; dd <= 31; dd++)
                {
                    h = dd % 10;
                    g = dd / 10;
                    abcdefgh = abcdef + h * (a + b + c + d + e + f + g) + g * (a + b + c + d + e + f);
                    if (abcdefgh == magicWeight)
                    {  
                        try
                        {
                            isDateValid = true;
                            DateTime date = new DateTime(yyyy, mm, dd);
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            isDateValid = false;
                        }
                        if (isDateValid)
                        {
                            isDateFound = true;
                            Console.WriteLine("{0:00}-{1:00}-{2:0000}", dd, mm, yyyy);
                        }
                    }
                }
            }
        }
        if (!isDateFound)
        {
            Console.WriteLine("No");
        }
    }
}

