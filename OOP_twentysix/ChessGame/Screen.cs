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
                    if (board.setPiece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        PrintPiece(board.setPiece(i, j));

                        Console.Write(" ");
                    }
                    j++;
                }
                Console.WriteLine();
            }
            Console.WriteLine(" a b c d e f g h");
        }
        public static void PrintPiece(Piece piece)
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
        }
    }

}