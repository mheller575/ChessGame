namespace ChessApp.Services
{
    using Chess;

    internal interface ISaveService
    {
        bool SaveGame(List<ISpace> board, string fileName);
    }

    internal class SaveService
    {
        private readonly Func<List<ISpace>, string, bool> _chessGameSaver;

        public SaveService(Func<List<ISpace>, string, bool> chessGameSaver)
        {
            _chessGameSaver = chessGameSaver;
        }

        public bool SaveGame(List<ISpace> board, string fileName)
        {
            return _chessGameSaver(board, fileName);
        }
    }
}