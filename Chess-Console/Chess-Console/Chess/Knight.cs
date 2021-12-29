using System;
using Board;

namespace Chess
{
    class Knight: Piece
    {
        public Knight(Color color, Board.Board board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "N";
        }
    }
}
