namespace Board
{
    abstract class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MovementCount { get; protected set; }
        public Board Board { get; set; }

        public Piece(Color color, Board board)
        {
            Position = null;
            Color = color;
            Board = board;
        }

        public void IncreaseMovement()
        {
            MovementCount++;
        }

        public void DecreaseMovement()
        {
            MovementCount--;
        }

        public abstract bool[,] PossibleMoviments();

        public bool ExistsMoviments()
        {
            bool[,] mat = PossibleMoviments();
            for (int i = 0; i < Board.Lines; i++)
            {
                for (int j = 0; j < Board.Columns; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool CanMoveToDestiny(Position pos)
        {
            return PossibleMoviments()[pos.Line, pos.Column];
        }
        protected bool CanMoveTo(Position pos)
        {
            Piece p = Board.GetPiece(pos);
            return p == null || p.Color != Color;
        }
    }
}
