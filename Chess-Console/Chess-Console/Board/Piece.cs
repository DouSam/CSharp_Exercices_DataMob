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

        public virtual bool[,] PossibleMoviments() {
            return new bool[1,1];
        }

        protected bool CanMoveTo(Position pos)
        {
            Piece p = Board.GetPiece(pos);
            return p == null || p.Color != Color;
        }
    }
}
