namespace Chess
{
    public interface ISpace
    {
        IPiece? Piece { get; set; }

        (int X, int Y) Coordinates { get; }
    }
}