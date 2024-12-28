namespace Chess.Internal.PossibleMovesProviders
{
    internal class KingPossibleMovesProvider : APossibleMovesProvider
    {
        protected override void GetPossibleMovesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces)
        {
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X - 1, space.Coordinates.Y);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X - 1, space.Coordinates.Y - 1);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X - 1, space.Coordinates.Y + 1);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X, space.Coordinates.Y - 1);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X, space.Coordinates.Y + 1);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X + 1, space.Coordinates.Y);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X + 1, space.Coordinates.Y - 1);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X + 1, space.Coordinates.Y + 1);
        }

        protected override void GetPossibleTakesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces)
        {
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X - 1, space.Coordinates.Y, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X - 1, space.Coordinates.Y - 1, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X - 1, space.Coordinates.Y + 1, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X, space.Coordinates.Y - 1, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X, space.Coordinates.Y + 1, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X + 1, space.Coordinates.Y, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X + 1, space.Coordinates.Y - 1, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X + 1, space.Coordinates.Y + 1, space.Piece.IsWhite);
        }
    }
}