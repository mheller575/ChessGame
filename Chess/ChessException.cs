namespace Chess
{
    /// <summary>
    /// Exception that can be thrown by this library.
    /// </summary>
    public class ChessException : Exception
    {
        /// <summary>
        /// No argument constructor.
        /// </summary>
        public ChessException() {}

        /// <summary>
        /// Exception with custom message.
        /// </summary>
        /// <param name="message">Message about this exception.</param>
        public ChessException(string? message) : base(message) {}

        /// <summary>
        /// Exception with custom message and inner exception.
        /// </summary>
        /// <param name="message">Message about this exception.</param>
        /// <param name="innerException">Inner exception message.</param>
        public ChessException(string? message, Exception? innerException) : base(message, innerException) {}
    }
}