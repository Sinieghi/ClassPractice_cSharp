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
                    try
                    {
                        // Console.Clear();
                        Screen.PrintMatch(game);

                        Console.WriteLine();
                        Console.WriteLine("Origin: ");
                        Position origin = Screen.ReadPositionChess().ToPosition();
                        game.ValidateOriginPosition(origin);

                        bool[,] possiblePosition = game.Boar.setPiece(origin).PossibleMovements();

                        // Console.Clear();
                        Screen.PrintBoard(game.Boar, possiblePosition);

                        Console.WriteLine("Destiny: ");
                        Position destiny = Screen.ReadPositionChess().ToPosition();
                        game.ValidateDestinyPosition(origin, destiny);

                        game.ExecuteTurn(origin, destiny);
                    }
                    catch (BoardException e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }

                // Console.Clear();
                Screen.PrintMatch(game);

            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}