using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    class Board
    {
        enum PLAYER
        {
            Yellow,
            Red
        }

        // Variables.
        public const int row = 6;
        public const int col = 7;
        public int rowHolder;
        string empty = "O";
        string[,] board = new string[row, col];
        string currentTurn = PLAYER.Yellow.ToString();

        public void Turn()
        // Checks for current player then switches to the next.
        {
            if (currentTurn == PLAYER.Yellow.ToString())
            {
                currentTurn = PLAYER.Red.ToString();
            }
            else
            {
                currentTurn = PLAYER.Yellow.ToString();
            }
        }

        public void initializeBoard()
        // Creates board to check for win.
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    board[i, j] = empty;
                }
            }
        }

        public void updateBoard(int _col)
        {
            rowHolder = 6;
            if (currentTurn == PLAYER.Yellow.ToString())
            {
                if (board[rowHolder - 1, col - 1] != empty)
                {
                    rowHolder -= 1;
                }
                else
                {
                    board[rowHolder - 1, col - 1] = currentTurn;
                    Turn();
                }
            }
        }
    }
}
