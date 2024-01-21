using System;
using System.Xml.Linq;
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
            Piece R = King(color) ?? throw new BoardException("There is no King " + color);
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

            if (TestCheckmate(Adversary(PlayerTurn)))
            {
                Ended = true;
            }

            else
            {
                Turn++;
                ChangePlayer();
            }
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

            //roque
            if (p is King && destiny.column == origin.column + 2)
            {
                Position TwrOrigin = new(origin.line, origin.column + 3);
                Position TwrDestiny = new(origin.line, origin.column + 1);
                Piece T = Boar.RemovePiece(TwrDestiny);
                T.DecreaseMovementQnt();
                Boar.PushPiece(T, TwrOrigin);
            }

            //big roque
            if (p is King && destiny.column == origin.column - 2)
            {
                Position TwrOrigin = new(origin.line, origin.column - 4);
                Position TwrDestiny = new(origin.line, origin.column - 1);
                Piece T = Boar.RemovePiece(TwrDestiny);
                T.DecreaseMovementQnt();
                Boar.PushPiece(T, TwrOrigin);
            }
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

            Piece piece = Boar.RemovePiece(origin);
            piece.IncrementMovementQnt();
            Piece capturedPiece = Boar.RemovePiece(destiny);
            Boar.PushPiece(piece, destiny);
            if (capturedPiece != null) capturedPieces.Add(capturedPiece);

            //roque
            if (piece is King && destiny.column == origin.column + 2)
            {
                Position TwrOrigin = new(origin.line, origin.column + 3);
                Position TwrDestiny = new(origin.line, origin.column + 1);
                Piece T = Boar.RemovePiece(TwrOrigin);
                T.IncrementMovementQnt();
                Boar.PushPiece(T, TwrDestiny);
            }

            //big roque
            if (piece is King && destiny.column == origin.column - 2)
            {
                Position TwrOrigin = new(origin.line, origin.column - 4);
                Position TwrDestiny = new(origin.line, origin.column - 1);
                Piece T = Boar.RemovePiece(TwrOrigin);
                T.IncrementMovementQnt();
                Boar.PushPiece(T, TwrDestiny);
            }
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
            foreach (Piece x in pieces)
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


        public bool TestCheckmate(Color color)
        {
            if (!IsCheckmate(color))
            {
                return false;
            }
            foreach (Piece x in PiecesInGame(color))
            {
                bool[,] m = x.PossibleMovements();
                for (int i = 0; i < Boar.line; i++)
                {
                    for (int j = 0; j < Boar.column; j++)
                    {
                        if (m[i, j])
                        {
                            Position origin = x.Position;
                            Position destiny = new(i, j);
                            Piece capturedPice = Movement(origin, destiny);
                            bool TestCheckmate = IsCheckmate(color);
                            UndoMovement(origin, destiny, capturedPice);
                            if (!TestCheckmate)
                            {
                                return false;
                            }
                        }

                    }
                }
            }
            return true;
        }

        private void PushPiece()
        {

            pushNewPiece('a', 1, new Tower(Boar, Color.Black));
            pushNewPiece('b', 1, new Horse(Boar, Color.Black));
            pushNewPiece('c', 1, new Bishop(Boar, Color.Black));
            pushNewPiece('d', 1, new Queen(Boar, Color.Black));
            pushNewPiece('e', 1, new King(Boar, Color.Black, this));
            pushNewPiece('f', 1, new Bishop(Boar, Color.Black));
            pushNewPiece('g', 1, new Horse(Boar, Color.Black));
            pushNewPiece('h', 1, new Tower(Boar, Color.Black));
            pushNewPiece('a', 2, new Pawn(Boar, Color.Black));
            pushNewPiece('b', 2, new Pawn(Boar, Color.Black));
            pushNewPiece('c', 2, new Pawn(Boar, Color.Black));
            pushNewPiece('d', 2, new Pawn(Boar, Color.Black));
            pushNewPiece('e', 2, new Pawn(Boar, Color.Black));
            pushNewPiece('f', 2, new Pawn(Boar, Color.Black));
            pushNewPiece('g', 2, new Pawn(Boar, Color.Black));
            pushNewPiece('h', 2, new Pawn(Boar, Color.Black));

            pushNewPiece('a', 8, new Tower(Boar, Color.White));
            pushNewPiece('b', 8, new Horse(Boar, Color.White));
            pushNewPiece('c', 8, new Bishop(Boar, Color.White));
            pushNewPiece('d', 8, new Queen(Boar, Color.White));
            pushNewPiece('e', 8, new King(Boar, Color.White, this));
            pushNewPiece('f', 8, new Bishop(Boar, Color.White));
            pushNewPiece('g', 8, new Horse(Boar, Color.White));
            pushNewPiece('h', 8, new Tower(Boar, Color.White));
            pushNewPiece('a', 7, new Pawn(Boar, Color.White));
            pushNewPiece('b', 7, new Pawn(Boar, Color.White));
            pushNewPiece('c', 7, new Pawn(Boar, Color.White));
            pushNewPiece('d', 7, new Pawn(Boar, Color.White));
            pushNewPiece('e', 7, new Pawn(Boar, Color.White));
            pushNewPiece('f', 7, new Pawn(Boar, Color.White));
            pushNewPiece('g', 7, new Pawn(Boar, Color.White));
            pushNewPiece('h', 7, new Pawn(Boar, Color.White));

        }

    }

}