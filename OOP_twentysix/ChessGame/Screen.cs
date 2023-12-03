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
                while (j < board.column - 1)
                {
                    if (board.setPiece(i, j) == null)
                    {
                        Console.Write(" - ");
                    }
                    else
                    {
                        Console.Write(board.setPiece(i, j) + " - ");
                    }
                    j++;
                }
                Console.WriteLine(" ");
            }
        }
    }

}