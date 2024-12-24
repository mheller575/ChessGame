namespace Chess.Internal.PossibleMovesProviders
{
    internal class BishopPossibleMovesProvider : APossibleMovesProvider
    {
        #region APossibleMovesProvider Implementation

        protected override void GetPossibleMovesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces)
        {
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, 1, 1, ref spaces); // Upper Right
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, 1, -1, ref spaces); // Upper Left
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, -1, 1, ref spaces); // Lower Right
            PossibleMovesProviderHelpers.GetAllSpacesToMoveTo(board, space, -1, -1, ref spaces); // Lower Left
        }

        protected override void GetPossibleTakesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces)
        {
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, 1, 1, ref spaces); // Upper Right
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, 1, -1, ref spaces); // Upper Left
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, -1, 1, ref spaces); // Lower Right
            PossibleMovesProviderHelpers.FindTakeInDirection(board, space, -1, -1, ref spaces); // Lower Left
        }

        #endregion
    }
}