using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    public enum PLAYER
    // Enumeration class to keep track of players.
    {
        Yellow,
        Red
    }
    class NameOfPlayer
    // Creates a class to contain players names.
    {
        public static string playerNameOne;
        public static string playerNameTwo;
    }
    class Board
    // Creates a class that creates and manages the game board.
    {
        // Variables.
        public const int row = 6;
        public const int col = 7;
        public int rowHolder;
        string empty = "O";
        string[,] board = new string[row, col];
        public string currentTurn = PLAYER.Yellow.ToString();
        public bool win = false;

        public void NextTurn()
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

        public int updateBoard(int _col)
        // Updates the game board based on the players coloumn selection.
        {
            // Sets rows to -1 to account for negative numbers.
            rowHolder = -1;
            // Iterates through the array to and places a piece starting at row 6.
            for (int i = 5; i >= 0; i--)
               {
                // Checks to see if the space is empty and sets the row to the current space.
                 if (board[i,_col] == empty && i > rowHolder)
                  {
                    // Sets row to the current position of the piece.
                     rowHolder = i;
                     board[rowHolder, _col] = currentTurn;
                  }
                }
            // Returns the row of the piece.
            return rowHolder;
        }

        public void checkWin()
        {
            // check veritcal win.
            for(int i = 0; i < row - 3; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    if(board[i,j] == currentTurn && board[i+1,j] == currentTurn && board[i+2,j] == currentTurn && board[i+3,j] == currentTurn)
                    {
                        win = true;
                    }
                }
            }
            // Horizontal Win.
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col - 3; j++)
                {
                    if (board[i, j] == currentTurn && board[i, j+1] == currentTurn && board[i, j+2] == currentTurn && board[i, j+3] == currentTurn)
                    {
                        win = true;
                    }
                }
            }
            // Down diagonal win.
            for (int i = 0; i <= row-4; i++)
            {
                for (int j = 0; j <= col-4; j++)
                {
                    if (board[i, j] == currentTurn && board[i+1, j + 1] == currentTurn && board[i+2, j + 2] == currentTurn && board[i+3, j + 3] == currentTurn)
                    {
                        win = true;
                    }
                }
            }
            // Up diagonal win.
            for (int i = 3; i <= row-1; i++)
            {
                for (int j = 0; j <= col-4; j++)
                {
                    if (board[i, j] == currentTurn && board[i-1, j + 1] == currentTurn && board[i-2, j + 2] == currentTurn && board[i-3, j + 3] == currentTurn)
                    {
                        win = true;
                    }
                }
            }
        }

        public void resetGame()
         // Resets the game board and varables.
        {
            initializeBoard();
            currentTurn = PLAYER.Yellow.ToString();
            win = false;
        }

    }
}
