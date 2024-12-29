namespace Chess.Tests.Mocks
{
    internal class IPieceMock : IPiece
    {
        #region IPiece Implementation

        public ISpace? Space { get; set; }

        public bool IsWhite { get; set; }

        public bool HasMoved { get; set; }

        public PieceType PieceType { get; set; }

        public IEnumerable<ISpace> GetPossibleMoves(IBoard board)
        {
            GetPossibleMoves_Called = true;
            GetPossibleMoves_Input_board = board;
            return GetPossibleMoves_Output;
        }

        
        public IEnumerable<ISpace> GetPossibleTakes(IBoard board)
        {
            GetPossibleTakes_Called = true;
            GetPossibleTakes_Input_board = board;
            return GetPossibleTakes_Output;
        }

        #endregion

        #region IPiece Mock Implementation

        public bool GetPossibleMoves_Called { get; set; }
        public IBoard GetPossibleMoves_Input_board { get; set; }
        public IEnumerable<ISpace> GetPossibleMoves_Output { get; set; }

        public bool GetPossibleTakes_Called { get; set; }
        public IBoard GetPossibleTakes_Input_board { get; set; }
        public IEnumerable<ISpace> GetPossibleTakes_Output { get; set; }

        #endregion
    }
}