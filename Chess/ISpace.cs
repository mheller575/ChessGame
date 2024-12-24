namespace Chess
{
    /// <summary>
    /// Interface for a space object.
    /// </summary>
    public interface ISpace
    {
        /// <summary>
        /// Gets the piece that is on this space. If null this space is unoccupied.
        /// </summary>
        IPiece? Piece { get; set; }

        /// <summary>
        /// Gets the coordinates of this space.
        /// </summary>
        (int X, int Y) Coordinates { get; }
    }
}