//https://judge.softuni.bg/Contests/7/CSharp-Basics-Exam-12-April-2014-Evening
//Nakov enjoys playing with bits very much. Yesterday he invented a new game.
//He takes a 19-bit number and rolls it on the right (moves its most right bit at the left most position).
//He tried this several times and he found it is too easy. Then he invented
//a more complex game: freeze a certain bit as a pillar and roll right all other bits several times.
//Help Nakov to write a program that rolls r times a 19-bit number n with a frozen bit at position f.
//Example: we have the number n = 2521, which is 0000000100111011001 in binary (as a 19-bit number).
//We freeze the bit at position f = 8 (we count the positions from the right, starting from 0).
//We roll out the number r = 4 times. We obtain the result 295245 as follows:
//-	2521(10) = 0000000100111011001  1000000010101101100 (roll right with frozen position 8)
//-	1000000010101101100  0100000001100110110 (roll right with frozen position 8)
//-	0100000001100110110  0010000000110011011 (roll right with frozen position 8)
//-	0010000000110011011  1001000000101001101 = 295245(10) (roll right with frozen position 8)
//Input
//The input data should be read from the console. It will consist of 3 lines:
//-	The number n stays at the first line.
//-	The number f stays at the second line.
//-	The number r stays at the third line.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//Print the obtained result after rolling r times n with a frozen bit at position f at the console (as decimal number).
//Constraints
//-	The number n will be a 19-bit unsigned integer (in the range [0…524287]).
//-	The number f will be integer in the range [0…18].
//-	The number r will be integer in the range [0…100].
//-	Allowed working time for your program: 0.25 seconds.
//-	Allowed memory: 16 MB.
//Examples
//  Input   Output      Comments
//  2521    295245      2521(10) = 0000000100111011001 -> 1000000010101101100 ->
//  8                   0100000001100110110 -> 0010000000110011011 -> 1001000000101001101 =
//  4                   295245(10)
//  Input   Output      Comments
//  480678  447849      480679(10) = 1110101010110100110 -> 1011010101011010011 ->
//  18                  1101101010101101001 = 447849(10)
//  2

using System;

class BitRoller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        int mask1 = 1 << f;
        int mask2 = mask1 << 1;
        int maskn = ~(mask1 | mask2);
        int r = int.Parse(Console.ReadLine());
        for (int i = 0; i < r; i++)
        {
            n |= (f == 0) ? (n & 2) << 18 : (n & 1) << 19;
            n = ((n & maskn) | ((n & mask1) << 1) | ((n & mask2) >> 1));
            n >>= 1;
        }
        Console.WriteLine(n);
    }
}
