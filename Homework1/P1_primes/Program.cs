//Find the 24th, 101st and 251st prime number.

using System;

namespace P1_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            for (int index = 1; index <= 251; num++)
            {
                int max = (int)Math.Sqrt(num);
                bool isPrime;
                isPrime = true;
                for (int i = 2; i <= max; i++)
                {
                    //Console.WriteLine(i);
                    //Console.WriteLine(num % i != 0);
                    if (num % i == 0)
                    {
                        //Console.WriteLine(num + " is not Prime");
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(num + " is Prime # " + index);
                    index++;
                }
            }
        }
    }
}
