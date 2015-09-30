using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isPrime;

        if (n < 3)
        {
            isPrime = (n == 2);
        }
        else
        {
            if (n % 2 == 0)
            {
                isPrime = false;
            }
            else
            {
                int div;
                for (div = 3; n % div != 0; div += 2)
                    ;
                isPrime = (div == n);
            }
        }
        Console.WriteLine(isPrime);
    }
}

