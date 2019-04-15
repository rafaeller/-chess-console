using System;

using System.Collections.Generic;
using System.Text;
using board;
using chess;

namespace screen
{
    class Screen
    {
        public static void PrintBoard(Board brd)
        {
            for (int i = 0; i < brd.Rows; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < brd.Cols; j++)
                {
                   PrintPiece(brd.Piece(i, j));

                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void PrintBoard(Board brd, bool[,] possiblePositions) {

            ConsoleColor BackgroundOriginal = Console.BackgroundColor;
            ConsoleColor BackgroundAlt = ConsoleColor.DarkGray;

            for (int i = 0; i < brd.Rows; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < brd.Cols; j++) {
                    if (possiblePositions [i,j]) {
                        Console.BackgroundColor = BackgroundAlt;
                    } else {
                        Console.BackgroundColor = BackgroundOriginal;
                    }
                    PrintPiece(brd.Piece(i, j));
                    Console.BackgroundColor = BackgroundOriginal;
                }

                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
            Console.BackgroundColor = BackgroundOriginal;
        }

        public static PositionChess ReadPositionChess()
        {
            string s = Console.ReadLine();
            char col = s[0];
            int row = int.Parse(s[1].ToString());
            return new PositionChess(col, row);
        }

        public static void PrintPiece(Piece piece)
        {
            if (piece == null) {
                Console.Write("- ");
            } 
            else {
                if (piece.Color == Color.White) {
                    Console.Write(piece);
                } else {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(piece);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }

    }
}
