using System;
using System.Collections.Generic;
using System.Text;
using board;

namespace chess
{
    class PositionChess
    {
        public int Row { get; set; }
        public Char Col { get; set; }

        public PositionChess(char col, int row )
        {
            Row = row;
            Col = col;
        }
        public override string ToString()
        {
            return "" + Col + Row;
        }
        public Position ToPosition()
        {
            return new Position(8 - Row, Col - 'a');
            
        }
    }
}
