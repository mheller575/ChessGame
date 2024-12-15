

namespace DotNetChess.Internal.Pieces
{
    internal class KnightPossibleMovesProvider : IPossibleMovesProvider
    {
        private readonly IBoard _board;

        public KnightPossibleMovesProvider(IBoard board)
        {
            _board = board;
        }

        public IEnumerable<ISpace> GetPossibleMoves(ISpace? space)
        {
            if (space == null || space.Piece == null)
            {
                return [];
            }

            var possibleMoves = new List<ISpace>();

            AddPossibleMoveIfValid(possibleMoves, space.Coordinates.X + 2, space.Coordinates.Y + 1);
            AddPossibleMoveIfValid(possibleMoves, space.Coordinates.X + 1, space.Coordinates.Y + 2);
            AddPossibleMoveIfValid(possibleMoves, space.Coordinates.X - 2, space.Coordinates.Y + 1);
            AddPossibleMoveIfValid(possibleMoves, space.Coordinates.X - 1, space.Coordinates.Y + 2);
            AddPossibleMoveIfValid(possibleMoves, space.Coordinates.X + 2, space.Coordinates.Y - 1);
            AddPossibleMoveIfValid(possibleMoves, space.Coordinates.X + 1, space.Coordinates.Y - 2);
            AddPossibleMoveIfValid(possibleMoves, space.Coordinates.X - 2, space.Coordinates.Y - 1);
            AddPossibleMoveIfValid(possibleMoves, space.Coordinates.X - 1, space.Coordinates.Y - 2);

            return possibleMoves;
        }

        private void AddPossibleMoveIfValid(List<ISpace> possibleMoves, int x, int y)
        {
            if (x >= 0 && x <= 7 && y >= 0 && y <= 7)
            {
                var otherSpace = _board.GetSpace((x, y));
                if (otherSpace.Piece == null)
                {
                    possibleMoves.Add(otherSpace);
                }
            }
        }

        public IEnumerable<ISpace> GetPossibleTakes(ISpace? space)
        {
            if (space == null || space.Piece == null)
            {
                return [];
            }

            var possibleMoves = new List<ISpace>();

            AddPossibleTakeIfValid(possibleMoves, space.Coordinates.X + 2, space.Coordinates.Y + 1, space.Piece.IsWhite);
            AddPossibleTakeIfValid(possibleMoves, space.Coordinates.X + 1, space.Coordinates.Y + 2, space.Piece.IsWhite);
            AddPossibleTakeIfValid(possibleMoves, space.Coordinates.X + 2, space.Coordinates.Y - 1, space.Piece.IsWhite);
            AddPossibleTakeIfValid(possibleMoves, space.Coordinates.X + 1, space.Coordinates.Y - 2, space.Piece.IsWhite);
            AddPossibleTakeIfValid(possibleMoves, space.Coordinates.X - 2, space.Coordinates.Y + 1, space.Piece.IsWhite);
            AddPossibleTakeIfValid(possibleMoves, space.Coordinates.X - 1, space.Coordinates.Y + 2, space.Piece.IsWhite);
            AddPossibleTakeIfValid(possibleMoves, space.Coordinates.X - 2, space.Coordinates.Y - 1, space.Piece.IsWhite);
            AddPossibleTakeIfValid(possibleMoves, space.Coordinates.X - 1, space.Coordinates.Y - 2, space.Piece.IsWhite);

            return possibleMoves;
        }

        private void AddPossibleTakeIfValid(List<ISpace> possibleMoves, int x, int y, bool isWhite)
        {
            if (x >= 0 && x <= 7 && y >= 0 && y <= 7)
            {
                var otherSpace = _board.GetSpace((x, y));
                if (otherSpace.Piece != null && otherSpace.Piece.IsWhite != isWhite)
                {
                    possibleMoves.Add(otherSpace);
                }
            }
        }
    }
}