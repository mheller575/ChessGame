using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayChess.Model
{
    internal enum ChessPieceType
    {
        King,
        Queen,
        Rook,
        Bishop,
        Knight,
        Pawn,
    }

    internal class ChessPiece
    {
        public bool IsWhite { get; set; }
        public ChessPieceType Type { get; set; }
    }

    internal class ChessBoard
    {
        public ChessPiece[,] Board { get; set; }
    }
}
