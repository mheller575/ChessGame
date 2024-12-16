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

            AddPossibleMoveIfValid(board, possibleMoves, space.Coordinates.X + 2, space.Coordinates.Y + 1);
            AddPossibleMoveIfValid(board, possibleMoves, space.Coordinates.X + 1, space.Coordinates.Y + 2);
            AddPossibleMoveIfValid(board, possibleMoves, space.Coordinates.X - 2, space.Coordinates.Y + 1);
            AddPossibleMoveIfValid(board, possibleMoves, space.Coordinates.X - 1, space.Coordinates.Y + 2);
            AddPossibleMoveIfValid(board, possibleMoves, space.Coordinates.X + 2, space.Coordinates.Y - 1);
            AddPossibleMoveIfValid(board, possibleMoves, space.Coordinates.X + 1, space.Coordinates.Y - 2);
            AddPossibleMoveIfValid(board, possibleMoves, space.Coordinates.X - 2, space.Coordinates.Y - 1);
            AddPossibleMoveIfValid(board, possibleMoves, space.Coordinates.X - 1, space.Coordinates.Y - 2);

            return possibleMoves;
        }

        private void AddPossibleMoveIfValid(IBoard board, List<ISpace> possibleMoves, int x, int y)
        {
            if (x >= 0 && x <= 7 && y >= 0 && y <= 7)
            {
                var otherSpace = board.GetSpace((x, y));
                if (otherSpace.Piece == null)
                {
                    possibleMoves.Add(otherSpace);
                }
            }
        }

        public IEnumerable<ISpace> GetPossibleTakes(IBoard board, ISpace? space)
        {
            if (space == null || space.Piece == null)
            {
                return [];
            }

            var possibleMoves = new List<ISpace>();

            AddPossibleTakeIfValid(board, possibleMoves, space.Coordinates.X + 2, space.Coordinates.Y + 1, space.Piece.IsWhite);
            AddPossibleTakeIfValid(board, possibleMoves, space.Coordinates.X + 1, space.Coordinates.Y + 2, space.Piece.IsWhite);
            AddPossibleTakeIfValid(board, possibleMoves, space.Coordinates.X + 2, space.Coordinates.Y - 1, space.Piece.IsWhite);
            AddPossibleTakeIfValid(board, possibleMoves, space.Coordinates.X + 1, space.Coordinates.Y - 2, space.Piece.IsWhite);
            AddPossibleTakeIfValid(board, possibleMoves, space.Coordinates.X - 2, space.Coordinates.Y + 1, space.Piece.IsWhite);
            AddPossibleTakeIfValid(board, possibleMoves, space.Coordinates.X - 1, space.Coordinates.Y + 2, space.Piece.IsWhite);
            AddPossibleTakeIfValid(board, possibleMoves, space.Coordinates.X - 2, space.Coordinates.Y - 1, space.Piece.IsWhite);
            AddPossibleTakeIfValid(board, possibleMoves, space.Coordinates.X - 1, space.Coordinates.Y - 2, space.Piece.IsWhite);

            return possibleMoves;
        }

        private void AddPossibleTakeIfValid(IBoard board, List<ISpace> possibleMoves, int x, int y, bool isWhite)
        {
            if (x >= 0 && x <= 7 && y >= 0 && y <= 7)
            {
                var otherSpace = board.GetSpace((x, y));
                if (otherSpace.Piece != null && otherSpace.Piece.IsWhite != isWhite)
                {
                    possibleMoves.Add(otherSpace);
                }
            }
        }
    }
}