

namespace DotNetChess.Internal.Pieces
{
    internal class KingPossibleMovesProvider : IPossibleMovesProvider
    {
        private readonly IBoard _board;

        public KingPossibleMovesProvider(IBoard board)
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

            var coordinates = space.Coordinates;
            var hasSpaceAbove = coordinates.Y < 7;
            var hasSpaceBelow = coordinates.Y > 0;
            var hasSpaceLeft = coordinates.X > 0;
            var hasSpaceRight = coordinates.X < 7;

            if (hasSpaceLeft)
            {
                {
                    var otherSpace = _board.GetSpace((coordinates.X - 1, coordinates.Y));
                    if (otherSpace.Piece == null && !DoesSpacePutInCheck(space.Piece, otherSpace))
                    {
                        possibleMoves.Add(otherSpace);
                    }
                }
                

                if (hasSpaceBelow)
                {
                    var otherSpace = _board.GetSpace((coordinates.X - 1, coordinates.Y - 1));
                    if (otherSpace.Piece == null && !DoesSpacePutInCheck(space.Piece, otherSpace))
                    {
                        possibleMoves.Add(otherSpace);
                    }
                }

                if (hasSpaceAbove)
                {
                    var otherSpace = _board.GetSpace((coordinates.X - 1, coordinates.Y + 1));
                    if (otherSpace.Piece == null && !DoesSpacePutInCheck(space.Piece, otherSpace))
                    {
                        possibleMoves.Add(otherSpace);
                    }
                }
            }

            if (hasSpaceRight)
            {
                {
                    var otherSpace = _board.GetSpace((coordinates.X + 1, coordinates.Y));
                    if (otherSpace.Piece == null && !DoesSpacePutInCheck(space.Piece, otherSpace))
                    {
                        possibleMoves.Add(otherSpace);
                    }
                }
                
                if (hasSpaceBelow)
                {
                    var otherSpace = _board.GetSpace((coordinates.X + 1, coordinates.Y - 1));
                    if (otherSpace.Piece == null && !DoesSpacePutInCheck(space.Piece, otherSpace))
                    {
                        possibleMoves.Add(otherSpace);
                    }
                }

                if (hasSpaceAbove)
                {
                    var otherSpace = _board.GetSpace((coordinates.X + 1, coordinates.Y + 1));
                    if (otherSpace.Piece == null && !DoesSpacePutInCheck(space.Piece, otherSpace))
                    {
                        possibleMoves.Add(otherSpace);
                    }
                }
            }

            if (hasSpaceAbove)
            {
                var otherSpace = _board.GetSpace((coordinates.X, coordinates.Y + 1));
                if (otherSpace.Piece == null && !DoesSpacePutInCheck(space.Piece, otherSpace))
                {
                    possibleMoves.Add(otherSpace);
                }
            }

            if (hasSpaceBelow)
            {
                var otherSpace = _board.GetSpace((coordinates.X, coordinates.Y - 1));
                if (otherSpace.Piece == null && !DoesSpacePutInCheck(space.Piece, otherSpace))
                {
                    possibleMoves.Add(otherSpace);
                }
            }

            return possibleMoves;
        }

        public IEnumerable<ISpace> GetPossibleTakes(ISpace? space)
        {
            if (space == null || space.Piece == null)
            {
                return [];
            }

            var possibleMoves = new List<ISpace>();

            var coordinates = space.Coordinates;

            var hasSpaceAbove = coordinates.Y < 7;
            var hasSpaceBelow = coordinates.Y > 0;
            var hasSpaceLeft = coordinates.X > 0;
            var hasSpaceRight = coordinates.X < 7;

            if (hasSpaceLeft)
            {
                {
                    var otherSpace = _board.GetSpace((coordinates.X - 1, coordinates.Y));
                    if (otherSpace.Piece != null && otherSpace.Piece.IsWhite != space.Piece.IsWhite && !DoesSpacePutInCheck(space.Piece, otherSpace))
                    {
                        possibleMoves.Add(otherSpace);
                    }
                }

                if (hasSpaceBelow)
                {
                    var otherSpace = _board.GetSpace((coordinates.X - 1, coordinates.Y - 1));
                    if (otherSpace.Piece != null && otherSpace.Piece.IsWhite != space.Piece.IsWhite && !DoesSpacePutInCheck(space.Piece, otherSpace))
                    {
                        possibleMoves.Add(otherSpace);
                    }
                }

                if (hasSpaceAbove)
                {
                    var otherSpace = _board.GetSpace((coordinates.X - 1, coordinates.Y + 1));
                    if (otherSpace.Piece != null && otherSpace.Piece.IsWhite != space.Piece.IsWhite && !DoesSpacePutInCheck(space.Piece, otherSpace))
                    {
                        possibleMoves.Add(otherSpace);
                    }
                }
            }

            if (hasSpaceRight)
            {
                {
                    var otherSpace = _board.GetSpace((coordinates.X + 1, coordinates.Y));
                    if (otherSpace.Piece != null && otherSpace.Piece.IsWhite != space.Piece.IsWhite && !DoesSpacePutInCheck(space.Piece, otherSpace))
                    {
                        possibleMoves.Add(otherSpace);
                    }
                }

                if (hasSpaceBelow)
                {
                    var otherSpace = _board.GetSpace((coordinates.X + 1, coordinates.Y - 1));
                    if (otherSpace.Piece != null && otherSpace.Piece.IsWhite != space.Piece.IsWhite && !DoesSpacePutInCheck(space.Piece, otherSpace))
                    {
                        possibleMoves.Add(otherSpace);
                    }
                }

                if (hasSpaceAbove)
                {
                    var otherSpace = _board.GetSpace((coordinates.X + 1, coordinates.Y + 1));
                    if (otherSpace.Piece != null && otherSpace.Piece.IsWhite != space.Piece.IsWhite && !DoesSpacePutInCheck(space.Piece, otherSpace))
                    {
                        possibleMoves.Add(otherSpace);
                    }
                }
            }

            if (hasSpaceAbove)
            {
                var otherSpace = _board.GetSpace((coordinates.X, coordinates.Y + 1));
                if (otherSpace.Piece != null && otherSpace.Piece.IsWhite != space.Piece.IsWhite && !DoesSpacePutInCheck(space.Piece, otherSpace))
                {
                    possibleMoves.Add(otherSpace);
                }
            }

            if (hasSpaceBelow)
            {
                var otherSpace = _board.GetSpace((coordinates.X, coordinates.Y - 1));
                if (otherSpace.Piece != null && otherSpace.Piece.IsWhite != space.Piece.IsWhite && !DoesSpacePutInCheck(space.Piece, otherSpace))
                {
                    possibleMoves.Add(otherSpace);
                }
            }

            return possibleMoves;
        }

        private bool DoesSpacePutInCheck(IPiece king, ISpace space)
        {
            // Temporarily move the king to the space so we can check if it puts the king in check. 
            // This means we only have to check the possible takes. 
            var tempSpace = king.Space;
            king.Space = space;

            foreach (var otherPiece in _board.Pieces)
            {
                // If different color and not taken.
                if (otherPiece.IsWhite != king.IsWhite && otherPiece.Space != null)
                {
                    foreach (var possibleMove in otherPiece.GetPossibleTakes())
                    {
                        if (possibleMove == space)
                        {
                            king.Space = tempSpace;
                            return true;
                        }
                    }
                }
            }

            king.Space = tempSpace;
            return false;
        }
    }
}
