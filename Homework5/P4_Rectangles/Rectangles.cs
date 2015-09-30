using System;
using System.Threading;
using System.Globalization;

class Rectangles
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("width: ");
        float width = float.Parse(Console.ReadLine());
        Console.Write("height: ");
        float height = float.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}", "width", "height", "perimeter", "area");
        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}", width, height, width + width + height + height, width * height);
    }
}

