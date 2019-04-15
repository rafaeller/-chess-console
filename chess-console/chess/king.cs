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
            pos.DefineValues(Position.Row - 1, Position.Col);
            if (Brd.ValidPosition(pos) && CanMove(pos)) {
                mat[pos.Row, pos.Col] = true;
            }
            //up rigth
            pos.DefineValues(Position.Row - 1, Position.Col + 1);
            if (Brd.ValidPosition(pos) && CanMove(pos)) {
                mat[pos.Row, pos.Col] = true;
            }
            //rigth
            pos.DefineValues(Position.Row, Position.Col + 1);
            if (Brd.ValidPosition(pos) && CanMove(pos)) {
                mat[pos.Row, pos.Col] = true;
            }
            //down rigth
            pos.DefineValues(Position.Row + 1, Position.Col + 1);
            if (Brd.ValidPosition(pos) && CanMove(pos)) {
                mat[pos.Row, pos.Col] = true;
            }
            //down
            pos.DefineValues(Position.Row + 1, Position.Col);
            if (Brd.ValidPosition(pos) && CanMove(pos)) {
                mat[pos.Row, pos.Col] = true;
            }
            //down left
            pos.DefineValues(Position.Row + 1, Position.Col  - 1);
            if (Brd.ValidPosition(pos) && CanMove(pos)) {
                mat[pos.Row, pos.Col] = true;
            }
            //left
            pos.DefineValues(Position.Row, Position.Col - 1);
            if (Brd.ValidPosition(pos) && CanMove(pos)) {
                mat[pos.Row, pos.Col] = true;
            }
            //up left
            pos.DefineValues(Position.Row - 1, Position.Col - 1);
            if (Brd.ValidPosition(pos) && CanMove(pos)) {
                mat[pos.Row, pos.Col] = true;
            }
            return mat;
        }
    }
}
