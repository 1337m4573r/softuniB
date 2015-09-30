//Write a program that takes as input two lists of names and
//removes from the first list all names given in the second list.
//The input and output lists are given as words, separated by a space, each list at a separate line.
//Examples:
//Input                                         Output
//Peter Alex Maria Todor Steve Diana Steve      Peter Alex Maria Diana
//Todor Steve Nakov
//
//Hristo Hristo Nakov Nakov Petya               Hristo Hristo Petya
//Nakov Vanessa Maria

using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        char[] separator = new char[] { ' ' };
        string names = Console.ReadLine();
        string[] name = names.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        string namesX = Console.ReadLine();
        string[] nameX = namesX.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < name.Length; i++)
        {
            foreach (string j in nameX)
            {
                if (String.Compare(name[i], j) == 0)
                {
                    name[i] = null;
                }
            }
            if (name[i] != null)
            {
                Console.Write(name[i] + " ");
            }
        }
        Console.WriteLine();
    }
}

