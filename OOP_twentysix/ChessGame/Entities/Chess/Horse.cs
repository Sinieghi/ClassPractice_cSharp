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
            bool[,] pm = new bool[board.line, board.column];

            Position p = new(0, 0);

            p.DefineValues(Position.line - 1, Position.column - 2);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            p.DefineValues(Position.line - 2, Position.column - 1);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            p.DefineValues(Position.line - 2, Position.column + 1);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            p.DefineValues(Position.line - 1, Position.column + 2);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            p.DefineValues(Position.line + 1, Position.column + 2);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            p.DefineValues(Position.line + 2, Position.column + 1);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            p.DefineValues(Position.line + 2, Position.column - 1);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            p.DefineValues(Position.line + 1, Position.column - 2);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            return pm;
        }

        public override string ToString()
        {
            return "H";
        }


    }

}