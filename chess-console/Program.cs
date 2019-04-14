using System;
using board;
using screen;
using chess;

namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Game Game1 = new Game();

            

            Screen.PrintBoard(Game1.Brd);

            Console.ReadLine();
        }
    }
}
