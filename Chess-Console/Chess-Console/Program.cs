using Board;
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
                Game game = new Game();

                while (!game.Finished)
                {
                    try
                    {
                        Console.Clear();
                        Screen.PrintBoard(game.Board);
                        Console.WriteLine($"Turn: {game.Turn}");
                        Console.WriteLine($"Waiting for moviment: {game.ActualPlayer}");

                        Console.WriteLine();
                        Console.Write("Origin: ");
                        Position origin = Screen.ReadPositionChess().toPosition();
                        game.ValidateOriginPosition(origin);

                        bool[,] possiblePositions = game.Board.GetPiece(origin).PossibleMoviments();

                        Console.Clear();
                        Screen.PrintBoard(game.Board, possiblePositions);

                        Console.WriteLine();
                        Console.Write("Destiny: ");
                        Position destiny = Screen.ReadPositionChess().toPosition();
                        game.ValidateDestinyPosition(origin, destiny);

                        game.MakeMoviment(origin, destiny);
                    } catch (BoardException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
