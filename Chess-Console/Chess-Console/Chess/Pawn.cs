using System;
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
        private bool ExistsEnemy(Position pos)
        {
            Piece p = Board.GetPiece(pos);
            return p != null && p.Color != Color;
        }

        private bool IsFree(Position pos)
        {
            return Board.GetPiece(pos) == null;
        }

        public override bool[,] PossibleMoviments()
        {
            bool[,] mat = new bool[Board.Lines, Board.Columns];

            Position pos = new Position(0, 0);

            if (Color == Color.White)
            {
                pos.DefineValues(Position.Line - 1, Position.Column);
                if (Board.ValidPosition(pos) && IsFree(pos))
                {
                    mat[pos.Line, pos.Column] = true;
                }
                pos.DefineValues(Position.Line - 2, Position.Column);
                Position p2 = new Position(Position.Line - 1, Position.Column);
                if (Board.ValidPosition(p2) && IsFree(p2) && Board.ValidPosition(pos) && IsFree(pos) && MovementCount == 0)
                {
                    mat[pos.Line, pos.Column] = true;
                }
                pos.DefineValues(Position.Line - 1, Position.Column - 1);
                if (Board.ValidPosition(pos) && ExistsEnemy(pos))
                {
                    mat[pos.Line, pos.Column] = true;
                }
                pos.DefineValues(Position.Line - 1, Position.Column + 1);
                if (Board.ValidPosition(pos) && ExistsEnemy(pos))
                {
                    mat[pos.Line, pos.Column] = true;
                }
            }
            else
            {
                pos.DefineValues(Position.Line + 1, Position.Column);
                if (Board.ValidPosition(pos) && IsFree(pos))
                {
                    mat[pos.Line, pos.Column] = true;
                }
                pos.DefineValues(Position.Line + 2, Position.Column);
                Position p2 = new Position(Position.Line + 1, Position.Column);
                if (Board.ValidPosition(p2) && IsFree(p2) && Board.ValidPosition(pos) && IsFree(pos) && MovementCount == 0)
                {
                    mat[pos.Line, pos.Column] = true;
                }
                pos.DefineValues(Position.Line + 1, Position.Column - 1);
                if (Board.ValidPosition(pos) && ExistsEnemy(pos))
                {
                    mat[pos.Line, pos.Column] = true;
                }
                pos.DefineValues(Position.Line + 1, Position.Column + 1);
                if (Board.ValidPosition(pos) && ExistsEnemy(pos))
                {
                    mat[pos.Line, pos.Column] = true;
                }
            }

            return mat;
        }
    }
}
