using System;
namespace ChessGame
{
    class ChessMatch
    {
        public Board Boar { get; protected set; }
        public int Turn { get; protected set; }
        public Color PlayerTurn { get; protected set; }
        public bool Ended { get; private set; }
        private HashSet<Piece> pieces;
        private HashSet<Piece> capturedPieces;


        public ChessMatch()
        {

            Boar = new Board(8, 8);
            Turn = 1;
            PlayerTurn = Color.White;
            pieces = [];
            capturedPieces = [];
            PushPiece();
        }

        public void ExecuteTurn(Position origin, Position destiny)
        {
            Movement(origin, destiny);
            Turn++;
            ChangePlayer();
        }

        public void ValidateOriginPosition(Position p)
        {
            if (Boar.setPiece(p) == null)
            {
                throw new BoardException("Empty position");
            }
            if (PlayerTurn != Boar.setPiece(p).color)
            {
                throw new BoardException("Wrong choice, this piece is not your's");
            }
            if (!Boar.setPiece(p).isPossibleToMove())
            {
                throw new BoardException("This piece can't move because other allies pieces are in they way");
            }
        }

        public void ValidateDestinyPosition(Position origin, Position destiny)
        {
            if (!Boar.setPiece(origin).IsAbleToMoveThere(destiny))
            {
                throw new BoardException("Invalide destiny position");
            }
        }
        private void ChangePlayer()
        {
            if (PlayerTurn == Color.White)
            {
                PlayerTurn = Color.Black;
            }
            else PlayerTurn = Color.White;
        }

        public void Movement(Position origin, Position destiny)
        {

            Piece p = Boar.RemovePiece(origin);
            p.IncrementMovementQnt();
            Piece capturedPiece = Boar.RemovePiece(destiny);
            Boar.PushPiece(p, destiny);
            if (capturedPiece != null) capturedPieces.Add(capturedPiece);

        }

        public void pushNewPiece(char column, int line, Piece piece)
        {
            Boar.PushPiece(piece, new PositionChess(column, line).ToPosition());
            pieces.Add(piece);

        }

        public HashSet<Piece> PiecesCaptured(Color color)
        {
            HashSet<Piece> he = [];
            foreach (Piece x in capturedPieces)
            {
                if (x.color == color)
                {
                    he.Add(x);
                }
            }
            return he;
        }

        public HashSet<Piece> PiecesInGame(Color color)
        {
            HashSet<Piece> he = [];
            foreach (Piece x in capturedPieces)
            {
                if (x.color == color)
                {
                    he.Add(x);
                }
            }
            he.ExceptWith(PiecesCaptured(color));
            return he;

        }
        private void PushPiece()
        {
            pushNewPiece('c', 1, new Tower(Boar, Color.Black));
            pushNewPiece('c', 2, new Tower(Boar, Color.Black));
            pushNewPiece('e', 1, new Tower(Boar, Color.Black));
            pushNewPiece('e', 2, new Tower(Boar, Color.Black));
            pushNewPiece('d', 2, new Tower(Boar, Color.Black));
            pushNewPiece('d', 1, new King(Boar, Color.Black));

            pushNewPiece('c', 7, new Tower(Boar, Color.White));
            pushNewPiece('c', 8, new Tower(Boar, Color.White));
            pushNewPiece('d', 7, new Tower(Boar, Color.White));
            pushNewPiece('e', 7, new Tower(Boar, Color.White));
            pushNewPiece('e', 8, new Tower(Boar, Color.White));
            pushNewPiece('d', 8, new King(Boar, Color.White));

        }

    }

}