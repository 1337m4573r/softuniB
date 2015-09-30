//Write a program that reads the radius r of a circle and prints its perimeter
//and area formatted with 2 digits after the decimal point. Examples:
//r     perimeter   area
//2     12.57       12.57
//3.5   21.99       38.48

using System;
using System.Threading;
using System.Globalization;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        float r = float.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("{0,-10}{1,-10}{2,-10}", "Radius", "Perimeter", "Area");
        Console.WriteLine("{0,-10:F2}{1,-10:F2}{2,-10:F2}", r, Math.PI * (2 * r), Math.PI * (r * r));
    }
}

