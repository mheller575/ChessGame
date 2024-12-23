﻿namespace Chess.Internal.PossibleMovesProviders
{
    internal class PawnPossibleMovesProvider : IPossibleMovesProvider
    {
        private readonly int _modifier;

        public PawnPossibleMovesProvider(bool upDirection)
        {
            _modifier = upDirection ? 1 : -1;
        }

        public IEnumerable<ISpace> GetPossibleMoves(IBoard board, ISpace? space)
        {
            if (space == null || space.Piece == null)
            {
                return [];
            }

            var possibleMoves = new List<ISpace>();

            var spaceInFront = board.GetSpace((space.Coordinates.X, space.Coordinates.Y + _modifier));
            if (spaceInFront.Piece == null) // If the space in front of the pawn is empty, it can move there.
            {
                possibleMoves.Add(spaceInFront); // This is the space in front of the pawn.

                if (space.Piece.HasMoved == false) // If the pawn hasn't moved yet, it can move 2 spaces.
                {
                    // This check has to be inside the if statement because the pawn cannot jump over pieces.
                    var spaceTwoInFront = board.GetSpace((space.Coordinates.X, space.Coordinates.Y + 2 * _modifier));
                    if (spaceTwoInFront.Piece == null) // If the space 2 in front of the pawn is empty, it can move there.
                    {
                        possibleMoves.Add(spaceTwoInFront); // First Pawn move can be 2 spaces.
                    }
                }
            }

            return possibleMoves;
        }

        public IEnumerable<ISpace> GetPossibleTakes(IBoard board, ISpace? space)
        {
            if (space == null || space.Piece == null)
            {
                return [];
            }

            var possibleMoves = new List<ISpace>();

            if (space.Coordinates.X > 0)
            {
                var leftFrontSpace = board.GetSpace((space.Coordinates.X - 1, space.Coordinates.Y + _modifier));
                if (leftFrontSpace.Piece != null && leftFrontSpace.Piece.IsWhite != space.Piece.IsWhite)
                {
                    possibleMoves.Add(leftFrontSpace); // This is a take.
                }
            }

            if (space.Coordinates.X < 7)
            {
                var rightFrontSpace = board.GetSpace((space.Coordinates.X + 1, space.Coordinates.Y + _modifier));
                if (rightFrontSpace.Piece != null && rightFrontSpace.Piece.IsWhite != space.Piece.IsWhite)
                {
                    possibleMoves.Add(rightFrontSpace); // This is a take.
                }
            }

            return possibleMoves;
        }
    }
}