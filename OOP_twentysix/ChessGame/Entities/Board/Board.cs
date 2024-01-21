using System;
namespace ChessGame
{
    class Board
    {
        public int line { get; set; }
        public int column { get; set; }
        private Piece[,] pieces;
        public Board(int line, int column)
        {

            this.line = line;
            this.column = column;
            pieces = new Piece[line, column];
        }
        public Piece setPiece(int line, int column)
        {

            return pieces[line, column];
        }

        public Piece setPiece(Position pos)
        {

            return pieces[pos.line, pos.column];
        }

        public void PushPiece(Piece piece, Position pos)
        {

            if (existPiece(pos))
            {
                throw new BoardException("You can't override positions");
            }
            pieces[pos.line, pos.column] = piece;
            piece.Position = pos;

        }
        public Piece RemovePiece(Position pos)
        {

            if (setPiece(pos) == null)
            {
                return null;
            }

            Piece ax = setPiece(pos);
            ax.Position = null;
            pieces[pos.line, pos.column] = null;
            return ax;
        }
        public bool existPiece(Position pos)
        {

            validatePositionError(pos);
            return setPiece(pos) != null;
        }

        public bool validatePosition(Position pos)
        {
            if (pos.line < 0 || pos.line >= line || pos.column < 0 || pos.column >= column)
            {
                return false;
            }
            return true;
        }
        public void validatePositionError(Position pos)
        {

            if (!validatePosition(pos))
            {
                throw new BoardException("Invalide position");
            }
        }

    }

}