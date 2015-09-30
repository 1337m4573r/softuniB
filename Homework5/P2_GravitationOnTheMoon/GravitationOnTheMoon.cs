using System;
using System.Threading;
using System.Globalization;

class GravitationOnTheMoon
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        float weight = float.Parse(Console.ReadLine());
        Console.WriteLine((weight * 17f) / 100f);
    }
}

