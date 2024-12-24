namespace Chess.Internal
{
    /// <summary>
    /// Interface for any possible moves provider.
    /// </summary>
    internal interface IPossibleMovesProvider
    {
        /// <summary>
        /// Gets the possible moves in the provided board. Using the provided space as the starting space.
        /// </summary>
        /// <param name="board">Board object to use.</param>
        /// <param name="space">Starting space of the piece.</param>
        /// <returns>Enumerable of possible moves.</returns>
        IEnumerable<ISpace> GetPossibleMoves(IBoard board, ISpace? space);

        /// <summary>
        /// Gets the possible takes in the provided board. Using the provided space as the starting space.
        /// </summary>
        /// <param name="board">Board object to use.</param>
        /// <param name="space">Starting space of the piece.</param>
        /// <returns>Enumerable of possible takes.</returns>
        IEnumerable<ISpace> GetPossibleTakes(IBoard board, ISpace? space);
    }
}