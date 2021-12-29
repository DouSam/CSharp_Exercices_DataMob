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

                    Console.Clear();
                    Screen.PrintBoard(game.Board);

                    Console.WriteLine();
                    Console.Write("Origin: ");
                    Position origin = Screen.ReadPositionChess().toPosition();

                    bool[,] possiblePositions = game.Board.GetPiece(origin).PossibleMoviments();

                    Console.Clear();
                    Screen.PrintBoard(game.Board, possiblePositions);

                    Console.WriteLine();
                    Console.Write("Destiny: ");
                    Position destiny = Screen.ReadPositionChess().toPosition();

                    game.Moviment(origin,destiny);
                }

            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
