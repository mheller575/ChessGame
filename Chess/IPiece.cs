namespace Chess
{
    public interface IPiece
    {
        ISpace? Space { get; set; }

        bool IsWhite { get; }

        bool HasMoved { get; }

        PieceType PieceType { get; }

        IEnumerable<ISpace> GetPossibleMoves(IBoard board);

        IEnumerable<ISpace> GetPossibleTakes(IBoard board);
    }
}