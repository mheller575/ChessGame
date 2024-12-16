namespace Chess.Internal.PossibleMovesProviders
{
    internal class RookPossibleMovesProvider : IPossibleMovesProvider
    {
        private readonly IBoard _board;

        public RookPossibleMovesProvider(IBoard board)
        {
            _board = board;
        }

        public IEnumerable<ISpace> GetPossibleMoves(ISpace? space)
        {
            if (space == null || space.Piece == null)
            {
                return [];
            }

            var possibleMoves = new List<ISpace>();

            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(_board, space, 1, 0, ref possibleMoves); // Right
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(_board, space, -1, 0, ref possibleMoves); // Left
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(_board, space, 0, 1, ref possibleMoves); // Up
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(_board, space, 0, -1, ref possibleMoves); // Down

            return possibleMoves;
        }

        public IEnumerable<ISpace> GetPossibleTakes(ISpace? space)
        {
            if (space == null || space.Piece == null)
            {
                return [];
            }

            var possibleMoves = new List<ISpace>();

            PossibleMovesProviderHelpers.FindTakeInDirection(_board, space, 1, 0, ref possibleMoves); // Right
            PossibleMovesProviderHelpers.FindTakeInDirection(_board, space, -1, 0, ref possibleMoves); // Left
            PossibleMovesProviderHelpers.FindTakeInDirection(_board, space, 0, 1, ref possibleMoves); // Up
            PossibleMovesProviderHelpers.FindTakeInDirection(_board, space, 0, -1, ref possibleMoves); // Down

            return possibleMoves;
        }
    }
}