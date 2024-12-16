namespace Chess.Internal.PossibleMovesProviders
{
    internal class RookPossibleMovesProvider : IPossibleMovesProvider
    {
        public IEnumerable<ISpace> GetPossibleMoves(IBoard board, ISpace? space)
        {
            if (space == null || space.Piece == null)
            {
                return [];
            }

            var possibleMoves = new List<ISpace>();

            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, 1, 0, ref possibleMoves); // Right
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, -1, 0, ref possibleMoves); // Left
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, 0, 1, ref possibleMoves); // Up
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, 0, -1, ref possibleMoves); // Down

            return possibleMoves;
        }

        public IEnumerable<ISpace> GetPossibleTakes(IBoard board, ISpace? space)
        {
            if (space == null || space.Piece == null)
            {
                return [];
            }

            var possibleMoves = new List<ISpace>();

            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, 1, 0, ref possibleMoves); // Right
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, -1, 0, ref possibleMoves); // Left
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, 0, 1, ref possibleMoves); // Up
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, 0, -1, ref possibleMoves); // Down

            return possibleMoves;
        }
    }
}