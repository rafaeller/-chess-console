using System;
using System.Collections.Generic;
using System.Text;

namespace board
{
    class Piece
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
    }
}
