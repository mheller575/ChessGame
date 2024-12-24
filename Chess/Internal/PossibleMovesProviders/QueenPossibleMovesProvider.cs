namespace Chess.Internal.PossibleMovesProviders
{
    internal class QueenPossibleMovesProvider : APossibleMovesProvider
    {
        protected override void GetPossibleMovesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces)
        {
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, 1, 0, ref spaces); // Right
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, -1, 0, ref spaces); // Left
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, 0, 1, ref spaces); // Up
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, 0, -1, ref spaces); // Down
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, 1, 1, ref spaces); // Upper Right
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, 1, -1, ref spaces); // Upper Left
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, -1, 1, ref spaces); // Lower Right
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, -1, -1, ref spaces); // Lower Left
        }

        protected override void GetPossibleTakesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces)
        {
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, 1, 0, ref spaces); // Right
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, -1, 0, ref spaces); // Left
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, 0, 1, ref spaces); // Up
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, 0, -1, ref spaces); // Down
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, 1, 1, ref spaces); // Upper Right
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, 1, -1, ref spaces); // Upper Left
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, -1, 1, ref spaces); // Lower Right
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, -1, -1, ref spaces); // Lower Left
        }
    }
}