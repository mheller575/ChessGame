namespace Chess.Internal.PossibleMovesProviders
{
    internal class KingPossibleMovesProvider : APossibleMovesProvider
    {
        protected override void GetPossibleMovesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces)
        {
            var coordinates = space.Coordinates;
            var hasSpaceAbove = coordinates.Y < 7;
            var hasSpaceBelow = coordinates.Y > 0;
            var hasSpaceLeft = coordinates.X > 0;
            var hasSpaceRight = coordinates.X < 7;

            if (hasSpaceLeft)
            {
                {
                    var otherSpace = board.GetSpace((coordinates.X - 1, coordinates.Y));
                    if (otherSpace.Piece == null && !DoesSpacePutInCheck(board, space.Piece, otherSpace))
                    {
                        spaces.Add(otherSpace);
                    }
                }


                if (hasSpaceBelow)
                {
                    var otherSpace = board.GetSpace((coordinates.X - 1, coordinates.Y - 1));
                    if (otherSpace.Piece == null && !DoesSpacePutInCheck(board, space.Piece, otherSpace))
                    {
                        spaces.Add(otherSpace);
                    }
                }

                if (hasSpaceAbove)
                {
                    var otherSpace = board.GetSpace((coordinates.X - 1, coordinates.Y + 1));
                    if (otherSpace.Piece == null && !DoesSpacePutInCheck(board, space.Piece, otherSpace))
                    {
                        spaces.Add(otherSpace);
                    }
                }
            }

            if (hasSpaceRight)
            {
                {
                    var otherSpace = board.GetSpace((coordinates.X + 1, coordinates.Y));
                    if (otherSpace.Piece == null && !DoesSpacePutInCheck(board, space.Piece, otherSpace))
                    {
                        spaces.Add(otherSpace);
                    }
                }

                if (hasSpaceBelow)
                {
                    var otherSpace = board.GetSpace((coordinates.X + 1, coordinates.Y - 1));
                    if (otherSpace.Piece == null && !DoesSpacePutInCheck(board, space.Piece, otherSpace))
                    {
                        spaces.Add(otherSpace);
                    }
                }

                if (hasSpaceAbove)
                {
                    var otherSpace = board.GetSpace((coordinates.X + 1, coordinates.Y + 1));
                    if (otherSpace.Piece == null && !DoesSpacePutInCheck(board, space.Piece, otherSpace))
                    {
                        spaces.Add(otherSpace);
                    }
                }
            }

            if (hasSpaceAbove)
            {
                var otherSpace = board.GetSpace((coordinates.X, coordinates.Y + 1));
                if (otherSpace.Piece == null && !DoesSpacePutInCheck(board, space.Piece, otherSpace))
                {
                    spaces.Add(otherSpace);
                }
            }

            if (hasSpaceBelow)
            {
                var otherSpace = board.GetSpace((coordinates.X, coordinates.Y - 1));
                if (otherSpace.Piece == null && !DoesSpacePutInCheck(board, space.Piece, otherSpace))
                {
                    spaces.Add(otherSpace);
                }
            }
        }

        protected override void GetPossibleTakesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces)
        {
            var coordinates = space.Coordinates;

            var hasSpaceAbove = coordinates.Y < 7;
            var hasSpaceBelow = coordinates.Y > 0;
            var hasSpaceLeft = coordinates.X > 0;
            var hasSpaceRight = coordinates.X < 7;

            if (hasSpaceLeft)
            {
                {
                    var otherSpace = board.GetSpace((coordinates.X - 1, coordinates.Y));
                    if (otherSpace.Piece != null && otherSpace.Piece.IsWhite != space.Piece.IsWhite && !DoesSpacePutInCheck(board, space.Piece, otherSpace))
                    {
                        spaces.Add(otherSpace);
                    }
                }

                if (hasSpaceBelow)
                {
                    var otherSpace = board.GetSpace((coordinates.X - 1, coordinates.Y - 1));
                    if (otherSpace.Piece != null && otherSpace.Piece.IsWhite != space.Piece.IsWhite && !DoesSpacePutInCheck(board, space.Piece, otherSpace))
                    {
                        spaces.Add(otherSpace);
                    }
                }

                if (hasSpaceAbove)
                {
                    var otherSpace = board.GetSpace((coordinates.X - 1, coordinates.Y + 1));
                    if (otherSpace.Piece != null && otherSpace.Piece.IsWhite != space.Piece.IsWhite && !DoesSpacePutInCheck(board, space.Piece, otherSpace))
                    {
                        spaces.Add(otherSpace);
                    }
                }
            }

            if (hasSpaceRight)
            {
                {
                    var otherSpace = board.GetSpace((coordinates.X + 1, coordinates.Y));
                    if (otherSpace.Piece != null && otherSpace.Piece.IsWhite != space.Piece.IsWhite && !DoesSpacePutInCheck(board, space.Piece, otherSpace))
                    {
                        spaces.Add(otherSpace);
                    }
                }

                if (hasSpaceBelow)
                {
                    var otherSpace = board.GetSpace((coordinates.X + 1, coordinates.Y - 1));
                    if (otherSpace.Piece != null && otherSpace.Piece.IsWhite != space.Piece.IsWhite && !DoesSpacePutInCheck(board, space.Piece, otherSpace))
                    {
                        spaces.Add(otherSpace);
                    }
                }

                if (hasSpaceAbove)
                {
                    var otherSpace = board.GetSpace((coordinates.X + 1, coordinates.Y + 1));
                    if (otherSpace.Piece != null && otherSpace.Piece.IsWhite != space.Piece.IsWhite && !DoesSpacePutInCheck(board, space.Piece, otherSpace))
                    {
                        spaces.Add(otherSpace);
                    }
                }
            }

            if (hasSpaceAbove)
            {
                var otherSpace = board.GetSpace((coordinates.X, coordinates.Y + 1));
                if (otherSpace.Piece != null && otherSpace.Piece.IsWhite != space.Piece.IsWhite && !DoesSpacePutInCheck(board, space.Piece, otherSpace))
                {
                    spaces.Add(otherSpace);
                }
            }

            if (hasSpaceBelow)
            {
                var otherSpace = board.GetSpace((coordinates.X, coordinates.Y - 1));
                if (otherSpace.Piece != null && otherSpace.Piece.IsWhite != space.Piece.IsWhite && !DoesSpacePutInCheck(board, space.Piece, otherSpace))
                {
                    spaces.Add(otherSpace);
                }
            }
        }

        private static bool DoesSpacePutInCheck(IBoard board, IPiece king, ISpace space)
        {
            // Temporarily move the king to the space so we can check if it puts the king in check. 
            // This means we only have to check the possible takes. 
            var tempSpace = king.Space;
            king.Space = space;

            foreach (var otherPiece in board.Pieces)
            {
                // If different color and not taken.
                if (otherPiece.IsWhite != king.IsWhite && otherPiece.Space != null)
                {
                    foreach (var possibleMove in otherPiece.GetPossibleTakes(board))
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