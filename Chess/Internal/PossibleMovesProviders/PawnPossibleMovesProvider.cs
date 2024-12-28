namespace Chess.Internal.PossibleMovesProviders
{
    internal class PawnPossibleMovesProvider : APossibleMovesProvider
    {
        #region APossibleMovesProvider Implementation

        protected override void GetPossibleMovesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces)
        {
            var modifier = GetModifier(space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X, space.Coordinates.Y + modifier);

            // Special case for first move. A pawn can move 2 spaces for their first move.
            if (space.Piece.HasMoved == false)
            {
                PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X, space.Coordinates.Y + 2 * modifier);
            }
        }

        protected override void GetPossibleTakesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces)
        {
            var modifier = GetModifier(space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X - 1, space.Coordinates.Y + modifier, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X + 1, space.Coordinates.Y + modifier, space.Piece.IsWhite);
        }

        #endregion

        #region Private Methods

        private static int GetModifier(bool isWhite)
        {
            return isWhite ? 1 : -1;
        }

        #endregion
    }
}