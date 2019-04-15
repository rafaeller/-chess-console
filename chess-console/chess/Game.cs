using System;
using System.Collections.Generic;
using System.Text;
using board;

namespace chess
{
    class Game
    {
        public Board Brd { get; private set; }
        private int Turn;
        private Color CurrentPlayer;
        public bool Finished { get; private set; }

        public Game()
        {
            Brd = new Board(8,8);
            Turn = 1;
            CurrentPlayer = Color.White;
            Finished = false;
            PutPieces();
        }

        public void MovePiece(Position now, Position goTo)
        {
            Piece p = Brd.RemovePiece(now);
            p.PlusMoves();
            Piece pieceRemoved = Brd.RemovePiece(goTo);
            Brd.SetPiece(p, goTo);

        }

        private void PutPieces()
        {
            Brd.SetPiece(new King(Color.Black, Brd), new PositionChess('c', 1).ToPosition());
            Brd.SetPiece(new King(Color.Black, Brd), new PositionChess('g', 6).ToPosition());
            Brd.SetPiece(new King(Color.White, Brd), new PositionChess('f', 3).ToPosition());
            Brd.SetPiece(new King(Color.White, Brd), new PositionChess('b', 4).ToPosition());
        }

    }
}
