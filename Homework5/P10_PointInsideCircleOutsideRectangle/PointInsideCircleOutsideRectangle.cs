using System;
using System.Threading;
using System.Globalization;

class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        //Console.Write("x: ");
        double x = double.Parse(Console.ReadLine());
        //Console.Write("y: ");
        double y = double.Parse(Console.ReadLine());
        //Console.Write("inside K & outside of R: ");
        Console.WriteLine((InCircle(x, y) && OutRectangle(x, y)) ? "yes" : "no");
    }
    static bool InCircle(double x, double y)
    {
        x -= 1.0d;
        y -= 1.0d;
        return Math.Sqrt((x * x) + (y * y)) <= 1.5d;
    }
    static bool OutRectangle(double x, double y)
    {
        return (x < -1.0d) || (x > 5.0d) || (y < -1.0d) || (y > 1.0d);
    }
}

