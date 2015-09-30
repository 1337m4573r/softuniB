//Joro loves a lot to play football. He used to play for his local village club “Pantera” Kaloyanovets.
//However, he is a programmer now and he is very busy.
//Now he is able to play only in the holidays and in the weekends.
//Joro plays in 1/2 of the holidays and once in the weekends,
//but not every weekend – only when he is not tired and only when he is not going to his hometown.
//Joro goes at his hometown h weekends in the year. The other weekends are considered “normal”.
//Joro is tired in 1/3 of the normal weekends.
//When Joro is at his hometown, he always plays football with his old friends once, at Sunday.
//In addition, if the year is leap, Joro plays football 3 more times additionally, in non-weekend days.
//We assume the year has exactly 52 weekends.

//Your task is to write a program that calculates how many times Joro plays football (rounded down to the nearest integer number).
//Input
//The input data should be read from the console. It consists of three input values, each at separate line:
//- The string “t” for leap year or “f” for year that is not leap.
//- The number p – number of holidays in the year (which are not Saturday or Sunday).
//- The number h – number of weekends that Joro spends in his hometown.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//- The output data must be printed on the console.
//- On the only output line you must print an integer representing how many times Joro plays football for a year.
//Constraints
//- The numbers p is in range [0...300] and h is in range [0…52].
//- Allowed working time for your program: 0.25 seconds.
//- Allowed memory: 16 MB.

using System;

class JoroTheFootballPlayer
{
    static void Main(string[] args)
    {
        char isLeapYear = (char)Console.Read();
        Console.ReadLine();
        int hollydays = Convert.ToInt32(Console.ReadLine());
        int hometownWeekends = int.Parse(Console.ReadLine());
        int normalWeekends = 52 - hometownWeekends;

        float plays = hometownWeekends + (normalWeekends * (2f / 3f)) + (hollydays / 2f) + (isLeapYear == 't' ? 3 : 0);
        Console.WriteLine((int)plays);
    }
}

