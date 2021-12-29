using System;
using Board;

namespace Chess
{
    class Pawn : Piece
    {
        public Pawn(Color color, Board.Board board) : base(color, board)
        {
        }
        public override bool[,] PossibleMoviments()
        {
            bool[,] mat = new bool[Board.Lines, Board.Columns];

            Position pos = new Position(0, 0);

            return mat;
        }
        public override string ToString()
        {
            return "P";
        }
    }
}
