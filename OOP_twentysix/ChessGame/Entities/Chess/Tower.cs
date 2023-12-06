using System;
namespace ChessGame
{
    class Tower(Board board, Color color) : Piece(board, color)
    {

        public override string ToString()
        {
            return "T";
        }
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
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)
                    break;

                p.line--;
            }
            //south position
            p.DefineValues(p.line + 1, p.column);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)
                    break;

                p.line++;
            }
            //east position
            p.DefineValues(p.line, p.column + 1);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)
                    break;

                p.column++;
            }
            //west position
            p.DefineValues(p.line, p.column - 1);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)

                    break;

                p.line--;
            }
            return pm;
        }
    }

}