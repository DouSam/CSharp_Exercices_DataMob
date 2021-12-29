using System;
using Board;

namespace Chess
{
    class Game
    {
        public Board.Board Board { get; private set; }
        private int Turn;
        private Color ActualPlayer;
        public bool Finished { get; private set; }

        public Game()
        {
            Board = new Board.Board(8, 8);
            Turn = 1;
            ActualPlayer = Color.White;
            Finished = false;
            placePieces();
        }

        public void Moviment(Position origin, Position destiny)
        {
            Piece piece = Board.RemovePiece(origin);
            piece.IncreaseMovement();
            Piece pieceCaptured = Board.RemovePiece(destiny);
            Board.PlacePiece(piece, destiny);
        }

        private void placePieces()
        {
            Board.PlacePiece(new Rook(Color.White, Board), new PositionChess('c', 1).toPosition());
            Board.PlacePiece(new Rook(Color.White, Board), new PositionChess('c', 2).toPosition());
            Board.PlacePiece(new Rook(Color.White, Board), new PositionChess('d', 2).toPosition());
            Board.PlacePiece(new Rook(Color.White, Board), new PositionChess('e', 2).toPosition());
            Board.PlacePiece(new Rook(Color.White, Board), new PositionChess('e', 1).toPosition());
            Board.PlacePiece(new King(Color.White, Board), new PositionChess('d', 1).toPosition());

            Board.PlacePiece(new Rook(Color.Black, Board), new PositionChess('c', 7).toPosition());
            Board.PlacePiece(new Rook(Color.Black, Board), new PositionChess('c', 8).toPosition());
            Board.PlacePiece(new Rook(Color.Black, Board), new PositionChess('d', 7).toPosition());
            Board.PlacePiece(new Rook(Color.Black, Board), new PositionChess('e', 7).toPosition());
            Board.PlacePiece(new Rook(Color.Black, Board), new PositionChess('e', 8).toPosition());
            Board.PlacePiece(new King(Color.Black, Board), new PositionChess('d', 8).toPosition());
        }
    }
}
