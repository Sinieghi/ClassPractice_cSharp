using System;
namespace ChessGame
{
    class Screen
    {
        public static void PrintBoard(Board board)
        {
            for (int i = 0; i < board.line; i++)
            {
                int j = 0;
                while (j < board.column)
                {
                    if (board.peace(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                        Console.WriteLine(board.peace(i, j) + " ");
                    j++;
                }
                Console.WriteLine();
            }
        }
    }

}