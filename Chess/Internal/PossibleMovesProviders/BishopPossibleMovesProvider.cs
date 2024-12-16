namespace Chess.Internal.PossibleMovesProviders
{
    internal class BishopPossibleMovesProvider : IPossibleMovesProvider
    {
        public IEnumerable<ISpace> GetPossibleMoves(IBoard board, ISpace? space)
        {
            var possibleMoves = new List<ISpace>();
            if (space == null || space.Piece == null)
            {
                return possibleMoves;
            }

            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, 1, 1, ref possibleMoves); // Upper Right
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, 1, -1, ref possibleMoves); // Upper Left
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, -1, 1, ref possibleMoves); // Lower Right
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, -1, -1, ref possibleMoves); // Lower Left

            return possibleMoves;
        }

        public IEnumerable<ISpace> GetPossibleTakes(IBoard board, ISpace? space)
        {
            var possibleMoves = new List<ISpace>();
            if (space == null || space.Piece == null)
            {
                return possibleMoves;
            }

            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, 1, 1, ref possibleMoves); // Upper Right
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, 1, -1, ref possibleMoves); // Upper Left
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, -1, 1, ref possibleMoves); // Lower Right
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, -1, -1, ref possibleMoves); // Lower Left

            return possibleMoves;
        }
    }
}