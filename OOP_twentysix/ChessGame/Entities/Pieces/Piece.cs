using System;
namespace ChessGame
{
    abstract class Piece(Board board, Color color)
    {
        public Position? Position { get; set; } = null;
        public Color color { get; set; } = color;
        public int MovementCount { get; private set; } = 0;
        public Board board { get; protected set; } = board;

        public void IncrementMovementQnt()
        {
            MovementCount++;
        }
        public abstract bool[,] PossibleMovements();
    }

}