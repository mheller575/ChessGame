namespace Chess.Internal.PossibleMovesProviders
{
    internal class KnightPossibleMovesProvider : IPossibleMovesProvider
    {
        public IEnumerable<ISpace> GetPossibleMoves(IBoard board, ISpace? space)
        {
            if (space == null || space.Piece == null)
            {
                return [];
            }

            var possibleMoves = new List<ISpace>();

            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, possibleMoves, space.Coordinates.X + 2, space.Coordinates.Y + 1);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, possibleMoves, space.Coordinates.X + 1, space.Coordinates.Y + 2);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, possibleMoves, space.Coordinates.X - 2, space.Coordinates.Y + 1);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, possibleMoves, space.Coordinates.X - 1, space.Coordinates.Y + 2);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, possibleMoves, space.Coordinates.X + 2, space.Coordinates.Y - 1);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, possibleMoves, space.Coordinates.X + 1, space.Coordinates.Y - 2);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, possibleMoves, space.Coordinates.X - 2, space.Coordinates.Y - 1);
            PossibleMovesProviderHelpers.AddPossibleMoveIfValid(board, possibleMoves, space.Coordinates.X - 1, space.Coordinates.Y - 2);

            return possibleMoves;
        }

        public IEnumerable<ISpace> GetPossibleTakes(IBoard board, ISpace? space)
        {
            if (space == null || space.Piece == null)
            {
                return [];
            }

            var possibleMoves = new List<ISpace>();

            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, possibleMoves, space.Coordinates.X + 2, space.Coordinates.Y + 1, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, possibleMoves, space.Coordinates.X + 1, space.Coordinates.Y + 2, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, possibleMoves, space.Coordinates.X + 2, space.Coordinates.Y - 1, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, possibleMoves, space.Coordinates.X + 1, space.Coordinates.Y - 2, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, possibleMoves, space.Coordinates.X - 2, space.Coordinates.Y + 1, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, possibleMoves, space.Coordinates.X - 1, space.Coordinates.Y + 2, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, possibleMoves, space.Coordinates.X - 2, space.Coordinates.Y - 1, space.Piece.IsWhite);
            PossibleMovesProviderHelpers.AddPossibleTakeIfValid(board, possibleMoves, space.Coordinates.X - 1, space.Coordinates.Y - 2, space.Piece.IsWhite);

            return possibleMoves;
        }
    }
}