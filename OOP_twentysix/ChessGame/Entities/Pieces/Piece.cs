using System;
namespace ChessGame
{
    class Piece
    {
        public Position Position { get; set; }
        public Color color { get; set; }
        public int MovementCount { get; private set; }
        public Board board { get; protected set; }

        public Piece(Board board, Color color)
        {
            Position = null;
            this.board = board;
            this.color = color;
            MovementCount = 0;
        }
        public void IncrementMovementQnt()
        {
            MovementCount++;
        }
    }

}