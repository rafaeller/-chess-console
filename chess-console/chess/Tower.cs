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
    }
}