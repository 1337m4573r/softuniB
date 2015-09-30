//You are given three right angled triangles. Find the length of their hypotenuses.
//Catheti: 3 and 4
//Catheti:  10 and 12
//Catheti: 100 and 250

using System;

namespace P4_hypotenuse
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Catheti: 3 and 4 ; Hypotenuses: " + Math.Sqrt(Math.Pow(3.0,2) + Math.Pow(4.0,2)));
            Console.WriteLine("Catheti: 10 and 12 ; Hypotenuses: " + Math.Sqrt(Math.Pow(10.0, 2) + Math.Pow(12.0, 2)));
            Console.WriteLine("Catheti: 100 and 250 ; Hypotenuses: " + Math.Sqrt(Math.Pow(100.0, 2) + Math.Pow(250.0, 2)));
        }
    }
}
