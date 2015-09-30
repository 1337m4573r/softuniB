//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12],
//a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time”
//according to the definition above or “invalid time” if the time cannot be parsed.
//Note that you may need to learn how to parse dates and times. Examples:
//time	    result
// 1:00 PM	beer time
// 4:30 PM	beer time
//10:57 PM	beer time
// 8:30 AM	non-beer time
//02:59 AM	beer time
//03:00 AM	non-beer time
//03:26 AM	non-beer time

using System;
using System.Threading;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        DateTime time;
        string timeString = Console.ReadLine();
        try
        {
            time = Convert.ToDateTime(timeString);
        }
        catch (FormatException)
        {
            Console.WriteLine("invalid time");
            return;
        }
        if (time.Hour > 2 && time.Hour < 13)
        {
            Console.WriteLine("non-beer time");
        }  
        else
        {
            Console.WriteLine("beer time");
        }
    }
}

