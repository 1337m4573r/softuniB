//Implement the "Falling Rocks" game in the text console.
//A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
//A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
//Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density.
//The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
//Implement collision detection and scoring system.

using System;
using System.Collections;
using System.Threading;
using System.Media;

namespace P12_FallingRocks
{
    class FallingRocks
    {
        static void Main()
        {
            //BGM
            SoundPlayer player = new SoundPlayer(P12_FallingRocks.Properties.Resources.kamanite);
            player.PlayLooping();

            //initial settings and display
            Random rand = new Random();
            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight;
            string wholeImage = "";
            char[] ctrlLine = new char[Console.BufferWidth];
            Queue scanlines = new Queue();
            for (int i = 0; i < Console.BufferHeight - 1; i++)
            {
                scanlines.Enqueue(new string(' ', Console.BufferWidth));
            }
            ctrlLine = scanlines.Dequeue().ToString().ToCharArray();
            int posX = ((Console.BufferWidth - 1) / 2) - 1;
            ctrlLine[posX] = '('; ctrlLine[posX + 1] = 'O'; ctrlLine[posX + 2] = ')';
            foreach (Object obj in scanlines)
                wholeImage += obj;
            Console.Clear();
            Console.Write(wholeImage);
            Console.Write(ctrlLine);
            int score = 0;
            int totalScore = 0;
            int saturation = Console.BufferWidth;
            Console.Write("Score: 0");
            wholeImage = "";

            //main loop
            bool gameover = false;
            do
            {
                Thread.Sleep(150);

                for (int i = 0; i < 10; i++)
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo pressedKey = Console.ReadKey();
                        if (pressedKey.Key == ConsoleKey.RightArrow)
                            if (posX < Console.BufferWidth - 3) posX++;
                        if (pressedKey.Key == ConsoleKey.LeftArrow)
                            if (posX > 0) posX--;
                    }

                scanlines.Enqueue(GenerateLine(rand, saturation - (totalScore / 10)));
                ctrlLine = scanlines.Dequeue().ToString().ToCharArray();
                ctrlLine[posX] = ctrlLine[posX] == ' ' ? '(' : 'X';
                ctrlLine[posX + 1] = ctrlLine[posX + 1] == ' ' ? 'O' : 'X';
                ctrlLine[posX + 2] = ctrlLine[posX + 2] == ' ' ? ')' : 'X';
                foreach (Object obj in scanlines)
                    wholeImage = obj + wholeImage;
                Console.Clear();
                Console.Write(wholeImage);
                Console.Write(ctrlLine);
                totalScore += score;
                score = 0;
                Console.Write("Score: " + totalScore);
                wholeImage = "";

                //check for collision
                foreach (char i in ctrlLine)
                {
                    if (i == 'X') gameover = true;
                    if (i == ' ') score++;
                }
                score = (Console.BufferWidth - 3) - score;
            } while (!gameover);

            //Game Over
            Console.Clear();
            for (int i = 0; i < ((Console.BufferHeight >> 1) - 1); i++)
            {
                Console.Write(new string(' ', Console.BufferWidth));
            }
            Console.Write(new string(' ', (Console.BufferWidth >> 1) - 5));
            Console.Write("GAME OVER");
            Console.Write(new string(' ', (Console.BufferWidth >> 1) - 4));
            Console.Write(new string(' ', (Console.BufferWidth >> 1) - 5));
            Console.WriteLine("Score: {0}", totalScore);
            for (int i = 0; i < ((Console.BufferHeight >> 1) - 1); i++)
            {
                Console.Write(new string(' ', Console.BufferWidth));
            }
            Thread.Sleep(2000);
        }
        static string GenerateLine(Random rand, int saturation)
        {
            string line = "";
            char symbol;
            for (int i = 0; i < Console.BufferWidth; i++)
            {
                if (rand.Next(Math.Abs(saturation)) == 0)
                {
                    switch (rand.Next(11))
                    {
                        case 0: symbol = '^'; break;
                        case 1: symbol = '@'; break;
                        case 2: symbol = '*'; break;
                        case 3: symbol = '&'; break;
                        case 4: symbol = '+'; break;
                        case 5: symbol = '%'; break;
                        case 6: symbol = '$'; break;
                        case 7: symbol = '#'; break;
                        case 8: symbol = '!'; break;
                        case 9: symbol = '.'; break;
                        default: symbol = ';'; break;
                    }
                }
                else
                {
                    symbol = ' ';
                }
                line += symbol;
            }
            return line;
        }
    }
}