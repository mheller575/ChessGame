

namespace DotNetChess
{
    public class ChessException : Exception
    {
        public ChessException() {}

        public ChessException(string? message) : base(message) {}

        public ChessException(string? message, Exception? innerException) : base(message, innerException) {}
    }
}