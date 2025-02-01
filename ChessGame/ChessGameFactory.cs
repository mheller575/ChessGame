namespace ChessGame
{
    using Chess;

    public static class ChessGameFactory
    {
        public static IChessGame BuildChessGame(IBoard board)
        {
            return new ChessGame(board, true);
        }
    }
}