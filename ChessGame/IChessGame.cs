namespace ChessGame
{
    using Chess;

    public interface IChessGame
    {
        IBoard Board { get; }

        bool IsWhiteTurn { get; }

        bool MakeMove(ISpace originalSpace, ISpace newSpace);

        bool IsCheck(bool isWhite);

        bool IsCheckmate(bool isWhite);
    }
}