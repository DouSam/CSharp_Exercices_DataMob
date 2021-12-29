using System;
using Board;

namespace Chess
{
    class Queen : Piece
    {
        public Queen(Color color, Board.Board board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "Q";
        }
    }
}
