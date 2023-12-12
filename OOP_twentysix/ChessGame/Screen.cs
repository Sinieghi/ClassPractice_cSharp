using System;
namespace ChessGame
{
    class Screen
    {
        public static void PrintBoard(Board board)
        {
            Console.WriteLine($"{board.column} {board.line}");

            for (int i = 0; i < board.line; i++)
            {
                int j = 0;
                Console.Write(8 - i + " ");
                while (j < board.column)
                {
                    PrintPiece(board.setPiece(i, j));
                    j++;
                }
                Console.WriteLine();
            }
            Console.WriteLine(" a b c d e f g h");
        }

        public static void PrintBoard(Board board, bool[,] possiblePoss)
        {
            ConsoleColor background = Console.BackgroundColor;
            ConsoleColor newColor = ConsoleColor.Green;

            for (int i = 0; i < board.line; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.column; j++)
                {

                    if (possiblePoss[i, j])
                    {
                        Console.BackgroundColor = newColor;
                    }
                    else Console.BackgroundColor = background;
                    PrintPiece(board.setPiece(i, j));
                    Console.BackgroundColor = background;
                }
                Console.WriteLine();
            }
            Console.WriteLine(" a b c d e f g h");
            Console.BackgroundColor = background;
        }

        public static PositionChess ReadPositionChess()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int line = int.Parse(s[1] + "");
            return new PositionChess(column, line);
        }
        public static void PrintPiece(Piece piece)
        {
            if (piece == null)
            {
                Console.Write("- ");
            }
            else
            {

                if (piece.color == Color.White)
                {
                    Console.Write(piece);
                }
                else
                {
                    ConsoleColor ax = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(piece);
                    Console.ForegroundColor = ax;
                }
                Console.Write(" ");

            }
        }

        public static void PrintMatch(ChessMatch match)
        {
            PrintBoard(match.Boar);
            PrintCapturedPieces(match);
            Console.WriteLine();
            Console.WriteLine("Turn: " + match.Turn);
            if (!match.Ended)
            {


                Console.WriteLine("Waiting current player: " + match.PlayerTurn);
                if (match.Checkmate)
                {

                    Console.WriteLine("Check");
                }
            }
            else
            {
                Console.WriteLine("Checkmate");
                Console.WriteLine("Winner: " + match.PlayerTurn);
            }
        }
        public static void PrintCapturedPieces(ChessMatch game)
        {
            Console.WriteLine("Captured pieces: ");
            Console.WriteLine("White: ");
            PrintSetOfPieces(game.PiecesCaptured(Color.White));
            Console.WriteLine();
            Console.WriteLine("Black: ");
            PrintSetOfPieces(game.PiecesCaptured(Color.Black));
        }
        public static void PrintSetOfPieces(HashSet<Piece> set)
        {
            Console.Write("[");
            foreach (Piece x in set)
            {
                Console.Write(x + " ");
            }
            Console.Write("]");
        }
    }

}