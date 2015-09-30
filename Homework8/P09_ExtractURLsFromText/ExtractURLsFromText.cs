//Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
//- http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
//- www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com
//Examples:
//Input
//The site nakov.com can be access from http://nakov.com or www.nakov.com.
//It has subdomains like mail.nakov.com and svetlin.nakov.com.
//Please check http://blog.nakov.com for more information.
//Output
//http://nakov.com
//www.nakov.com
//http://blog.nakov.com

using System;

class ExtractURLsFromText
{
    static void Main()
    {
        string text = Console.ReadLine();
        char[] separator = new char[] { ' ', ',', '(', ')', ';', '!', '?' };
        string[] words = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (word.StartsWith("http://"))
            {
                if (word[word.Length - 1] == '.')
                {
                    Console.WriteLine(word.Remove(word.Length - 1));
                }
                else
                {
                    Console.WriteLine(word);
                } 
            }
            else if (word.StartsWith("www."))
            {
                char[] dot = new char[] { '.' };
                string[] url = word.Split(dot, StringSplitOptions.RemoveEmptyEntries);
                if (url.Length == 3)
                {
                    Console.WriteLine(url[0]+'.'+url[1]+'.'+url[2]);
                }
            }
        }
    }
}
