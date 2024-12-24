namespace Chess.Internal.PossibleMovesProviders
{
    internal abstract class APossibleMovesProvider : IPossibleMovesProvider
    {
        #region IPossibleMovesProvider Implementation

        public IEnumerable<ISpace> GetPossibleMoves(IBoard board, ISpace? space)
        {
            if (board == null)
            {
                throw new ChessException("board is null but must not be.");
            }
            else if (space == null)
            {
                throw new ChessException("space is null but must not be.");
            }
            else if (space.Piece == null)
            {
                return [];
            }

            var possibleMoves = new List<ISpace>();

            GetPossibleMovesForPiece(board, space, ref possibleMoves);

            return possibleMoves;
        }

        public IEnumerable<ISpace> GetPossibleTakes(IBoard board, ISpace? space)
        {
            if (board == null)
            {
                throw new ChessException("Board is null but must not be.");
            }
            else if (space == null)
            {
                throw new ChessException("space is null but must not be.");
            }
            else if (space.Piece == null)
            {
                return [];
            }

            var possibleTakes = new List<ISpace>();

            GetPossibleTakesForPiece(board, space, ref possibleTakes);

            return possibleTakes;
        }

        #endregion

        #region Abstract Methods

        protected abstract void GetPossibleMovesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces);

        protected abstract void GetPossibleTakesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces);

        #endregion
    }
}