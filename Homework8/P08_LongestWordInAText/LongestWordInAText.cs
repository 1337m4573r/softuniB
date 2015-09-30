//Write a program to find the longest word in a text.
//Examples:
//Input                                         Output
//
//Welcome to the Software University.	        University
//
//The C# Basics course is awesome start in      programming
//programming with C# and Visual Studio.

using System;
using System.Linq;

class LongestWordInAText
{
    static void Main()
    {
        string sentence = Console.ReadLine();
        char[] separator = new char[] { ' ', ',', '(', ')', '.', ';', '!', '?' };
        string[] words = sentence.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        //Console.WriteLine(words.OrderByDescending(s => s.Length).First());

        string[] longestWords = words.Where(s => s.Length == words.Max(m => m.Length)).ToArray();
        foreach (string word in longestWords)
        {
            Console.WriteLine(word);
        }
    }
}