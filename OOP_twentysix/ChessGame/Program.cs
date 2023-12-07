using System;
using System.Data.Common;
using System.Diagnostics;
namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessMatch game = new ChessMatch();
                while (!game.Ended)
                {
                    // Console.Clear();
                    Screen.PrintBoard(game.Boar);
                    Console.WriteLine("Origin: ");
                    Position origin = Screen.ReadPositionChess().ToPosition();
                    bool[,] possiblePosition = game.Boar.setPiece(origin).PossibleMovements();

                    // Console.Clear();
                    Screen.PrintBoard(game.Boar, possiblePosition);

                    Console.WriteLine("Destiny: ");
                    Position destiny = Screen.ReadPositionChess().ToPosition();
                    game.Movement(origin, destiny);
                }
                Screen.PrintBoard(game.Boar);
            }
            catch (BoardException e)
            {
                Console.WriteLine(e);
            }
        }
    }

}