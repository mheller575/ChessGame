namespace Chess.Internal.PossibleMovesProviders
{
    internal class QueenPossibleMovesProvider : IPossibleMovesProvider
    {
        private readonly IBoard _board;

        public QueenPossibleMovesProvider(IBoard board)
        {
            _board = board;
        }

        public IEnumerable<ISpace> GetPossibleMoves(ISpace? space)
        {
            var possibleMoves = new List<ISpace>();
            if (space == null || space.Piece == null)
            {
                return possibleMoves;
            }

            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(_board, space, 1, 0, ref possibleMoves); // Right
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(_board, space, -1, 0, ref possibleMoves); // Left
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(_board, space, 0, 1, ref possibleMoves); // Up
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(_board, space, 0, -1, ref possibleMoves); // Down
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(_board, space, 1, 1, ref possibleMoves); // Upper Right
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(_board, space, 1, -1, ref possibleMoves); // Upper Left
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(_board, space, -1, 1, ref possibleMoves); // Lower Right
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(_board, space, -1, -1, ref possibleMoves); // Lower Left

            return possibleMoves;
        }

        public IEnumerable<ISpace> GetPossibleTakes(ISpace? space)
        {
            var possibleMoves = new List<ISpace>();
            if (space == null || space.Piece == null)
            {
                return possibleMoves;
            }

            PossibleMovesProviderHelpers.FindTakeInDirection(_board, space, 1, 0, ref possibleMoves); // Right
            PossibleMovesProviderHelpers.FindTakeInDirection(_board, space, -1, 0, ref possibleMoves); // Left
            PossibleMovesProviderHelpers.FindTakeInDirection(_board, space, 0, 1, ref possibleMoves); // Up
            PossibleMovesProviderHelpers.FindTakeInDirection(_board, space, 0, -1, ref possibleMoves); // Down
            PossibleMovesProviderHelpers.FindTakeInDirection(_board, space, 1, 1, ref possibleMoves); // Upper Right
            PossibleMovesProviderHelpers.FindTakeInDirection(_board, space, 1, -1, ref possibleMoves); // Upper Left
            PossibleMovesProviderHelpers.FindTakeInDirection(_board, space, -1, 1, ref possibleMoves); // Lower Right
            PossibleMovesProviderHelpers.FindTakeInDirection(_board, space, -1, -1, ref possibleMoves); // Lower Left

            return possibleMoves;
        }
    }
}