using System;
namespace ChessGame
{
    class Tower(Board board, Color color) : Piece(board, color)
    {
        public override string ToString()
        {
            return "T";
        }
    }

}