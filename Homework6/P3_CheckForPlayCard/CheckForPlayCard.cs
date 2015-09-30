//Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
//Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.
//Examples:
//character     Valid card sign?
//5	            yes
//1	            no
//Q	            yes
//q	            no
//P	            no
//10	        yes
//500	        no

using System;

class CheckForPlayCard
{
    static void Main()
    {
        string sign = Console.ReadLine();
        bool isValid;
        if (sign.Length == 1)
        {
            char c = sign[0];
            isValid = ((c >= '2' && c <= '9') || c == 'J' || c == 'Q' || c == 'K' || c == 'A');
        }
        else
        {
            isValid = (sign == "10");
        }
        Console.WriteLine(isValid ? "yes" : "no");
    }
}

