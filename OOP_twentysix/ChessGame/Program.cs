using System;
namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board(4, 4);
            Console.WriteLine(b);
            Screen.PrintBoard(b);
        }
    }

}