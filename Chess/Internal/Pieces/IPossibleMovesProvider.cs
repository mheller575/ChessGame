
namespace DotNetChess.Internal
{
    internal interface IPossibleMovesProvider
    {
        IEnumerable<ISpace> GetPossibleMoves(ISpace? space);

        IEnumerable<ISpace> GetPossibleTakes(ISpace? space);
    }
}