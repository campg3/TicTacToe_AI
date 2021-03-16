using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        private const int N_ROWS = 3;
        private const int N_COLS = 3;
        private const String EMPTY_SPACE = " ";
        private String[,] boardState = new String[N_ROWS, N_COLS] { { EMPTY_SPACE, EMPTY_SPACE, EMPTY_SPACE },
                                                                   { EMPTY_SPACE, EMPTY_SPACE, EMPTY_SPACE },
                                                                   { EMPTY_SPACE, EMPTY_SPACE, EMPTY_SPACE } };

        public void Print()
        {
            for (int i = 0; i < N_ROWS; i++)
            {
                Console.Write(" ");
                for (int j = 0; j < N_COLS; j++)
                {
                    Console.Write(boardState[i, j]);
                    if (j != N_COLS-1)
                    {
                        Console.Write("  |  ");
                    }
                }
                Console.WriteLine();
                if (i != N_ROWS - 1)
                {
                    Console.WriteLine("----------------");
                }
            }
        }
    }
}
