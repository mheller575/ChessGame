namespace Chess.Internal.PossibleMovesProviders
{
    internal abstract class APossibleMovesProvider : IPossibleMovesProvider
    {
        #region IPossibleMovesProvider Implementation

        public IEnumerable<ISpace> GetPossibleMoves(IBoard board, ISpace space)
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

            foreach (var possibleMove in possibleMoves.ToList())
            {
                if (DoesMoveOrTakePutKingInCheck(board, space, possibleMove))
                {
                    possibleMoves.Remove(possibleMove);
                }
            }

            return possibleMoves;
        }

        public IEnumerable<ISpace> GetPossibleTakes(IBoard board, ISpace space)
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

            foreach (var possibleTake in possibleTakes.ToList())
            {
                if (DoesMoveOrTakePutKingInCheck(board, space, possibleTake))
                {
                    possibleTakes.Remove(possibleTake);
                }
            }

            return possibleTakes;
        }

        #endregion

        #region Abstract Methods

        protected abstract void GetPossibleMovesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces);

        protected abstract void GetPossibleTakesForPiece(IBoard board, ISpace space, ref List<ISpace> spaces);

        #endregion

        #region Private Methods

        private static bool DoesMoveOrTakePutKingInCheck(IBoard board, ISpace originalSpace, ISpace newSpace)
        {
            if (board == null)
            {
                throw new ChessException("board is null but must not be.");
            }
            else if (originalSpace == null)
            {
                throw new ChessException("originalSpace is null but must not be.");
            }
            else if (newSpace == null)
            {
                throw new ChessException("newSpace is null but must not be.");
            }
            else if (originalSpace.Piece == null)
            {
                throw new ChessException("originalSpace.Piece is null but must not be.");
            }

            var pieceToMove = originalSpace.Piece;
            MoveOrTake(pieceToMove, newSpace);

            var isInCheck = IsKingInCheck(board, pieceToMove.IsWhite);

            MoveOrTake(pieceToMove, originalSpace);

            return isInCheck;
        }

        private static bool IsKingInCheck(IBoard board, bool whiteKing)
        {
            foreach (var piece in board.Pieces)
            {
                if (piece.Space != null && piece.IsWhite != whiteKing)
                {
                    foreach (var take in piece.GetPossibleTakes(board))
                    {
                        if (take.Piece.PieceType == PieceType.King)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private static bool IsCheckmate(IBoard board, bool whiteKing)
        {
            var kingPieces = board.GetPiece(whiteKing, PieceType.King);

            if (kingPieces.Count != 1)
            {
                throw new ChessException("Only 1 king should be on board.");
            }

            var king = kingPieces[0];

            var moves = king.GetPossibleMoves(board);

            if (moves.Count() != 0)
            {
                return false;
            }

            var takes = king.GetPossibleTakes(board);

            return takes.Count() == 0;
        }

        private static void MoveOrTake(IPiece piece, ISpace newSpace)
        {
            if (piece.Space != null)
            {
                piece.Space.Piece = null;
            }

            if (newSpace.Piece != null)
            {
                newSpace.Piece.Space = null;
            }

            piece.Space = newSpace;
            newSpace.Piece = piece;
        }

        #endregion
    }
}