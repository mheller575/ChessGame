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
    ///  R K B K Q B K R
    /// </summary>
    public interface IBoard
    {
        IEnumerable<ISpace> Spaces { get; }

        IEnumerable<IPiece> Pieces { get; }

        ISpace GetSpace((int X, int Y) coordinates);

        IPiece GetPiece(bool isWhite, PieceType pieceType);
    }
}