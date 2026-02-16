using System;
using System.Collections.Generic;
using System.Text;

namespace CST_150_Tictactoe.Business
{
    internal class Logic
    {
        // create board
        public int[,] board = new int[3, 3];

        public void ResetBoard()
        {
            for (int r = 0; r < 3; r++)
                for (int c = 0; c < 3; c++)
                    board[r, c] = -1; // empty
        }



        // Check for winner
        public int CheckWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return board[i, 0];
            }

            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return board[0, i];
            }

            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return board[0, 0];

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return board[0, 2];

            return -1; // no winner
        }

  
    }
}

