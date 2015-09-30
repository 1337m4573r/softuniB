using System;
using System.Threading;
using System.Globalization;

class PointInACircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y: ");
        double y = double.Parse(Console.ReadLine());
        int r = (int)Math.Ceiling(Math.Sqrt((x * x) + (y * y)));
        Console.WriteLine("inside: " + (r <= 2));
    }
}

