using System;
using Board;

namespace Chess
{
    class Knight: Piece
    {
        public Knight(Color color, Board.Board board) : base(color, board)
        {
        }
        public override bool[,] PossibleMoviments()
        {
            bool[,] mat = new bool[Board.Lines, Board.Columns];

            Position pos = new Position(0, 0);

            pos.DefineValues(Position.Line - 1, Position.Column - 2);
            if (Board.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            pos.DefineValues(Position.Line - 2, Position.Column - 1);
            if (Board.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            pos.DefineValues(Position.Line - 2, Position.Column + 1);
            if (Board.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            pos.DefineValues(Position.Line - 1, Position.Column + 2);
            if (Board.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            pos.DefineValues(Position.Line + 1, Position.Column + 2);
            if (Board.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            pos.DefineValues(Position.Line + 2, Position.Column + 1);
            if (Board.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            pos.DefineValues(Position.Line + 2, Position.Column - 1);
            if (Board.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            pos.DefineValues(Position.Line + 1, Position.Column - 2);
            if (Board.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            return mat;
        }
        public override string ToString()
        {
            return "N";
        }
    }
}
