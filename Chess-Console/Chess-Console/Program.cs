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

                Board.Board bo = new Board.Board(8,8);

                bo.PlacePiece(new King(Color.White,bo),new Position(1,0));

                Screen.PrintBoard(bo);
            }
            catch(BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
