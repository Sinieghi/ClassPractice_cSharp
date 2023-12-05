using System;
namespace ChessGame
{
    class ChessMatch
    {
        public Board Boar { get; protected set; }
        private readonly int Turn;
        private readonly Color PlayerTurn;
        public bool Ended { get; private set; }

        public ChessMatch()
        {
            Boar = new Board(8, 8);
            Turn = 1;
            PlayerTurn = Color.White;
            PushPiece();
        }

        public void Movement(Position origin, Position destiny)
        {
            Piece p = Boar.RemovePiece(origin);
            p.IncrementMovementQnt();
            Piece capturedPiece = Boar.RemovePiece(destiny);
            Boar.PushPiece(p, destiny);

        }

        private void PushPiece()
        {
            Boar.PushPiece(new Tower(Boar, Color.Black), new PositionChess('c', 1).ToPosition());
            Boar.PushPiece(new Tower(Boar, Color.Black), new PositionChess('c', 2).ToPosition());
            Boar.PushPiece(new Tower(Boar, Color.Black), new PositionChess('e', 1).ToPosition());
            Boar.PushPiece(new Tower(Boar, Color.Black), new PositionChess('e', 2).ToPosition());
            Boar.PushPiece(new Tower(Boar, Color.Black), new PositionChess('d', 2).ToPosition());
            Boar.PushPiece(new King(Boar, Color.Black), new PositionChess('d', 1).ToPosition());
            // Boar.PushPiece(new King(Boar, Color.Black), new Position(2, 4));
            // Boar.PushPiece(new Tower(Boar, Color.White), new Position(3, 5));
            Boar.PushPiece(new Tower(Boar, Color.White), new PositionChess('c', 7).ToPosition());
            Boar.PushPiece(new Tower(Boar, Color.White), new PositionChess('c', 8).ToPosition());
            Boar.PushPiece(new Tower(Boar, Color.White), new PositionChess('d', 7).ToPosition());
            Boar.PushPiece(new Tower(Boar, Color.White), new PositionChess('e', 7).ToPosition());
            Boar.PushPiece(new Tower(Boar, Color.White), new PositionChess('e', 8).ToPosition());
            Boar.PushPiece(new King(Boar, Color.White), new PositionChess('d', 8).ToPosition());

        }

    }

}