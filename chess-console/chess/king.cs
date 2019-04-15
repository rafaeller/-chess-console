using System;
using System.Collections.Generic;
using System.Text;
using board;

namespace chess
{
    class King : Piece
    {
        public King(Color color, Board brd) : base(color, brd)
        {
        }
        public override string ToString()
        {
            return "K";
        }
        private bool CanMove(Position pos)
        {
            Piece p = Brd.Piece(pos);
            return p == null || p.Color != Color;
        }
        public override bool[,] PosibleMoves()
        {
            bool[,] mat = new bool[Brd.Rows, Brd.Cols];

            Position pos = new Position(0, 0);

            //up
            pos.DefineValues(pos.Row, pos.Col);
        }
    }
}
