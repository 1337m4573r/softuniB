//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("a = {0}\tb = {1}", a, b);
        a = a + null;
        b = b + null;
        Console.WriteLine("a = {0}\tb = {1}", a, b);
        a = a + 3; //null + digit
        b = b + 3.14159265D;
        Console.WriteLine("a = {0}\tb = {1}", a, b);

        a = 3;
        b = 3.14159265D;
        //Console.WriteLine("a = {0}\tb = {1}", a, b);
        a = a + null; //digit + null
        b = b + null;
        Console.WriteLine("a = {0}\tb = {1}", a, b);
    }
}

