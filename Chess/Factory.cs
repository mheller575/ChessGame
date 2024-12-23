using Chess.Internal;
using Chess.Internal.PossibleMovesProviders;
using System.ComponentModel.DataAnnotations;

namespace Chess
{
    public static class Factory
    {
        public static IBoard GetStartingBoard()
        {
            var spaces = new List<ISpace>();
            var pieces = new List<IPiece>();

            for (int row = 0; row < 8; ++row)
            {
                for (int column = 0; column < 8; ++column)
                {
                    var space = new Space((column, row));
                    spaces.Add(space);

                    bool isWhite = row < 2;
                    if (row == 0 || row == 7)
                    {
                        if (column == 0 || column == 7)
                        {
                            pieces.Add(new Piece(space, isWhite, false, PieceType.Rook, new RookPossibleMovesProvider()));
                        }
                        else if (column == 1 || column == 6)
                        {
                            pieces.Add(new Piece(space, isWhite, false, PieceType.Knight, new KnightPossibleMovesProvider()));
                        }
                        else if (column == 2 || column == 5)
                        {
                            pieces.Add(new Piece(space, isWhite, false, PieceType.Bishop, new BishopPossibleMovesProvider()));
                        }
                        else if (column == 3)
                        {
                            pieces.Add(new Piece(space, isWhite, false, PieceType.Queen, new QueenPossibleMovesProvider()));
                        }
                        else if (column == 4)
                        {
                            pieces.Add(new Piece(space, isWhite, false, PieceType.King, new KingPossibleMovesProvider()));
                        }
                    }
                    else if (row == 1 || row == 6)
                    {
                        // Up direction if isWhite is also true (isWhite is true for rows 0 and 1)
                        pieces.Add(new Piece(space, isWhite, false, PieceType.Pawn, new PawnPossibleMovesProvider(isWhite)));
                    }
                }
            }

            return new Board(spaces, pieces);
        }
    }
}