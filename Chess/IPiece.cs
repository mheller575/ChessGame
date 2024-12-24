namespace Chess
{
    /// <summary>
    /// Interface for a piece object.
    /// </summary>
    public interface IPiece
    {
        /// <summary>
        /// Gets the space this piece is on. If null the piece is not on the board.
        /// </summary>
        ISpace? Space { get; set; }

        /// <summary>
        /// Gets a flag indicating if this piece is white or not.
        /// </summary>
        bool IsWhite { get; }

        /// <summary>
        /// Gets a flag indicating if the piece has moved or not.
        /// </summary>
        bool HasMoved { get; }

        /// <summary>
        /// Gets the type of this piece.
        /// </summary>
        PieceType PieceType { get; }

        /// <summary>
        /// Gets the possible moves this piece can make. Excludes takes.
        /// </summary>
        /// <param name="board">Board object to use when searching.</param>
        /// <returns>An enumerable list of possible spaces.</returns>
        IEnumerable<ISpace> GetPossibleMoves(IBoard board);

        /// <summary>
        /// Gets the possible takes this piece can make. Excludes moves.
        /// </summary>
        /// <param name="board">Board object to use when searching.</param>
        /// <returns>An enumerable list of possible takes.</returns>
        IEnumerable<ISpace> GetPossibleTakes(IBoard board);
    }
}