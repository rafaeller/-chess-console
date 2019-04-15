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

            while (!Game1.Finished)
            {
                Console.Clear();
                Screen.PrintBoard(Game1.Brd);

                Console.Write("Enter the origin position: ");
                Position origin = Screen.ReadPositionChess().ToPosition();
                Console.Write("Enter the destiny position: ");
                Position destiny = Screen.ReadPositionChess().ToPosition();

                Game1.MovePiece(origin, destiny);
            }
            

            

            Console.ReadLine();
        }
    }
}
