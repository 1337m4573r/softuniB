//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc. Examples:
// numbers      result
// 2 1 1 6 3	yes
//              product = 6
// 3 10 4 6 5 1	yes
//              product = 60
// 4 3 2 5 2	no
//              odd_product = 16
//              even_product = 15

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        string[] separator = new string[] { " " };
        string[] number = numbers.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int odd = 1;
        int even = 1;
        for (int i = 0; i < number.Length; i = i + 2)
        {
            odd *= int.Parse(number[i]);
        }
        for (int i = 1; i < number.Length; i = i + 2)
        {
            even *= int.Parse(number[i]);
        }
        if (odd == even)
        {
            Console.WriteLine("yes\nproduct = " + odd);
        }
        else
        {
            Console.WriteLine("no\nodd_product = {0}\neven_product = {1}", odd, even);
        }
    }
}

