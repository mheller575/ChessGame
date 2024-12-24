namespace Chess.Internal.PossibleMovesProviders
{
    internal class PawnPossibleMovesProvider : APossibleMovesProvider
    {
        private readonly int _modifier;

        public PawnPossibleMovesProvider(bool upDirection)
        {
            _modifier = upDirection ? 1 : -1;
        }

        protected override void GetPossibleMovesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces)
        {
            var spaceInFront = board.GetSpace((space.Coordinates.X, space.Coordinates.Y + _modifier));
            if (spaceInFront.Piece == null) // If the space in front of the pawn is empty, it can move there.
            {
                spaces.Add(spaceInFront); // This is the space in front of the pawn.

                if (space.Piece.HasMoved == false) // If the pawn hasn't moved yet, it can move 2 spaces.
                {
                    // This check has to be inside the if statement because the pawn cannot jump over pieces.
                    var spaceTwoInFront = board.GetSpace((space.Coordinates.X, space.Coordinates.Y + 2 * _modifier));
                    if (spaceTwoInFront.Piece == null) // If the space 2 in front of the pawn is empty, it can move there.
                    {
                        spaces.Add(spaceTwoInFront); // First Pawn move can be 2 spaces.
                    }
                }
            }
        }

        protected override void GetPossibleTakesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces)
        {
            if (space.Coordinates.X > 0)
            {
                var leftFrontSpace = board.GetSpace((space.Coordinates.X - 1, space.Coordinates.Y + _modifier));
                if (leftFrontSpace.Piece != null && leftFrontSpace.Piece.IsWhite != space.Piece.IsWhite)
                {
                    spaces.Add(leftFrontSpace); // This is a take.
                }
            }

            if (space.Coordinates.X < 7)
            {
                var rightFrontSpace = board.GetSpace((space.Coordinates.X + 1, space.Coordinates.Y + _modifier));
                if (rightFrontSpace.Piece != null && rightFrontSpace.Piece.IsWhite != space.Piece.IsWhite)
                {
                    spaces.Add(rightFrontSpace); // This is a take.
                }
            }
        }
    }
}