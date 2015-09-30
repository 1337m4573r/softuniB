//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
//Examples:
//numbers	number as words
//0	    Zero
//9	    Nine
//10	Ten
//12	Twelve
//19	Nineteen
//25	Twenty five
//98	Ninety eight
//273	Two hundred and seventy three
//400	Four hundred
//501	Five hundred and one
//617	Six hundred and seventeen
//711	Seven hundred and eleven
//999	Nine hundred and ninety nine

using System;

class NumberAsWords
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int a = num / 100;
        int bc = num % 100;
        int b = bc / 10;
        int c = bc % 10;
        string text;
        if (num == 0)
        {
            text = "zero";
        }
        else
        {
            switch (a)
            {
                case 0: text = ""; break;
                case 1: text = "one hundred"; break;
                case 2: text = "two hundred"; break;
                case 3: text = "three hundred"; break;
                case 4: text = "four hundred"; break;
                case 5: text = "five hundred"; break;
                case 6: text = "six hundred"; break;
                case 7: text = "seven hundred"; break;
                case 8: text = "eight hundred"; break;
                case 9: text = "nine hundred"; break;
                default: return;
            }
            if (bc != 0)
            {
                if (a != 0)
                {
                    text += " and ";
                }
                switch (bc)
                {
                    case 10: text += "ten"; break;
                    case 11: text += "eleven"; break;
                    case 12: text += "twelve"; break;
                    case 13: text += "thirteen"; break;
                    case 14: text += "fourteen"; break;
                    case 15: text += "fifteen"; break;
                    case 16: text += "sixteen"; break;
                    case 17: text += "seventeen"; break;
                    case 18: text += "eighteen"; break;
                    case 19: text += "nineteen"; break;
                    default: break;
                }
                switch (b)
                {
                    case 2: text += "twenty"; break;
                    case 3: text += "thirty"; break;
                    case 4: text += "forty"; break;
                    case 5: text += "fifty"; break;
                    case 6: text += "sixty"; break;
                    case 7: text += "seventy"; break;
                    case 8: text += "eighty"; break;
                    case 9: text += "ninety"; break;
                    default: break;
                }
                if (b != 1)
                {
                    if (b != 0 && c > 0)
                    {
                        text += " ";
                    }
                    switch (c)
                    {
                        case 1: text += "one"; break;
                        case 2: text += "two"; break;
                        case 3: text += "three"; break;
                        case 4: text += "four"; break;
                        case 5: text += "five"; break;
                        case 6: text += "six"; break;
                        case 7: text += "seven"; break;
                        case 8: text += "eight"; break;
                        case 9: text += "nine"; break;
                        default: break;
                    }
                }
            }
        }
        text = Char.ToUpper(text[0]) + text.Remove(0, 1);
        Console.WriteLine(text);
    }
}

