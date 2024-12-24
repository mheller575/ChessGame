namespace Chess
{
    /// <summary>
    /// Interface for a board object. Boards from this interface are in the form of a grid of spaces. Each space having X and Y coordinates.
    /// 
    /// Chess board is an 8x8 grid. For our grid representation the top of the board will start at 0
    /// 
    ///   7 # # # # # # # #
    ///   6 # # # # # # # #
    ///   5 # # # # # # # #
    ///   4 # # # # # # # #
    ///   3 # # # # # # # #
    /// ^ 2 # # # # # # # #
    /// | 1 # # # # # # # #
    /// Y 0 # # # # # # # #  
    ///     0 1 2 3 4 5 6 7
    ///     X ->
    /// 
    /// Pieces moving up the board from Y 0/1 to Y 6/7 are moving "up" the board.
    /// Pieces moving up the board from Y 0/1 to Y 6/7 are moving "down" the board.
    /// 
    /// Colors are not assigned to a side of the board.
    /// 
    /// Example starting board:
    /// 
    ///  R K B Q K B K R
    ///  P P P P P P P P
    ///  # # # # # # # #
    ///  # # # # # # # #
    ///  # # # # # # # #
    ///  # # # # # # # #
    ///  P P P P P P P P
    ///  R K B Q K B K R
    /// </summary>
    public interface IBoard
    {
        /// <summary>
        /// Gets all spaces.
        /// </summary>
        IEnumerable<ISpace> Spaces { get; }

        /// <summary>
        /// Gets all pieces.
        /// </summary>
        IEnumerable<IPiece> Pieces { get; }

        /// <summary>
        /// Gets the space at the specified coordinates.
        /// </summary>
        /// <param name="coordinates">X and Y coordinates of the space desired.</param>
        /// <returns>The space.</returns>
        ISpace GetSpace((int X, int Y) coordinates);

        /// <summary>
        /// Gets the piece(s) of the specified type and color.
        /// </summary>
        /// <param name="isWhite">True for the white piece.</param>
        /// <param name="pieceType">Type of the piece.</param>
        /// <returns>A list of the pieces meeting this description.</returns>
        List<IPiece> GetPiece(bool isWhite, PieceType pieceType);
    }
}