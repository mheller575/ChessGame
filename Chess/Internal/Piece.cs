namespace Chess.Internal
{
    internal class Piece : IPiece
    {
        private readonly IBoard _board;
        private readonly IPossibleMovesProvider _possibleMovesProvider;

        protected Piece(IBoard board, ISpace? space, bool isWhite, bool hasMoved, PieceType pieceType, IPossibleMovesProvider possibleMovesProvider)
        {
            Space = space;
            IsWhite = isWhite;
            HasMoved = hasMoved;
            PieceType = pieceType;
            _board = board;
            _possibleMovesProvider = possibleMovesProvider;
        }

        public ISpace? Space { get; set; }

        public bool IsWhite { get; }

        public bool HasMoved { get; }

        public PieceType PieceType { get; }

        public IEnumerable<ISpace> GetPossibleMoves()
        {
            return _possibleMovesProvider.GetPossibleMoves(_board, Space);
        }

        public IEnumerable<ISpace> GetPossibleTakes()
        {
            return _possibleMovesProvider.GetPossibleTakes(_board, Space);
        }
    }
}