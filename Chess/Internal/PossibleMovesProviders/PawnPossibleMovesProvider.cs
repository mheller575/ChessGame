namespace Chess.Internal.PossibleMovesProviders
{
    internal class PawnPossibleMovesProvider : APossibleMovesProvider
    {
        #region Private Fields

        private readonly int _modifier;

        #endregion

        #region Constructor

        public PawnPossibleMovesProvider(bool upDirection)
        {
            _modifier = upDirection ? 1 : -1;
        }

        #endregion

        #region APossibleMovesProvider Implementation

        protected override void GetPossibleMovesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces)
        {
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X, space.Coordinates.Y + _modifier);

            // Special case for first move. A pawn can move 2 spaces for their first move.
            if (space.Piece.HasMoved == false)
            {
                PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X, space.Coordinates.Y + 2 * _modifier);
            }
        }

        protected override void GetPossibleTakesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces)
        {
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X - 1, space.Coordinates.Y + _modifier, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X + 1, space.Coordinates.Y + _modifier, space.Piece.IsWhite);
        }

        #endregion
    }
}