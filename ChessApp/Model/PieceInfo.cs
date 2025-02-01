namespace ChessApp.Model
{
    public class PieceInfo
    {
        public bool IsWhite { get; set; }

        public PieceType Type { get; set; }

        public bool HasMoved { get; set; }
    }
}