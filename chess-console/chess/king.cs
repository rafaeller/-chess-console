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
    }
}
