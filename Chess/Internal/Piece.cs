namespace Chess.Internal
{
    internal class Piece : IPiece
    {
        private readonly IPossibleMovesProvider _possibleMovesProvider;

        protected Piece(ISpace? space, bool isWhite, bool hasMoved, PieceType pieceType, IPossibleMovesProvider possibleMovesProvider)
        {
            Space = space;
            IsWhite = isWhite;
            HasMoved = hasMoved;
            PieceType = pieceType;
            _possibleMovesProvider = possibleMovesProvider;
        }

        public ISpace? Space { get; set; }

        public bool IsWhite { get; }

        public bool HasMoved { get; }

        public PieceType PieceType { get; }

        public IEnumerable<ISpace> GetPossibleMoves()
        {
            return _possibleMovesProvider.GetPossibleMoves(Space);
        }

        public IEnumerable<ISpace> GetPossibleTakes()
        {
            return _possibleMovesProvider.GetPossibleTakes(Space);
        }
    }
}