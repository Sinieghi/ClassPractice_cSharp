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
            this.pieces = new Piece[line, column];
        }
        public Piece peace(int line, int column)
        {
            return pieces[line, column];
        }

    }

}