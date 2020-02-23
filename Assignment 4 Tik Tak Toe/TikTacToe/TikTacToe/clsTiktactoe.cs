using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTacToe
{
    /// <summary>
    /// This class determines the winning move
    /// of the tictactoe game, it checks what kind of win
    /// the user has and also determines if there is a tie
    /// </summary>
    public class clsTiktactoe
    {
        /// <summary>
        /// board is a multidimensional array that
        /// will be loaded with the multiBoard array
        /// in main, this is how we will find the 
        /// win and tie scenarios
        /// </summary>
        public string[,] board;

        /// <summary>
        /// enum WinningMove just sets a 
        /// value do determine where the win is located
        /// </summary>
        public enum WinningMove //enum for determining where the win is located
        {
            Row1,
            Row2,
            Row3,
            Col1,
            Col2,
            Col3,
            Diag1,
            Diag2
        }
        public WinningMove winningMove; //determines what kind of winning move

        /// <summary>
        /// IsWinningMove tests all of the possible win
        /// scenarios, this is called after the player
        /// selects their choice
        /// </summary>
        /// <returns></returns>
        public bool IsWinningMove()
        {
            if (isHoriWin() || isVertWin() || isDiagonalWin()) //tests each scenario for a winning move
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// isDiagonalWin tests the two diagonal options
        /// to see if there is a win in those positions
        /// </summary>
        /// <returns></returns>
        private bool isDiagonalWin()
        {
            if (board[1, 1] != null && board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2]) //topLeft, midMid, botRight. Labels
            {
                winningMove = WinningMove.Diag1;
                return true;
            }
            else if (board[1, 1] != null && board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0]) // topRight, midMid, botLeft. Labels
            {
                winningMove = WinningMove.Diag2;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// isVertWin tests all of the verticle
        /// options for a win scenario
        /// </summary>
        /// <returns></returns>
        private bool isVertWin()
        {
            if (board[1, 0] != null && board[0, 0] == board[1, 0] && board[0, 0] == board[2, 0]) //topLeft, midLeft, botLeft. Labels
            {
                winningMove = WinningMove.Col1;
                return true;
            }
            else if (board[1, 1] != null && board[0, 1] == board[1, 1] && board[0, 1] == board[2, 1]) // topMid, midMid, botMid. Labels
            {
                winningMove = WinningMove.Col2;
                return true;
            }
            else if (board[1, 2] != null && board[0, 2] == board[1, 2] && board[0, 2] == board[2, 2]) // topRight, midRight, botRight. Labels
            {
                winningMove = WinningMove.Col3;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// isHoriWin tests all of the horizontal
        /// possible wins within the array
        /// </summary>
        /// <returns></returns>
        private bool isHoriWin()
        {
            if (board[0, 1] != null && board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2]) //topLeft, topMid, topRight. Labels
            {
                winningMove = WinningMove.Row1;
                return true;
            }
            else if (board[1, 1] != null && board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2]) //midLeft, midMid, midRight. Labels
            {
                winningMove = WinningMove.Row2;
                return true;
            }
            else if (board[2, 1] != null && board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2]) //botLeft, botMid, botRight. Labels
            {
                winningMove = WinningMove.Row3;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// isTie tests to make sure the board
        /// is completely full and if non of the
        /// win scenarios work then the game is
        /// over and a tie occurs
        /// </summary>
        /// <returns></returns>
        public bool isTie()
        {
            if(isDiagonalWin() == false && isHoriWin() == false && isVertWin() == false) //checks to make sure the win scenarios are false
            {
                if (board[0, 0] != null && board[0, 1] != null && board[0, 2] != null && 
                    board[1, 0] != null && board[1, 1] != null && board[1, 2] != null &&
                    board[2, 0] != null && board[2, 1] != null && board[2, 2] != null) //makes sure the entire board is full
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
