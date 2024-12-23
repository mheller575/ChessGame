namespace Chess.Internal.PossibleMovesProviders
{
    internal static class PossibleMovesProviderHelpers
    {
        public static void GetAllSpacesToMoveTo(IBoard board, ISpace space, int xFactor, int yFactor, ref List<ISpace> possibleMoves)
        {
            var x = space.Coordinates.X + xFactor;
            var y = space.Coordinates.Y + yFactor;
            for (; x >= 0 && x <= 8 && y >= 0 && y <= 8; x += xFactor, y += yFactor)
            {
                var otherSpace = board.GetSpace((x, y));
                if (otherSpace.Piece == null)
                {
                    possibleMoves.Add(otherSpace);
                }
                else
                {
                    return;
                }
            }
        }

        public static void FindTakeInDirection(IBoard board, ISpace space, int xFactor, int yFactor, ref List<ISpace> possibleMoves)
        {
            var x = space.Coordinates.X + xFactor;
            var y = space.Coordinates.Y + yFactor;
            for (; x >= 0 && x <= 8 && y >= 0 && y <= 8; x += xFactor, y += yFactor)
            {
                var otherSpace = board.GetSpace((x, y));
                if (otherSpace.Piece != null)
                {
                    if (otherSpace.Piece.IsWhite != space.Piece.IsWhite)
                    {
                        possibleMoves.Add(otherSpace);
                    }

                    return;
                }
            }
        }

        public static void AddPossibleTakeIfValid(IBoard board, List<ISpace> possibleMoves, int x, int y, bool isWhite)
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

        public static void AddPossibleMoveIfValid(IBoard board, List<ISpace> possibleMoves, int x, int y)
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
    }
}