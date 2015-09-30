//SoftUni has opened a new training center in Kaspichan, but the people there did not know how to find it.
//Your task is to print a vertical arrow, which will be used to indicate the path to the new building in the city.
//This will help thousands of people to become software engineers. Please help them!
//Input
//The input data should be read from the console.
//-	On the only line will hold and integer number N (always odd number), indicating the width of the arrow. 
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console. Use the “#” (number sign) to mark the arrow and “.” (dot) for the rest. Follow the examples below.
//Constraints
//-	N will always be a positive odd number between 3 and 79 inclusive.
//-	Allowed working time for your program: 0.1 seconds.
//-	Allowed memory: 16 MB.
//Examples
//  Input   Output          Input   Output		            Input	Output
//  5       ..#####..       9       ....#########....       3       .###.
//          ..#...#..               ....#.......#....               .#.#.
//          ..#...#..               ....#.......#....               ##.##
//          ..#...#..               ....#.......#....               .#.#.
//          ###...###               ....#.......#....               ..#..
//          .#.....#.               ....#.......#....               .....
//          ..#...#..               ....#.......#....               .....
//          ...#.#...               ....#.......#....               .....
//          ....#....               #####.......#####               .....
//          .........               .#.............#.               .....
//          .........               ..#...........#..               .....
//          .........               ...#.........#...               .....
//                                  ....#.......#....                    
//                                  .....#.....#.....                    
//                                  ......#...#......                    
//                                  .......#.#.......                    
//                                  ........#........                    

using System;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}", new String('.', n >> 1), new String('#', n));
        for (int i = 2; i < n; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new String('.', n >> 1), new String('.', n - 2));
        }
        Console.WriteLine("{0}{1}{0}", new String('#', (n + 2) >> 1), new String('.', n - 2));
        for (int i = 1, j = (n << 1) - 5; j > 0; i++, j = j - 2)
        {
            Console.WriteLine("{0}#{1}#{0}", new String('.', i), new String('.', j));
        }
        Console.WriteLine("{0}#{0}", new String('.', n - 1));
    }
}
