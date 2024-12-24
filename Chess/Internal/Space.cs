namespace Chess.Internal
{
    internal class Space : ISpace
    {
        #region Constructor

        public Space((int X, int Y) coordinates)
        {
            if (coordinates.X < 0 || coordinates.X > 7 || coordinates.Y < 0 || coordinates.Y > 7)
            {
                throw new ChessException($"Coordinates must be in the range [0,7] for both x and y. x = {coordinates.X}, y = {coordinates.Y}.");
            }

            Coordinates = coordinates;
        }

        #endregion

        #region ISpace Implementation

        public IPiece? Piece { get; set; }

        public (int X, int Y) Coordinates { get; private set; }

        #endregion
    }
}