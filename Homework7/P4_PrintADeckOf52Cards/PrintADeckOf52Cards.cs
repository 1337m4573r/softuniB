//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
//The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
//Use 2 nested for-loops and a switch-case statement.

using System;
using System.Threading;
using System.Globalization;

class PrintADeckOf52Cards
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        for (int rank = 2; rank <= 14; rank++)
        {
            for (int suit = 15; suit <= 18; suit++)
            {
                Print(rank);
                Print(suit);
            }
            Console.WriteLine();
        }
    }
    static void Print(int id)
    {
        string element;
        switch (id)
        {
            case 11: element = "J"; break;
            case 12: element = "Q"; break;
            case 13: element = "K"; break;
            case 14: element = "A"; break;
            case 15: element = "\x05 "; break;
            case 16: element = "\x04 "; break;
            case 17: element = "\x03 "; break;
            case 18: element = "\x06 "; break;
            default: element = Convert.ToString(id); break;
        }
        Console.Write("{0,2}",element);
    }
}

