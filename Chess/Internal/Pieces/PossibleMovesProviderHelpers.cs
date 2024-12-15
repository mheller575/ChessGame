

namespace DotNetChess.Internal.Pieces
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
    }
}