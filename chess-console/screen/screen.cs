using System;

using System.Collections.Generic;
using System.Text;
using board;

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
                    if (brd.Piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        PrintPiece(brd.Piece(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void PrintPiece(Piece piece)
        {
            if (piece.Color == Color.White)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }

    }
}
