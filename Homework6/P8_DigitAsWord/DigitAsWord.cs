//Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid inut. Use a switch statement.
//Examples:
// d	result
// 2	two
// 1	one
// 0	zero
// 5	five
//-0.1	not a digit
// hi	not a digit
// 9	nine
// 10	not a digit

using System;

class DigitAsWord
{
    static void Main()
    {
        string d = Console.ReadLine();
        switch (d)
        {
            case "0": d = "zero"; break;
            case "1": d = "one"; break;
            case "2": d = "two"; break;
            case "3": d = "three"; break;
            case "4": d = "four"; break;
            case "5": d = "five"; break;
            case "6": d = "six"; break;
            case "7": d = "seven"; break;
            case "8": d = "eight"; break;
            case "9": d = "nine"; break;
            default: d = "not a digit"; break;
        }
        Console.WriteLine(d);
    }
}

