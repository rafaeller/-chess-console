using System;
using System.Collections.Generic;
using System.Text;

namespace board
{
    class Board
    {
        public int Rows { get; set; }
        public int Cols { get; set; }
        private Piece[,] Pieces;

        public Board(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            Pieces = new Piece[rows, Cols];
        }

        public Piece Piece(int row, int col)
        {
            return Pieces[row, col];
        }
        public Piece Piece(Position pos)
        {
            return Pieces[pos.Row, pos.Col];
        }

        public bool ExistsPiece(Position pos)
        {
            ValidatePosition(pos);
            return Piece(pos) != null;
        }

        public void SetPiece(Piece p, Position pos)
        {
            if (ExistsPiece(pos) )
            {
                throw new BoardException("already exists a piece in this position");
            }
            Pieces[pos.Row, pos.Col] = p;
            p.Position = pos;
        }
        public Piece RemovePiece(Position pos)
        {
            if (Piece(pos) == null)
            {
                return null;
            }
            else
            {
                Piece aux = Piece(pos);
                aux.Position = null;
                Pieces[pos.Row, pos.Col] = null;
                return aux;
            }
        }


        public bool ValidPosition (Position pos)
        {
            if (pos.Col<0 || pos.Col >= Cols || pos.Row < 0 || pos.Row >= Rows )
            {
                return false;
            }
            else
            {
                return true;
            }
           
        }
        public void ValidatePosition(Position pos)
        {
            if (!ValidPosition(pos))
            {
                throw new BoardException("invalid position");
            }
        }

    }
}
