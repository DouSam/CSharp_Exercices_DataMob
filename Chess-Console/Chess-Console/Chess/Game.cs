using System;
using System.Collections.Generic;
using Board;

namespace Chess
{
    class Game
    {
        public Board.Board Board { get; private set; }
        public int Turn { get; private set; }
        public Color ActualPlayer { get; private set; }
        public bool Finished { get; private set; }
        private HashSet<Piece> _pieces;
        private HashSet<Piece> _capturedPieces;
        public bool Checkmate { get; private set; }

        public Game()
        {
            Board = new Board.Board(8, 8);
            Turn = 1;
            ActualPlayer = Color.White;
            Finished = false;
            Checkmate = false;
            _pieces = new HashSet<Piece>();
            _capturedPieces = new HashSet<Piece>();
            placePieces();
        }

        public Piece Moviment(Position origin, Position destiny)
        {
            Piece piece = Board.RemovePiece(origin);
            piece.IncreaseMovement();
            Piece pieceCaptured = Board.RemovePiece(destiny);
            Board.PlacePiece(piece, destiny);
            if (pieceCaptured != null)
            {
                _capturedPieces.Add(pieceCaptured);
            }

            return pieceCaptured;
        }

        public void UndoMoviment(Position origin, Position destiny, Piece capturedPiece)
        {
            Piece p = Board.RemovePiece(destiny);
            p.DecreaseMovement();
            if (capturedPiece != null)
            {
                Board.PlacePiece(capturedPiece, destiny);
                _capturedPieces.Remove(capturedPiece);
            }
            Board.PlacePiece(p, origin);
        }

        public void MakeMoviment(Position origin, Position destiny)
        {
            Piece capturedPiece = Moviment(origin, destiny);

            if (IsCheck(ActualPlayer))
            {
                UndoMoviment(origin, destiny, capturedPiece);
                throw new BoardException("Making this movement will put you in check.");
            }

            if (IsCheck(Opponent(ActualPlayer)))
            {
                Checkmate = true;
            }
            else
            {
                Checkmate = false;
            }

            if (IsCheckmate(Opponent(ActualPlayer)))
            {
                Finished = true;
            }
            else
            {
                Turn++;
                ChangePlayer();
            }
        }

        public void ValidateOriginPosition(Position origin)
        {
            Piece piece = Board.GetPiece(origin);
            if (piece == null)
            {
                throw new BoardException("Doesn't exist a piece in the selected position.");
            }
            if (ActualPlayer != piece.Color)
            {
                throw new BoardException("This piece is not yours!");
            }
            if (!piece.ExistsMoviments())
            {
                throw new BoardException("This piece doesn't have movements to do.");
            }
        }

        public void ValidateDestinyPosition(Position origin, Position destiny)
        {
            if (!Board.GetPiece(origin).CanMoveToDestiny(destiny))
            {
                throw new BoardException("Destiny position invalid.");
            }
        }
        private void ChangePlayer()
        {
            ActualPlayer = ActualPlayer == Color.White ? Color.Black : Color.White;
        }

        public HashSet<Piece> GetCapturedPieces (Color color)
        {
            HashSet<Piece> aux = new HashSet<Piece>();
            foreach (Piece piece in _capturedPieces)
            {
                if(piece.Color == color)
                {
                    aux.Add(piece);
                }
            }

            return aux;
        }

        public HashSet<Piece> GetPiecesInGame (Color color)
        {
            HashSet<Piece> aux = new HashSet<Piece>();
            foreach (Piece piece in _pieces)
            {
                if (piece.Color == color)
                {
                    aux.Add(piece);
                }
            }

            aux.ExceptWith(GetCapturedPieces(color));

            return aux;
        }

        private Color Opponent(Color color)
        {
            if (color == Color.White)
            {
                return Color.Black;
            }
            else
            {
                return Color.White;
            }
        }

        private Piece GetKing(Color color)
        {
            foreach (Piece x in GetPiecesInGame(color))
            {
                if (x is King)
                {
                    return x;
                }
            }
            return null;
        }

        public bool IsCheck(Color color)
        {
            Piece K = GetKing(color);
            if (K == null)
            {
                throw new BoardException("The board doesn't have a king.");
            }
            foreach (Piece x in GetPiecesInGame(Opponent(color)))
            {
                bool[,] mat = x.PossibleMoviments();
                if (mat[K.Position.Line, K.Position.Column])
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsCheckmate(Color color)
        {
            if (!IsCheck(color))
            {
                return false;
            }
            foreach (Piece x in GetPiecesInGame(color))
            {
                bool[,] mat = x.PossibleMoviments();
                for (int i = 0; i < Board.Lines; i++)
                {
                    for (int j = 0; j < Board.Columns; j++)
                    {
                        if (mat[i, j])
                        {
                            Position origin = x.Position;
                            Position destiny = new Position(i, j);
                            Piece capturedPiece = Moviment(origin, destiny);
                            bool testeXeque = IsCheck(color);
                            UndoMoviment(origin, destiny, capturedPiece);
                            if (!testeXeque)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        public void PlaceNewPiece(Piece piece, char column, int line)
        {
            Board.PlacePiece(piece, new PositionChess(column, line).toPosition());
            _pieces.Add(piece);
        }
        private void placePieces()
        {
            char[] Letters = new char[8] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            // White
            PlaceNewPiece(new Rook(Color.White, Board), 'a', 1);
            PlaceNewPiece(new Knight(Color.White, Board), 'b', 1);
            PlaceNewPiece(new Bishop(Color.White, Board), 'c', 1);
            PlaceNewPiece(new Queen(Color.White, Board), 'd', 1);
            PlaceNewPiece(new King(Color.White, Board), 'e', 1);
            PlaceNewPiece(new Bishop(Color.White, Board), 'f', 1);
            PlaceNewPiece(new Knight(Color.White, Board), 'g', 1);
            PlaceNewPiece(new Rook(Color.White, Board), 'h', 1);

            for (int i = 0; i < Letters.Length; i++)
            {
                PlaceNewPiece(new Pawn(Color.White, Board), Letters[i], 2);
            }

            // Black
            PlaceNewPiece(new Rook(Color.Black, Board), 'a', 8);
            PlaceNewPiece(new Knight(Color.Black, Board), 'b', 8);
            PlaceNewPiece(new Bishop(Color.Black, Board), 'c', 8);
            PlaceNewPiece(new Queen(Color.Black, Board), 'd', 8);
            PlaceNewPiece(new King(Color.Black, Board), 'e', 8);
            PlaceNewPiece(new Bishop(Color.Black, Board), 'f', 8);
            PlaceNewPiece(new Knight(Color.Black, Board), 'g', 8);
            PlaceNewPiece(new Rook(Color.Black, Board), 'h', 8);

            for (int i = 0; i < Letters.Length; i++)
            {
                PlaceNewPiece(new Pawn(Color.Black, Board), Letters[i], 7);
            }
        }
    }
}
