using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Game
    {
        Board gameBoard = new Board();
        public Board GameBoard
        {
            get { return gameBoard; }
        }

        public Boolean GameOver { get; set; }

        public void MakeMove()
        {
            return;
        }

        public void AnnounceWinner()
        {
            return;
        }
    }
}
