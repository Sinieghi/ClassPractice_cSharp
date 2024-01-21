using System;
namespace ChessGame
{
    class Pawn(Board board, Color color) : Piece(board, color)
    {

        private bool HasEnemy(Position pos)
        {
            Piece p = board.setPiece(pos);
            return p != null && p.color != color;
        }
        private bool Free(Position pos)
        {
            return board.setPiece(pos) == null;
        }

        public override bool[,] PossibleMovements()
        {
            bool[,] pm = new bool[board.line, board.column];

            Position p = new(0, 0);
            if (color == Color.White)
            {

                p.DefineValues(Position.line + 1, Position.column);
                if (board.validatePosition(p) && Free(p))
                {
                    pm[p.line, p.column] = true;
                }

                p.DefineValues(Position.line + 2, Position.column);
                Position p2 = new(Position.line + 1, Position.column);

                if (board.validatePosition(p2) && Free(p2) && board.validatePosition(p) && Free(p) && MovementCount == 0)
                {
                    pm[p.line, p.column] = true;
                }

                p.DefineValues(Position.line + 1, Position.column + 1);
                if (board.validatePosition(p) && HasEnemy(p))
                {
                    pm[p.line, p.column] = true;
                }
                p.DefineValues(Position.line + 1, Position.column - 1);
                if (board.validatePosition(p) && HasEnemy(p))
                {
                    pm[p.line, p.column] = true;
                }
            }
            else
            {
                p.DefineValues(Position.line - 1, Position.column);
                if (board.validatePosition(p) && Free(p))
                {
                    pm[p.line, p.column] = true;
                }
                Position p2 = new(Position.line - 1, Position.column);
                p.DefineValues(Position.line - 2, Position.column);
                if (board.validatePosition(p2) && Free(p2) && board.validatePosition(p) && Free(p) && MovementCount == 0)
                {
                    pm[p.line, p.column] = true;
                }

                p.DefineValues(Position.line - 1, Position.column - 1);
                if (board.validatePosition(p) && HasEnemy(p))
                {
                    pm[p.line, p.column] = true;
                }
                p.DefineValues(Position.line - 1, Position.column + 1);
                if (board.validatePosition(p) && HasEnemy(p))
                {
                    pm[p.line, p.column] = true;
                }
            }
            return pm;
        }

        public override string ToString()
        {
            return "P";
        }


    }

}