namespace Chess.Internal.PossibleMovesProviders
{
    internal class KnightPossibleMovesProvider : APossibleMovesProvider
    {
        protected override void GetPossibleMovesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces)
        {
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X + 2, space.Coordinates.Y + 1);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X + 1, space.Coordinates.Y + 2);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X - 2, space.Coordinates.Y + 1);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X - 1, space.Coordinates.Y + 2);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X + 2, space.Coordinates.Y - 1);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X + 1, space.Coordinates.Y - 2);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X - 2, space.Coordinates.Y - 1);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, spaces, space.Coordinates.X - 1, space.Coordinates.Y - 2);
        }

        protected override void GetPossibleTakesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces)
        {
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X + 2, space.Coordinates.Y + 1, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X + 1, space.Coordinates.Y + 2, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X + 2, space.Coordinates.Y - 1, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X + 1, space.Coordinates.Y - 2, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X - 2, space.Coordinates.Y + 1, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X - 1, space.Coordinates.Y + 2, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X - 2, space.Coordinates.Y - 1, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, spaces, space.Coordinates.X - 1, space.Coordinates.Y - 2, space.Piece.IsWhite);
        }
    }
}