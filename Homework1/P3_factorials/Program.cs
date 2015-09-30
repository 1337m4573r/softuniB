//Find 100!, 171! and 250! Give all digits.

using System;

namespace P3_factorials
{
    class Program
    {
        static void Main()
        {
            ///decimal mul = 1;
            byte[] mula = new byte[493];
            mula[0] = (byte)1;
            for (int i = 2; i <= 250; i++)
            {
                ///decimal temp = mul;
                byte[] tempa = new byte[493];               
                Buffer.BlockCopy(mula, 0, tempa, 0, Buffer.ByteLength(mula));

                for (int j = 1; j < i; j++)
                {
                    ///mul = mul + temp;
                    //----------------
                    for (int pos = 0; pos < 493; pos++)
                    {
                        mula[pos] += tempa[pos];
                        if (mula[pos] > 9)
                        {
                            mula[pos+1]++;
                            mula[pos] = (byte)(mula[pos] % 10);
                        }
                    }
                    //----------------
                }
                if (i == 100 || i == 171 || i == 250)
                {
                    ///Console.WriteLine(i + "! is " + mul);
                    Console.Write(i + "! is ");
                    int pos = 493 - 1;
                    for (; pos >= 0; pos--)
                    {
                        if (mula[pos] != 0)
                        {
                            break;
                        }
                    }
                    for (; pos >= 0; pos--)
                    {
                        Console.Write(mula[pos]);
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
