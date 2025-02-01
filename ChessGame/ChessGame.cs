namespace ChessGame
{
    using Chess;

    public class ChessGame : IChessGame
    {
        #region Constructor

        public ChessGame(IBoard board, bool isFirstMoveWhite)
        {
            Board = board;
            IsWhiteTurn = isFirstMoveWhite;
        }

        #endregion

        #region Public Properties

        public IBoard Board { get; private set; }

        public bool IsWhiteTurn { get; private set; }

        #endregion

        #region Public Methods

        public bool MakeMove(ISpace originalSpace, ISpace newSpace)
        {
            if (originalSpace == null)
            {
                return false;
            }
            else if (newSpace == null)
            {
                return false;
            }
            else if (originalSpace.Piece == null)
            {
                return false;
            }
            else if (originalSpace.Piece.IsWhite != IsWhiteTurn)
            {
                return false;
            }

            if (newSpace.Piece != null) // If the new space has a piece this must be a take.
            {
                if (newSpace.Piece.IsWhite == originalSpace.Piece.IsWhite)
                {
                    return false;
                }

                var takes = originalSpace.Piece.GetPossibleTakes(Board);
                if (!takes.Contains(newSpace))
                {
                    return false; // This was not a valid take.
                }
                newSpace.Piece.Space = null;
                newSpace.Piece = originalSpace.Piece;
                originalSpace.Piece = null;
            }
            else
            {
                var moves = originalSpace.Piece.GetPossibleMoves(Board);
                if (!moves.Contains(newSpace))
                {
                    return false; // This was not a valid move.
                }

                newSpace.Piece = originalSpace.Piece;
                originalSpace.Piece = null;
            }

            return true;
        }

        public bool IsCheck(bool isWhite)
        {
            foreach (var piece in Board.Pieces)
            {
                if (piece.Space != null && piece.IsWhite != isWhite)
                {
                    foreach (var take in piece.GetPossibleTakes(Board))
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

        public bool IsCheckmate(bool isWhite)
        {
            var kingPieces = Board.GetPiece(isWhite, PieceType.King);

            if (kingPieces.Count != 1)
            {
                return false;
            }

            var king = kingPieces[0];

            var moves = king.GetPossibleMoves(Board);

            if (moves.Count() != 0)
            {
                return false;
            }

            var takes = king.GetPossibleTakes(Board);

            if (takes.Count() != 0)
            {
                return false;
            }

            return true;
        }

        #endregion
    }
}