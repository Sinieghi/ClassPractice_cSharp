using System;
namespace ChessGame
{
    class Horse(Board board, Color color) : Piece(board, color)
    {

        private bool CanMove(Position pos)
        {
            Piece p = board.setPiece(pos);
            return p == null || p.color != color;
        }
        public override bool[,] PossibleMovements()
        {
            throw new NotImplementedException();
            //     bool[,] pm = new bool[board.line, board.column];

            //     Position p = new Position(0, 0);
            //     //north direction
            //     p.DefineValues(Position.line - 1, Position.column);
            //     if (board.validatePosition(p) && CanMove(p))
            //     {
            //         pm[p.line, p.column] = true;
            //     }
            //     //ne direction
            //     p.DefineValues(Position.line - 1, Position.column + 1);
            //     if (board.validatePosition(p) && CanMove(p))
            //     {
            //         pm[p.line, p.column] = true;
            //     }
            //     //east position
            //     p.DefineValues(Position.line, Position.column + 1);
            //     if (board.validatePosition(p) && CanMove(p))
            //     {
            //         pm[p.line, p.column] = true;
            //     }
            //     //se position
            //     p.DefineValues(Position.line + 1, Position.column + 1);
            //     if (board.validatePosition(p) && CanMove(p))
            //     {
            //         pm[p.line, p.column] = true;
            //     }
            //     //south position
            //     p.DefineValues(Position.line + 1, Position.column);
            //     if (board.validatePosition(p) && CanMove(p))
            //     {
            //         pm[p.line, p.column] = true;
            //     }
            //     //sw position
            //     p.DefineValues(Position.line + 1, Position.column - 1);
            //     if (board.validatePosition(p) && CanMove(p))
            //     {
            //         pm[p.line, p.column] = true;
            //     }
            //     //west position
            //     p.DefineValues(Position.line, Position.column - 1);
            //     if (board.validatePosition(p) && CanMove(p))
            //     {
            //         pm[p.line, p.column] = true;
            //     }
            //     //nw position
            //     p.DefineValues(Position.line - 1, Position.column - 1);
            //     if (board.validatePosition(p) && CanMove(p))
            //     {
            //         pm[p.line, p.column] = true;
            //     }

            //     return pm;
        }

        public override string ToString()
        {
            return "Q";
        }


    }

}