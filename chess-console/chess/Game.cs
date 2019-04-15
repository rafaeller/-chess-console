using System;
using System.Collections.Generic;
using System.Text;
using board;

namespace chess
{
    class Game
    {
        public Board Brd { get; private set; }
        public int Turn { get; private set; }
        public Color CurrentPlayer { get; private set; }
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

        public void ExecutePlay(Position now, Position goTo) {
            MovePiece(now, goTo);
            Turn++;
            ChangePlayer();

        }

        private void ChangePlayer() {
            if (CurrentPlayer == Color.White) {
                CurrentPlayer = Color.Black;
            } else {
                CurrentPlayer = Color.White;
            }
        }

        public void ValidatePosition(Position pos) {
            if (Brd.Piece(pos) == null) {
                throw new BoardException("Cam´t find that piece");
            }
            if (CurrentPlayer != Brd.Piece(pos).Color) {
                throw new BoardException("that isn't your piece");
            }
            if (!Brd.Piece(pos).ExistsPosibleMoves()) {
                throw new BoardException("you can't move that piece");
            }
        }

        public void ValidateMove(Position origin, Position destiny) {
            if (!Brd.Piece(origin).CanMoveTo(destiny)) {
                throw new BoardException("you can't move that piece to this destiny");
            }
        }


            private void PutPieces()
        {
            Brd.SetPiece(new King(Color.Black, Brd), new PositionChess('c', 1).ToPosition());
            Brd.SetPiece(new Tower(Color.Black, Brd), new PositionChess('g', 6).ToPosition());
            Brd.SetPiece(new King(Color.White, Brd), new PositionChess('f', 3).ToPosition());
            Brd.SetPiece(new Tower(Color.White, Brd), new PositionChess('b', 4).ToPosition());
        }

    }
}
