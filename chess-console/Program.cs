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
                try {
                    Console.Clear();
                    Screen.PrintBoard(Game1.Brd);

                    Console.WriteLine();
                    Console.WriteLine("Turn: " + Game1.Turn + " Player: " + Game1.CurrentPlayer);
                    Console.Write("Enter the origin position: ");
                    Position origin = Screen.ReadPositionChess().ToPosition();
                    Game1.ValidatePosition(origin);

                    bool[,] PossiblePositions = Game1.Brd.Piece(origin).PosibleMoves();

                    Console.Clear();
                    Screen.PrintBoard(Game1.Brd, PossiblePositions);

                    Console.WriteLine();
                    Console.WriteLine("Turn: " + Game1.Turn + " Player: " + Game1.CurrentPlayer);
                    Console.Write("Enter the destiny position: ");
                    Position destiny = Screen.ReadPositionChess().ToPosition();
                    Game1.ValidateMove(origin, destiny);

                    Game1.ExecutePlay(origin, destiny);
                } catch (BoardException e) {
                    Console.WriteLine();
                    Console.Write(e.Message + "\npress any key to continue...");
                    Console.ReadKey();
                }
                
            }
            

            

            Console.ReadLine();
        }
    }
}
