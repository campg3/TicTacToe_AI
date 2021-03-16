using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TicTacToe versus AI");
            Game game = new Game();
            while (!game.GameOver)
            {
                game.MakeMove();
            }
            game.AnnounceWinner();
            Console.WriteLine(game.GameOver);
            
        }
    }
}
