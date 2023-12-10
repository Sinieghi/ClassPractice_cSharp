using System;
using System.Xml.Schema;
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

        public bool Checkmate { get; private set; }


        public ChessMatch()
        {

            Boar = new Board(8, 8);
            Turn = 1;
            Checkmate = false;
            Ended = false;
            PlayerTurn = Color.White;
            pieces = [];
            capturedPieces = [];
            PushPiece();
        }

        public void ExecuteTurn(Position origin, Position destiny)
        {
            Piece capturedPiece = Movement(origin, destiny);
            if (IsCheckmate(PlayerTurn))
            {
                UndoMovement(origin, destiny, capturedPiece);
                throw new BoardException("You cant CheckMate yourself");
            }

            if (IsCheckmate(Adversary(PlayerTurn)))
            {
                Checkmate = true;
            }
            else
                Checkmate = false;


            Movement(origin, destiny);
            Turn++;
            ChangePlayer();
        }

        public void UndoMovement(Position origin, Position destiny, Piece captured)
        {
            Piece p = Boar.RemovePiece(destiny);
            p.DecreaseMovementQnt();
            if (captured != null)
            {
                Boar.PushPiece(captured, destiny);
                capturedPieces.Remove(captured);
            }
            Boar.PushPiece(p, origin);
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

        public Piece Movement(Position origin, Position destiny)
        {

            Piece p = Boar.RemovePiece(origin);
            p.IncrementMovementQnt();
            Piece capturedPiece = Boar.RemovePiece(destiny);
            Boar.PushPiece(p, destiny);
            if (capturedPiece != null) capturedPieces.Add(capturedPiece);

            return capturedPiece;

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

        private Color Adversary(Color color)
        {
            if (color == Color.White)
            {
                return Color.Black;
            }
            else return Color.White;
        }
        private Piece? King(Color color)
        {
            foreach (Piece x in PiecesInGame(color))
            {
                if (x is King)
                {
                    return x;
                }
            }
            return null;
        }
        public bool IsCheckmate(Color color)
        {
            Piece R = King(color);
            if (R == null) throw new BoardException("There is no Kink " + color);
            foreach (Piece x in PiecesInGame(Adversary(color)))
            {
                bool[,] m = x.PossibleMovements();
                if (m[R.Position.line, R.Position.column])
                {
                    return true;
                }
            }
            return false;
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