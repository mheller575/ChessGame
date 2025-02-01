namespace ChessApp.Services
{
    internal class ServiceCoordinator
    {
        private IGameService _gameService;
        private INewGameService _newGameService;
        private ILoadService _loadService;
        private ISaveService _saveService;

        public ServiceCoordinator(IGameService gameService, INewGameService newGameService, ILoadService loadService, ISaveService saveService)
        {
            _gameService = gameService;
            _newGameService = newGameService;
            _loadService = loadService;
            _saveService = saveService;
        }


    }
}