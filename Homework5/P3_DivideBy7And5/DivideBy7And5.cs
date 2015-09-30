using System;

class DivideBy7And5
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool divBy5 = ((n % 5) == 0);
        bool divBy7 = ((n % 7) == 0);
        Console.WriteLine(divBy5 && divBy7 && n != 0);
    }
}

