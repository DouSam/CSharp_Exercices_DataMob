using System;
using Board;

namespace Chess
{
    class Rook : Piece
    {
        public Rook(Color color, Board.Board board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
