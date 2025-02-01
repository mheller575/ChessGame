namespace ChessApp.Services
{
    using Chess;

    internal interface INewGameService
    {
        List<ISpace> StartNewGame();
    }

    internal class NewGameService : INewGameService
    {
        private readonly Func<List<ISpace>> _newChessGameBuilder;

        public NewGameService(Func<List<ISpace>> newChessGameBuilder)
        {
            _newChessGameBuilder = newChessGameBuilder;
        }

        public List<ISpace> StartNewGame()
        {
            return _newChessGameBuilder();
        }
    }
}