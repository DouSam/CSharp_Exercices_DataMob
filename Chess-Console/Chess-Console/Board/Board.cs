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
            return _pieces[line, column];
        }

        public Piece GetPiece(Position position)
        {
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

        public Piece RemovePiece(Position position)
        {
            if (GetPiece(position) == null)
            {
                return null;
            }

            Piece aux = GetPiece(position);
            aux.Position = null;
            _pieces[position.Line, position.Column] = null;
            return aux;
        }
    }
}
