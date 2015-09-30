using System;
using System.Threading;
using System.Globalization;

class Trapezoids
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("h: ");
        double h = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}", "a", "b", "h", "area");
        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}", a, b, h, ((a + b) / 2) * h);
    }
}

