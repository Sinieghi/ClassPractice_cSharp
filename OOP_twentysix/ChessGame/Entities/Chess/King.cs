using System;
namespace ChessGame
{
    class King(Board board, Color color, ChessMatch match) : Piece(board, color)
    {
        private ChessMatch Match = match;

        private bool CanMove(Position pos)
        {
            Piece p = board.setPiece(pos);
            return p == null || p.color != color;
        }
        private bool TestTowerForRoque(Position position)
        {
            Piece p = board.setPiece(position);
            return p != null && p is Tower && p.color == color && p.MovementCount == 0;
        }
        public override bool[,] PossibleMovements()
        {
            bool[,] pm = new bool[board.line, board.column];

            Position p = new Position(0, 0);
            //north direction
            p.DefineValues(Position.line - 1, Position.column);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            //ne direction
            p.DefineValues(Position.line - 1, Position.column + 1);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            //east position
            p.DefineValues(Position.line, Position.column + 1);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            //se position
            p.DefineValues(Position.line + 1, Position.column + 1);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            //south position
            p.DefineValues(Position.line + 1, Position.column);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            //sw position
            p.DefineValues(Position.line + 1, Position.column - 1);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            //west position
            p.DefineValues(Position.line, Position.column - 1);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }
            //nw position
            p.DefineValues(Position.line - 1, Position.column - 1);
            if (board.validatePosition(p) && CanMove(p))
            {
                pm[p.line, p.column] = true;
            }


            //roque
            if (MovementCount == 0 && !Match.Checkmate)
            {
                Position posT1 = new(Position.line, Position.column + 3);
                if (TestTowerForRoque(posT1))
                {
                    Position p1 = new(p.line, p.column + 1);
                    Position p2 = new(p.line, p.column + 2);
                    if (board.setPiece(p1) == null && board.setPiece(p2) == null)
                    {
                        pm[Position.line, Position.column + 2] = true;
                    }
                }

                //big roque


                Position posT2 = new(Position.line, Position.column - 4);
                if (TestTowerForRoque(posT2))
                {
                    Position p1 = new(p.line, p.column - 1);
                    Position p2 = new(p.line, p.column - 2);
                    Position p3 = new(p.line, p.column - 3);
                    if (board.setPiece(p1) == null && board.setPiece(p2) == null && board.setPiece(p3) == null)
                    {
                        pm[Position.line, Position.column - 2] = true;
                    }
                }
            }



            return pm;



        }

        public override string ToString()
        {
            return "K";
        }
    }

}