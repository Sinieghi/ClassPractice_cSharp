using System;
namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board b = new Board(8, 8);

                b.PushPiece(new Tower(b, Color.Black), new Position(0, 0));
                b.PushPiece(new Tower(b, Color.Black), new Position(1, 3));
                b.PushPiece(new King(b, Color.Black), new Position(2, 4));
                b.PushPiece(new King(b, Color.Black), new Position(0, 0));
                Screen.PrintBoard(b);
            }
            catch (BoardException e)
            {
                Console.WriteLine(e);
            }
        }
    }

}