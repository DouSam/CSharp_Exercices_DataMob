﻿using System;
using Board;

namespace Chess
{
    class Bishop : Piece
    {
        public Bishop(Color color, Board.Board board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
