using System;
using System.Text.RegularExpressions;

class ExtractURLsFromText
{
    static void Main()
    {
        string text = Console.ReadLine();
        Regex linkParser = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        foreach (var url in linkParser.Matches(text))
        {
            Console.WriteLine(url);
        }
    }
}

