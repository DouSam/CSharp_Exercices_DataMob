using System;
using Board;

namespace Chess
{
    class King : Piece
    {
        public King(Color color, Board.Board board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "K";
        }

        public override bool[,] PossibleMoviments()
        {
            bool[,] mat = new bool[Board.Lines, Board.Columns];

            Position pos = new Position(0, 0);

            // acima
            pos.DefineValues(Position.Line - 1, Position.Column);
            if (Board.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            // ne
            pos.DefineValues(Position.Line - 1, Position.Column + 1);
            if (Board.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            // direita
            pos.DefineValues(Position.Line, Position.Column + 1);
            if (Board.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            // se
            pos.DefineValues(Position.Line + 1, Position.Column + 1);
            if (Board.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            // abaixo
            pos.DefineValues(Position.Line + 1, Position.Column);
            if (Board.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            // so
            pos.DefineValues(Position.Line + 1, Position.Column - 1);
            if (Board.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            // esquerda
            pos.DefineValues(Position.Line, Position.Column - 1);
            if (Board.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            // no
            pos.DefineValues(Position.Line - 1, Position.Column - 1);
            if (Board.ValidPosition(pos) && CanMoveTo(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            return mat;
        }
    }
}
