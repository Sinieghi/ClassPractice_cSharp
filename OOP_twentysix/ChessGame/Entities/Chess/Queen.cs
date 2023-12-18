using System;
namespace ChessGame
{
    class Queen(Board board, Color color) : Piece(board, color)
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
            //nw
            p.DefineValues(Position.line - 1, Position.column - 1);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)
                    break;

                p.DefineValues(Position.line - 1, Position.column - 1);
            }
            //south position

            p.DefineValues(Position.line - 1, Position.column + 1);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)
                    break;

                p.DefineValues(Position.line - 1, Position.column + 1);
            }
            //east position
            p.DefineValues(Position.line + 1, Position.column + 1);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)
                    break;
                p.DefineValues(Position.line + 1, Position.column + 1);
            }
            //west position
            p.DefineValues(Position.line + 1, Position.column - 1);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)
                    break;

                p.DefineValues(Position.line + 1, Position.column - 1);
            }
            //
            p.DefineValues(Position.line - 1, Position.column);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)
                    break;

                p.line--;
            }
            //south position

            p.DefineValues(Position.line + 1, Position.column);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)
                    break;

                p.line++;
            }
            //east position
            p.DefineValues(Position.line, Position.column + 1);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)
                    break;

                p.column++;
            }
            //west position
            p.DefineValues(Position.line, Position.column - 1);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)

                    break;

                p.column--;
            }
            return pm;
        }

        public override string ToString()
        {
            return "Q";
        }


    }

}