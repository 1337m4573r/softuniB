//Check if the 24th, 101st and 251st prime numbers are part of the base Fibonacci number set. What is their position?

using System;

namespace P2_fiboprimes
{
    class Program
    {
        const int p24 = 89;
        const int p101 = 547;
        const int p251 = 1597;
        static int index = 0;

        static void Main()
        {
            index++;
            check(0, 1);
        }

        static void check(int a, int b)
        {
            int sum = a + b;
            index++;
            //Console.WriteLine(index + " is " + sum);
            if (sum <= p251)
            {
                if (sum == p24) { Console.WriteLine("24th Prime number ("+ p24 + ") is "+ index +" Fibonacci number"); }
                if (sum == p101) { Console.WriteLine("101th Prime number (" + p101 + ") is " + index + " Fibonacci number"); }
                if (sum == p251) { Console.WriteLine("251th Prime number (" + p251 + ") is " + index + " Fibonacci number"); }
                check(b, sum);
            }
        }

    }
}
