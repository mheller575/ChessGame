namespace Chess.Internal.PossibleMovesProviders
{
    internal class RookPossibleMovesProvider : APossibleMovesProvider
    {
        protected override void GetPossibleMovesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces)
        {
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, 1, 0, ref spaces); // Right
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, -1, 0, ref spaces); // Left
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, 0, 1, ref spaces); // Up
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, 0, -1, ref spaces); // Down
        }

        protected override void GetPossibleTakesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces)
        {
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, 1, 0, ref spaces); // Right
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, -1, 0, ref spaces); // Left
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, 0, 1, ref spaces); // Up
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, 0, -1, ref spaces); // Down
        }
    }
}