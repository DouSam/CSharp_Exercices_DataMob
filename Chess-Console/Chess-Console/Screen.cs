using System;
using System.Collections.Generic;
using Board;
using Chess;

namespace Chess_Console
{
    class Screen
    {
        public static void PrintMatch(Game match)
        {
            PrintBoard(match.Board);
            Console.WriteLine();
            PrintCapturedPieces(match);
            Console.WriteLine();
            Console.WriteLine("Turn: " + match.Turn);
            if (!match.Finished)
            {
                Console.WriteLine("Waiting player: " + match.ActualPlayer);
                if (match.Checkmate)
                {
                    Console.WriteLine("CHECK!");
                }
            }
            else
            {
                Console.WriteLine("CHECKMATE!");
                Console.WriteLine("WINNER!!: " + match.ActualPlayer);
            }
        }

        public static void PrintCapturedPieces(Game match)
        {
            Console.WriteLine("Captured pieces:");
            Console.Write("White: ");
            PrintSet(match.GetCapturedPieces(Color.White));
            Console.WriteLine();
            Console.Write("Black: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintSet(match.GetCapturedPieces(Color.Black));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }

        public static void PrintSet(HashSet<Piece> set)
        {
            Console.Write("[");
            foreach (Piece piece in set)
            {
                Console.Write(piece + " ");
            }
            Console.Write("]");
        }
        public static void PrintBoard(Board.Board board)
        {
            for (int i = 0; i < board.Lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.Columns; j++)
                {
                    PrintPiece(board.GetPiece(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine($"  a b c d e f g h");
        }

        public static void PrintBoard(Board.Board board, bool[,] possiblePositions)
        {

            ConsoleColor OriginalBackground = Console.BackgroundColor;
            ConsoleColor GrayBackground = ConsoleColor.DarkGray;

            for (int i = 0; i < board.Lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.Columns; j++)
                {
                    if (possiblePositions[i, j])
                    {
                        Console.BackgroundColor = GrayBackground;
                    }
                    else
                    {
                        Console.BackgroundColor = OriginalBackground;
                    }
                    PrintPiece(board.GetPiece(i, j));
                    Console.BackgroundColor = OriginalBackground;
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n  a b c d e f g h");
            Console.BackgroundColor = OriginalBackground;
        }

        public static PositionChess ReadPositionChess()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PositionChess(coluna, linha);
        }

        public static void PrintPiece(Piece piece)
        {
            if(piece == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (piece.Color == Color.White)
                {
                    Console.Write(piece);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(piece);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}
