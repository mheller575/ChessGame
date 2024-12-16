namespace Chess.Internal
{
    internal interface IPossibleMovesProvider
    {
        IEnumerable<ISpace> GetPossibleMoves(IBoard board, ISpace? space);

        IEnumerable<ISpace> GetPossibleTakes(IBoard board, ISpace? space);
    }
}