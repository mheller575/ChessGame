namespace Chess.Internal
{
    internal class Piece : IPiece
    {
        #region Private Fields

        private readonly IPossibleMovesProvider _possibleMovesProvider;

        #endregion

        #region Constructor

        public Piece(ISpace? space, bool isWhite, bool hasMoved, PieceType pieceType, IPossibleMovesProvider possibleMovesProvider)
        {
            Space = space;
            IsWhite = isWhite;
            HasMoved = hasMoved;
            PieceType = pieceType;
            _possibleMovesProvider = possibleMovesProvider;
        }

        #endregion

        #region IPiece Implementation

        public ISpace? Space { get; set; }

        public bool IsWhite { get; }

        public bool HasMoved { get; }

        public PieceType PieceType { get; }

        public IEnumerable<ISpace> GetPossibleMoves(IBoard board)
        {
            return _possibleMovesProvider.GetPossibleMoves(board, Space);
        }

        public IEnumerable<ISpace> GetPossibleTakes(IBoard board)
        {
            return _possibleMovesProvider.GetPossibleTakes(board, Space);
        }

        #endregion
    }
}