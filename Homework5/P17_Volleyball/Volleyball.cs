//This problem is from Variant 2 of C# Basics exam from 10-04-2014 Evening.
//You can test your solution on https://judge.softuni.bg/Contests/Practice/Index/3#0

using System;

class Volleyball
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        int leapBonus = yearType == "leap" ? 23 : 20;
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        Console.WriteLine((leapBonus * ((3 * h) + (p << 3) + 432)) / 240);
    }
}