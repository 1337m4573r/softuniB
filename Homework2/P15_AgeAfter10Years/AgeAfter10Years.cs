//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class AgeAfter10Years
{
    static void Main()
    {
        string dateString = String.Empty;
        DateTime convertedDate;
        DateTime zeroTime = new DateTime(1, 1, 1);
        TimeSpan span;

        Console.WriteLine("When were you born?");
        Console.WriteLine("(example: 31/01/1996 or 06 July 2008 7:32:47 AM)\n");
        dateString = Console.ReadLine();

        try
        {
            convertedDate = Convert.ToDateTime(dateString);
            //Console.WriteLine("'{0}' converts to {1} {2} time.", dateString, convertedDate, convertedDate.Kind.ToString());
        }
        catch (FormatException)
        {
            Console.WriteLine("'{0}' is not in the proper format.", dateString);
            return;
        }
        span = DateTime.Now - convertedDate;
        if (span.Ticks < 0)
        {
            Console.WriteLine("\nYou are not born yet!");
            return;
        }
        int years = (zeroTime + span).Year - 1;
        Console.WriteLine("\nYou are {0} years old", years);
        Console.WriteLine("After 10 years you will be {0} years old", (years + 10));
    }
}
