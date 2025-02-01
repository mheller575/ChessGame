namespace ChessApp.Utilities
{
    using ChessApp.Model;

    internal class ChessPieceIcon
    {
        #region Private Fields

        private static readonly Dictionary<PieceType, string> _whitePieces = new()
        {
            { PieceType.Queen, "♕" },
            { PieceType.King, "♔" },
            { PieceType.Bishop, "♗" },
            { PieceType.Knight, "♘" },
            { PieceType.Rook, "♖" },
            { PieceType.Pawn, "♙" },
        };

        private static readonly Dictionary<PieceType, string> _blackPieces = new()
        {
            { PieceType.Queen, "♛" },
            { PieceType.King, "♚" },
            { PieceType.Bishop, "♝" },
            { PieceType.Knight, "♞" },
            { PieceType.Rook, "♜" },
            { PieceType.Pawn, "♟" },
        };

        #endregion

        #region Public Methods

        public static string GetIcon(PieceType? pieceType, bool isWhite)
        {
            return pieceType.HasValue 
                ? isWhite 
                    ? _whitePieces[pieceType.Value]
                    : _blackPieces[pieceType.Value]
                : string.Empty;
        }

        #endregion
    }
}