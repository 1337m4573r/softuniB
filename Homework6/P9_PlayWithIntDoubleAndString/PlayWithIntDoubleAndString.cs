//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends "*" at the end.
//Print the result at the console. Use switch statement.
//Example:
// program	                user            program                 user
// Please choose a type:                    Please choose a type:
// 1 --> int                                1 --> int
// 2 --> double             3               2 --> double            2
// 3 --> string                             3 --> string
// Please enter a string:	hello           Please enter a double:	1.5
// hello*                                   2.5

using System;
using System.Threading;
using System.Globalization;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        string d = Console.ReadLine();
        switch (d)
        {
            case "1":
                {
                    Console.WriteLine("Please enter a int:");
                    int result = int.Parse(Console.ReadLine());
                    Console.WriteLine(++result);
                    break;
                }
            case "2":
                {
                    Console.WriteLine("Please enter a double:");
                    double result = double.Parse(Console.ReadLine());
                    Console.WriteLine(result+1.0D);
                    break;
                }
            case "3":
                {
                    Console.WriteLine("Please enter a string:");
                    string result = Console.ReadLine();
                    Console.WriteLine(result+'*');
                    break;
                }
        }
    }
}

