using System;
namespace ChessGame
{
    class King(Board board, Color color) : Piece(board, color)
    {

        private bool CanMove(Position pos)
        {
            Piece p = board.setPiece(pos);
            return p == null || p.color != color;
        }
        public override bool[,] PossibleMovements()
        {
            bool[,] pm = new bool[board.line, board.column];
            Position p = new Position(0, 0);
            //north direction
            p.DefineValues(p.line - 1, p.column);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            //ne direction
            p.DefineValues(p.line - 1, p.column + 1);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            //east position
            p.DefineValues(p.line, p.column + 1);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            //se position
            p.DefineValues(p.line + 1, p.column + 1);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            //south position
            p.DefineValues(p.line + 1, p.column);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            //sw position
            p.DefineValues(p.line + 1, p.column - 1);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            //west position
            p.DefineValues(p.line, p.column - 1);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            //nw position
            p.DefineValues(p.line - 1, p.column - 1);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }

            return pm;



        }

        public override string ToString()
        {
            return "R";
        }
    }

}