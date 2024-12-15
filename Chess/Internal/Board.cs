// TODO: License/Copyright

namespace DotNetChess.Internal
{
    internal class Board : IBoard
    {
        public Board(IEnumerable<ISpace> spaces, IEnumerable<IPiece> pieces)
        {
            if (spaces.Count() != 64)
            {
                throw new ChessException("spaces.Count() must be equal to 64.");
            }

            var piecesCount = pieces.Count();
            if (piecesCount < 2 || 32 < piecesCount)
            {
                throw new ChessException("pieces.Count() must have at least 2 and at most 32.");
            }

            Spaces = spaces;
            Pieces = pieces;
        }

        public IEnumerable<ISpace> Spaces { get; }

        public IEnumerable<IPiece> Pieces { get; }

        public ISpace GetSpace((int X, int Y) coordinates)
        {
            if (coordinates.X < 0 || coordinates.X > 7 || coordinates.Y < 0 || coordinates.Y > 7)
            {
                throw new ChessException($"x and/or y coordinates are out of range. Coordinates must be in the range [0,7]." +
                    $" x = {coordinates.X}, y = {coordinates.Y}.");
            }

            foreach (var space in Spaces)
            {
                var (X, Y) = space.Coordinates;
                if (X == coordinates.X && Y == coordinates.Y)
                {
                    return space;
                }
            }

            throw new ChessException($"No space exists with the provided x and y coordinates. " +
                $"Any space in the x and y range [0,7] must exist. x = {coordinates.X}, y = {coordinates.Y}.");
        }

        public IPiece GetPiece(bool isWhite, PieceType pieceType)
        {
            foreach (var piece in Pieces)
            {
                if (piece.IsWhite == isWhite && piece.PieceType == pieceType)
                {
                    return piece;
                }
            }

            throw new ChessException($"No piece exists with the provided isWhite and pieceType. " +
                $"Any piece with the provided isWhite and pieceType must exist. isWhite = {isWhite}, pieceType = {pieceType}.");
        }
    }
}