//Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them.
//Examples:
//First date
//Second date	Days between
//17.03.2014
//30.04.2014	44
//
//17.03.2014
//17.03.2014	0
//
//14.06.1980
//5.03.2014	    12317
//
//5.03.2014
//3.03.2014     -2

using System;
using System.Threading;
using System.Globalization;

class DifferenceBetweenDates
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("{0}", (secondDate - firstDate).Days);
        }
    }

