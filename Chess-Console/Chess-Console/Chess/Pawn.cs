﻿using System;
using Board;

namespace Chess
{
    class Pawn : Piece
    {
        public Pawn(Color color, Board.Board board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "P";
        }
    }
}
