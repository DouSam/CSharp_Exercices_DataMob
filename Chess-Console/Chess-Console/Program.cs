﻿using Board;
using System;
using Chess;

namespace Chess_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board.Board board = new Board.Board(8, 8);

                board.PlacePiece(new Rook(Color.Black, board), new Position(0, 9));
                board.PlacePiece(new King(Color.White, board), new Position(2, 1));

                board.PlacePiece(new King(Color.White, board), new Position(2, 1));

                Screen.PrintBoard(board);
            }
            catch(BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
