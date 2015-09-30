//Find Least Common Multiple LCM(1234, 3456).

using System;

namespace P6_lcm
{
    class Program
    {
        static void Main()
        {
            int num1 = 1234;
            int num2 = 3456;
            int div = 2;
            int lfc = 1;
            bool isDivisible;

            for (; (num1 != 1) || (num2 != 1); )
            {
                isDivisible = false;
                if (num1 % div == 0)
                {
                    isDivisible = true;
                    num1 = num1 / div;
                }
                if (num2 % div == 0)
                {
                    isDivisible = true;
                    num2 = num2 / div;
                }
                if (isDivisible)
                {
                    lfc = lfc * div;
                }
                else
                {
                    div = GetNextPrime(div);
                }
            }
            Console.WriteLine("LCM(1234, 3456) = {0}", lfc);
        }

        static int GetNextPrime(int num)
        {
            num++;
            int max = (int)Math.Sqrt(num);
            bool isPrime;
            isPrime = true;
            for (int i = 2; i <= max; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (!isPrime)
            {
                return GetNextPrime(num);
            }
            return num;           
        }
    }
}
