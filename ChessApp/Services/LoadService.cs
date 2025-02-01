namespace ChessApp.Services
{
    using Chess;

    internal interface ILoadService
    {
        List<ISpace> LoadGame(string file);
    }

    internal class LoadService : ILoadService
    {
        private readonly Func<string, List<ISpace>> _chessGameLoader;

        public LoadService(Func<string, List<ISpace>> chessGameLoader)
        {
            _chessGameLoader = chessGameLoader;
        }

        public List<ISpace> LoadGame(string file)
        {
            return _chessGameLoader(file);
        }
    }
}