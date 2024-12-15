

namespace DotNetChess
{
    public interface ISpace
    {
        IPiece? Piece { get; set; }

        (int X, int Y) Coordinates { get; }
    }
}