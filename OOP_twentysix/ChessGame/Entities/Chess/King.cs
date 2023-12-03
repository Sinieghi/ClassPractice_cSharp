using System;
namespace ChessGame
{
    class King(Board board, Color color) : Piece(board, color)
    {
        public override string ToString()
        {
            return "R";
        }
    }

}