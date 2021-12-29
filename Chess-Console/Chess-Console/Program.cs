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

                PositionChess pos = new PositionChess('a', 1);

                Console.WriteLine(pos);

                Console.WriteLine(pos.toPosition());
            }
            catch(BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
