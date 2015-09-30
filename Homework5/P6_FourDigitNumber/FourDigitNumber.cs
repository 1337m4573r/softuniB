using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        int a, b, c, d;
        Console.Clear();
        Console.WriteLine("{0,5}{1,10}{2,10}{3,15}{4,20}", "", "sum of", "", "last digit", "second and third");
        Console.WriteLine("{0,5}{1,10}{2,10}{3,15}{3,20}", "n", "digits", "reversed", "in front", "digits exchanged");
        d = n % 10;
        c = n / 10;
        b = c / 10;
        a = b / 10;
        c = c - b * 10;
        b = b - a * 10;
        Console.WriteLine("{0,5}{1,10}{2,10}{3,15}{4,20}", n, a + b + c + d, "" + d + c + b + a, "" + d + a + b + c, "" + a + c + b + d);
    }
}

