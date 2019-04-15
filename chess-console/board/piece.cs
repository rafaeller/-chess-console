using System;
using System.Collections.Generic;
using System.Text;

namespace board
{
    abstract class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; set; }
        public int QteMoves { get; set; }
        public Board Brd { get; set; }

        public Piece(Color color, Board brd)
        {
            Position = null;
            Color = color;
            QteMoves = 0;
            Brd = brd;
        }
        public void PlusMoves()
        {
            QteMoves++;
        }

        public bool ExistsPosibleMoves() {
            bool[,] mat = PosibleMoves();
            for (int i = 0; i < Brd.Rows; i++) {
                for (int j = 0; j < Brd.Cols; j++) {
                    if (mat[i,j]) {
                        return true;
                    } 
                }
            }
            return false;
        }

        public bool CanMoveTo(Position pos) {
            return PosibleMoves()[pos.Row, pos.Col];
        }

        public abstract bool[,] PosibleMoves();
    }
}
