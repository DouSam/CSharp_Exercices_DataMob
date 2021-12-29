using System;
using System.Collections.Generic;
using System.Text;

namespace Board
{
    class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] _pieces;

        public Board(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            _pieces = new Piece[lines, columns];
        }

        public Piece GetPiece(int line, int column)
        {
            PositionVerify(new Position(line,column));
            return _pieces[line, column];
        }

        public Piece GetPiece(Position position)
        {
            PositionVerify(position);
            return _pieces[position.Line, position.Column];
        }

        public bool ExistsPiece(Position position)
        {
            PositionVerify(position);
            return _pieces[position.Line, position.Column] != null;
        }

        public void PlacePiece(Piece piece, Position position)
        {
            if(ExistsPiece(position))
            {
                throw new BoardException("Already exists a piece in this position.");
            }

            _pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }

        public bool ValidPosition(Position position){
            if(position.Line < 0 || position.Line >= Lines || position.Column < 0 || position.Column >= Columns)
            {
                return false;
            }
            
            return true;
        }

        public void PositionVerify(Position position)
        {
            if (!ValidPosition(position))
            {
                throw new BoardException("Invalid position.");
            }
        }
    }
}
