namespace ChessApp.Services
{
    using Chess;
    using ChessGame;
    using ChessApp.Model;

    public interface IGameService
    {
        List<Space> Board { get; }

        bool IsWhitesTurn { get; }

        bool MovePiece((int, int) sourceCoordinates, (int, int) destinationCoordinates);

        void HighlightAvailableMoves((int, int) coordinates);

        void ClearHighlights();

        bool IsCheck(bool isWhite);

        bool IsCheckMate(bool isWhite);

        void LoadGame();

        void SaveGame();
    }

    internal class GameService : IGameService
    {
        private IChessGame? _chessGame;

        public List<Space> Board
        {
            get
            {
                if (_chessGame == null)
                {
                    return [];
                }

                return ConvertBoardToSpaces(_chessGame.Board);
            }
        }

        public bool IsWhitesTurn { get; private set; }

        public void ClearHighlights()
        {
            foreach (var space in Board)
            {
                space.Highlight = HighlightType.None;
            }
        }

        public void HighlightAvailableMoves((int, int) coordinates)
        {
            if (_chessGame.Board.GetSpace(coordinates).Piece == null)
            {
                return;
            }

            foreach (var possibleMove in _chessGame.Board.GetSpace(coordinates).Piece.GetPossibleMoves(_chessGame.Board))
            {
                if (possibleMove != null)
                {
                    foreach (var space in Board)
                    {
                        if (space.Coordinates.X == possibleMove.Coordinates.X && space.Coordinates.Y == possibleMove.Coordinates.Y)
                        {
                            space.Highlight = HighlightType.Move;
                        }
                    }
                }
            }

            foreach (var possibleTake in _chessGame.Board.GetSpace(coordinates).Piece.GetPossibleTakes(_chessGame.Board))
            {
                if (possibleTake != null)
                {
                    foreach (var space in Board)
                    {
                        if (space.Coordinates.X == possibleTake.Coordinates.X && space.Coordinates.Y == possibleTake.Coordinates.Y)
                        {
                            space.Highlight = HighlightType.Capture;
                        }
                    }
                }
            }
        }

        public bool IsCheck(bool isWhite)
        {
            return _chessGame.IsCheck(isWhite);
        }

        public bool IsCheckMate(bool isWhite)
        {
            return _chessGame.IsCheck(isWhite);
        }

        public bool MovePiece((int, int) sourceCoordinates, (int, int) destinationCoordinates)
        {
            return _chessGame.MakeMove(_chessGame.Board.GetSpace(sourceCoordinates), _chessGame.Board.GetSpace(destinationCoordinates));
        }

        public void LoadGame(IChessGame chessGame)
        {
            _chessGame = chessGame;
        }

        public void LoadGame()
        {

        }

        public void SaveGame()
        {

        }

        private static List<Space> ConvertBoardToSpaces(IBoard board)
        {
            var spaces = new List<Space>();
            foreach (var space in board.Spaces)
            {
                spaces.Add(new Space
                {
                    Coordinates = space.Coordinates,
                    Highlight = HighlightType.None,
                    IsWhite = space.Piece?.IsWhite ?? false,
                    OccupiedPiece = space.Piece == null ? null : new PieceInfo
                    {
                        HasMoved = space.Piece.HasMoved,
                        IsWhite = space.Piece.IsWhite,
                        Type = ConvertPieceType(space.Piece.PieceType),
                    },
                });
            }

            return spaces;
        }

        private static Model.PieceType ConvertPieceType(Chess.PieceType pieceType)
        {
            return pieceType switch
            {
                Chess.PieceType.Bishop => Model.PieceType.Bishop,
                Chess.PieceType.King => Model.PieceType.King,
                Chess.PieceType.Knight => Model.PieceType.Knight,
                Chess.PieceType.Pawn => Model.PieceType.Pawn,
                Chess.PieceType.Queen => Model.PieceType.Queen,
                Chess.PieceType.Rook => Model.PieceType.Rook,
                _ => throw new ArgumentOutOfRangeException(nameof(pieceType), pieceType, null),
            };
        }
    }
}