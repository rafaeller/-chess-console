using System;
using System.Collections.Generic;
using System.Text;
using board;

namespace chess
{
    class Tower : Piece
    {
        public Tower(Color color, Board brd) : base(color, brd)
        {
        }
        public override string ToString()
        {
            return "T";
        }
        private bool CanMove(Position pos) {
            Piece p = Brd.Piece(pos);
            return p == null || p.Color != Color;
        }
        public override bool[,] PosibleMoves() {
            bool[,] mat = new bool[Brd.Rows, Brd.Cols];

            Position pos = new Position(0, 0);

            //up
            pos.DefineValues(Position.Row - 1, Position.Col);
            while (Brd.ValidPosition(pos) && CanMove(pos)) {
                mat[pos.Row, pos.Col] = true;
                if (Brd.Piece(pos) != null && Brd.Piece(pos).Color != Color ) {
                    break;
                }
                pos.Row = pos.Row - 1;
            }
            //rigth
            pos.DefineValues(Position.Row, Position.Col + 1);
            while (Brd.ValidPosition(pos) && CanMove(pos)) {
                mat[pos.Row, pos.Col] = true;
                if (Brd.Piece(pos) != null && Brd.Piece(pos).Color != Color) {
                    break;
                }
                pos.Col = pos.Col + 1;
            }
            //down
            pos.DefineValues(Position.Row + 1, Position.Col);
            while (Brd.ValidPosition(pos) && CanMove(pos)) {
                mat[pos.Row, pos.Col] = true;
                if (Brd.Piece(pos) != null && Brd.Piece(pos).Color != Color) {
                    break;
                }
                pos.Row = pos.Row + 1;
            }
            //left
            pos.DefineValues(Position.Row, Position.Col- 1);
            while (Brd.ValidPosition(pos) && CanMove(pos)) {
                mat[pos.Row, pos.Col] = true;
                if (Brd.Piece(pos) != null && Brd.Piece(pos).Color != Color) {
                    break;
                }
                pos.Col = pos.Col - 1;
            }
            return mat;
        }
    }
}