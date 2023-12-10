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

        public void DecreaseMovementQnt()
        {
            MovementCount--;
        }

        public bool isPossibleToMove()
        {
            bool[,] m = PossibleMovements();
            for (int i = 0; i < board.line; i++)
            {
                for (int u = 0; u < board.column; u++)
                {
                    if (m[i, u])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsAbleToMoveThere(Position p)
        {
            return PossibleMovements()[p.line, p.column];
        }
        public abstract bool[,] PossibleMovements();
    }

}