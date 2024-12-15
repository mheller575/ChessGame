﻿

namespace DotNetChess
{
    public interface IPiece
    {
        ISpace? Space { get; set; }

        bool IsWhite { get; }

        bool HasMoved { get; }

        PieceType PieceType { get; }

        IEnumerable<ISpace> GetPossibleMoves();

        IEnumerable<ISpace> GetPossibleTakes();
    }
}