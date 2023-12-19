using System;
namespace ChessGame
{
    class Pawn(Board board, Color color) : Piece(board, color)
    {

        private bool CanMove(Position pos)
        {
            Piece p = board.setPiece(pos);
            return p == null || p.color != color;
        }
        private bool Free(Position pos)
        {
            return board.setPiece(pos) == null;
        }
        public override bool[,] PossibleMovements()
        {
            bool[,] pm = new bool[board.line, board.column];

            Position p = new Position(0, 0);
            if (color == Color.Black)
            {

                p.DefineValues(Position.line - 1, Position.column);
                if (board.validatePosition(p) && CanMove(p))
                {
                    pm[p.line, p.column] = true;
                }

                p.DefineValues(Position.line - 2, Position.column);
                if (board.validatePosition(p) && CanMove(p) && MovementCount == 0)
                {
                    pm[p.line, p.column] = true;
                }

                p.DefineValues(Position.line - 1, Position.column - 1);
                if (board.validatePosition(p) && CanMove(p))
                {
                    pm[p.line, p.column] = true;
                }
                p.DefineValues(Position.line - 1, Position.column + 1);
                if (board.validatePosition(p) && CanMove(p))
                {
                    pm[p.line, p.column] = true;
                }
            }
            else
            {
                p.DefineValues(Position.line + 1, Position.column);
                if (board.validatePosition(p) && CanMove(p))
                {
                    pm[p.line, p.column] = true;
                }

                p.DefineValues(Position.line + 2, Position.column);
                if (board.validatePosition(p) && CanMove(p) && MovementCount == 0)
                {
                    pm[p.line, p.column] = true;
                }

                p.DefineValues(Position.line + 1, Position.column + 1);
                if (board.validatePosition(p) && CanMove(p))
                {
                    pm[p.line, p.column] = true;
                }
                p.DefineValues(Position.line + 1, Position.column - 1);
                if (board.validatePosition(p) && CanMove(p))
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