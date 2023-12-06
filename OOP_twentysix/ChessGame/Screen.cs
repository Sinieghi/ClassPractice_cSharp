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
                while (j < board.column - 1)
                {
                    PrintPiece(board.setPiece(i, j));
                    j++;
                }
                Console.WriteLine();
            }
            Console.WriteLine(" a b c d e f g h");
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

                if (piece.color == Color.Black)
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
    }

}