namespace ChessApp.Model
{
    public class Space
    {
        public (int X, int Y) Coordinates { get; set; }

        public PieceInfo? OccupiedPiece { get; set; }

        public HighlightType Highlight { get; set; }

        public bool IsWhite { get; set; }
    }
}