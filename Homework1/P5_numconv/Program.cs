//Convert 1234d to binary and hexadecimal numeral systems.
//Convert 1100101b to decimal and hexadecimal numeral systems.
//Convert ABChex to decimal and binary numeral systems.

using System;

namespace P5_numconv
{
    class Program
    {
        static void Main(string[] args)
        {
            String bin;
            String dec;
            String hex;

            bin = Convert.ToString(Convert.ToInt32("1234", 10), 2);
            hex = Convert.ToString(Convert.ToInt32("1234", 10), 16);
            Console.WriteLine("bin:" + bin + " dec:1234 hex:" + hex);

            dec = Convert.ToString(Convert.ToInt32("1100101", 2), 10);
            hex = Convert.ToString(Convert.ToInt32("1100101", 2), 16);
            Console.WriteLine("bin:1100101 dec:" + dec + " hex:" + hex);

            bin = Convert.ToString(Convert.ToInt32("ABC", 16), 2);
            dec = Convert.ToString(Convert.ToInt32("ABC", 16), 10);
            Console.WriteLine("bin:" + bin + " dec:" + dec + " hex:abc");
        }
    }
}
