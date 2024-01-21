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
            Position p = new(0, 0);
            //north
            p.DefineValues(Position.line - 1, Position.column);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)
                    break;

                p.DefineValues(Position.line - 1, Position.column);
            }
            //south position
            p.DefineValues(Position.line + 1, Position.column);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)
                    break;

                p.DefineValues(Position.line + 1, Position.column);
            }
            //east position
            p.DefineValues(Position.line, Position.column + 1);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)
                    break;
                p.DefineValues(Position.line, Position.column + 1);
            }
            //west position
            p.DefineValues(Position.line, Position.column - 1);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)
                    break;

                p.DefineValues(Position.line, Position.column - 1);
            }

            ///////

            //nw
            p.DefineValues(Position.line - 1, Position.column - 1);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)
                    break;

                p.DefineValues(Position.line - 1, Position.column - 1);
            }
            //ne
            p.DefineValues(Position.line - 1, Position.column + 1);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)
                    break;

                p.DefineValues(Position.line - 1, Position.column + 1);
            }
            //se
            p.DefineValues(Position.line + 1, Position.column + 1);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                // Console.WriteLine("movement");
                // Console.WriteLine(Color.White);
                Console.WriteLine(color);
                Console.WriteLine(pm);
                if (board.setPiece(p) != null && board.setPiece(p).color != color)
                    break;

                p.DefineValues(Position.line + 1, Position.column + 1);
            }
            //sw
            p.DefineValues(Position.line + 1, Position.column + 1);
            while (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
                if (board.setPiece(p) != null && board.setPiece(p).color != color)
                    break;

                p.DefineValues(Position.line + 1, Position.column + 1);
            }

            return pm;
        }

        public override string ToString()
        {
            return "Q";
        }


    }

}