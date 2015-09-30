//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic.
//Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
//Examples:
//Number a	    Number b    Equal (with precision   Explanation
//                          eps=0.000001)
//5.3           6.01        false                   The difference of 0.71 is too big (> eps)
//5.00000001	5.00000003	true	                The difference 0.00000002 < eps
//5.00000005	5.00000001	true	                The difference 0.00000004 < eps
//-0.0000007	0.00000007	true	                The difference 0.00000077 < eps
//-4.999999	    -4.999998	false	                Border case. The difference 0.000001 == eps.
//                                                  We consider the numbers are different.
//4.999999	    4.999998	false	                Border case. The difference 0.000001 == eps.
//                                                  We consider the numbers are different.

using System;

class ComparingFloats
{
    const double eps = 0.000001D;

    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        Compare(5.3D, 6.01D);
        Compare(5.00000001D, 5.00000003D);
        Compare(5.00000005D, 5.00000001D);
        Compare(-0.0000007D, 0.00000007D);
        Compare(-4.999999D, -4.999998D);
        Compare(4.999999D, 4.999998D);
    }

    static void Compare(double a, double b)
    {
        Console.WriteLine("a = {0} \tb = {1} \tequal = {2}", a.ToString("##0.0#######"), b.ToString("##0.0#######"), Math.Abs(a - b) <= eps);
    }
}

