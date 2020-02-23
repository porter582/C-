using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTacToe
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Instance of the clsTiktactoe
        /// </summary>
        clsTiktactoe ticTac;
        /// <summary>
        /// checks to make sure the start button has been clicked
        /// </summary>
        bool started;
        /// <summary>
        /// bool to keep track of which players turn it is
        /// p1Turn and p2Turn
        /// </summary>
        bool p1Turn;
        bool p2Turn;
        /// <summary>
        /// p1Wins is the number of wins for player 1
        /// p2Wins is the number of wins for player 2
        /// </summary>
        int p1Win = 0;
        int p2Win = 0;
        /// <summary>
        /// tie is the number of ties where no one wins
        /// </summary>
        int tie = 0;
        /// <summary>
        /// multi dimensional array to hold the game boad positions
        /// </summary>
        string[,] multiBoard = new string[3, 3];
        public Form1()
        {
            InitializeComponent();
            p1Turn = true;
            p2Turn = false;
            ticTac = new clsTiktactoe();
            started = false;
        }

        /// <summary>
        /// start button to set the bool started to true
        /// clears the screen of colors and labels
        /// also clears the array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startButton_Click(object sender, EventArgs e)
        {
            started = true;
            clearLabels();
            resetColors();
            clearArr();
        }

        /// <summary>
        /// clears all values in multiboard along
        /// with setting ticTac.board (tictacs multi dimensional array)
        /// equal to multiboard once it has been cleared
        /// </summary>
        public void clearArr()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    multiBoard[i, j] = null; 
                }
            }
            ticTac.board = multiBoard;
        }

        /// <summary>
        /// clears all labels of any values
        /// </summary>
        public void clearLabels()
        {
            topLeft.Text = " ";
            topMid.Text = " ";
            topRight.Text = " ";
            midLeft.Text = " ";
            midMid.Text = " ";
            midRight.Text = " ";
            botLeft.Text = " ";
            botMid.Text = " ";
            botRight.Text = " ";
        }

        /// <summary>
        /// resets the colors of the screen
        /// </summary>
        public void resetColors()
        {
            topLeft.BackColor = BackColor = Color.White;
            topMid.BackColor = BackColor = Color.White;
            topRight.BackColor = BackColor = Color.White;
            midLeft.BackColor = BackColor = Color.White;
            midMid.BackColor = BackColor = Color.White;
            midRight.BackColor = BackColor = Color.White;
            botLeft.BackColor = BackColor = Color.White;
            botMid.BackColor = BackColor = Color.White;
            botRight.BackColor = BackColor = Color.White;
        }

        /// <summary>
        /// this method checks to make sure the start
        /// button has been pressed then it sets a Label
        /// to the label that was selected by the user.
        /// This method works for any position on the game 
        /// board to be selected in one method ChoiceClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChoiceClick(object sender, EventArgs e)
        {
            if (started == true)
            { 
                Label selectedLbl = (Label)sender; //determines which label has been picked
                loadArr(selectedLbl); //calls loadArr method
            }
        }

        /// <summary>
        /// loadArr takes care of loading multiBoard
        /// with the value X or O based on which players
        /// turn it is, it also changes the labels background
        /// color based on which players turn it is.
        /// </summary>
        /// <param name="selectedLbl"></param>
        public void loadArr(Label selectedLbl)
        {
            if (p1Turn == true && selectedLbl.Text != "O" && selectedLbl.Text != "X") //player one turn, checks to make sure space isnt taken
            {
                selectedLbl.Text = "X";
                selectedLbl.BackColor = Color.Blue;
                gameStatusLabel.Text = "Turn: Player 1";
                p1Turn = false;
                p2Turn = true;
                if (selectedLbl == topLeft) //loads the corresponding position on the game board into the array
                {
                    multiBoard[0, 0] = "X";
                }
                else if (selectedLbl == topMid)
                {
                    multiBoard[0, 1] = "X";
                }
                else if (selectedLbl == topRight)
                {
                    multiBoard[0, 2] = "X";
                }
                else if (selectedLbl == midLeft)
                {
                    multiBoard[1, 0] = "X";
                }
                else if (selectedLbl == midMid)
                {
                    multiBoard[1, 1] = "X";
                }
                else if (selectedLbl == midRight)
                {
                    multiBoard[1, 2] = "X";
                }
                else if (selectedLbl == botLeft)
                {
                    multiBoard[2, 0] = "X";
                }
                else if (selectedLbl == botMid)
                {
                    multiBoard[2, 1] = "X";
                }
                else if (selectedLbl == botRight)
                {
                    multiBoard[2, 2] = "X";
                }
                ticTac.board = multiBoard; //updates ticTac.board (array) with multiBoard array values
                winningMove();
            }
            else if (p2Turn == true && selectedLbl.Text != "X" && selectedLbl.Text != "O") //player 2 turn checks to make sure space isnt taken
            {
                    selectedLbl.Text = "O";
                    selectedLbl.BackColor = Color.Red;
                    gameStatusLabel.Text = "Turn: Player 2";
                    p2Turn = false;
                    p1Turn = true;
                    if (selectedLbl == topLeft) //loads the corresponding position on the game board into the array
                {
                        multiBoard[0, 0] = "O";
                    }
                    else if (selectedLbl == topMid)
                    {
                        multiBoard[0, 1] = "O";
                    }
                    else if (selectedLbl == topRight)
                    {
                        multiBoard[0, 2] = "O";
                    }
                    else if (selectedLbl == midLeft)
                    {
                        multiBoard[1, 0] = "O";
                    }
                    else if (selectedLbl == midMid)
                    {
                        multiBoard[1, 1] = "O";
                    }
                    else if (selectedLbl == midRight)
                    {
                        multiBoard[1, 2] = "O";
                    }
                    else if (selectedLbl == botLeft)
                    {
                        multiBoard[2, 0] = "O";
                    }
                    else if (selectedLbl == botMid)
                    {
                        multiBoard[2, 1] = "O";
                    }
                    else if (selectedLbl == botRight)
                    {
                        multiBoard[2, 2] = "O";
                    }
                ticTac.board = multiBoard; //updates ticTac.board (array) with multiBoard array values
                winningMove();
            }
        }

        /// <summary>
        /// this method determines if
        /// there is a winning move, 
        /// if so it ends the game 
        /// and increments the correct 
        /// players number of wins
        /// also checks to see if there is a tie
        /// </summary>
        public void winningMove()
        {
            if (p1Turn == true)
            {
                if (ticTac.IsWinningMove())
                {
                    tictacWin();
                    started = false;
                    p1Win++;
                    p1Wins.Text = p1Win.ToString();
                    gameStatusLabel.Text = "Player 1 Wins!!!!!!!";
                }
                else if (ticTac.isTie())
                {
                    started = false;
                    tie++;
                    lTies.Text = tie.ToString();
                    gameStatusLabel.Text = "No One Wins!!!!!!!";
                }
            }
            else if (p2Turn == true)
            {
                if (ticTac.IsWinningMove())
                {
                    tictacWin();
                    started = false;
                    p2Win++;
                    p2Wins.Text = p2Win.ToString();
                    gameStatusLabel.Text = "Player 2 Wins!!!!!!!";
                }
                else if (ticTac.isTie())
                {
                    started = false;
                    tie++;
                    lTies.Text = tie.ToString();
                    gameStatusLabel.Text = "No One Wins!!!!!!!";
                }
            }
        }


        /// <summary>
        /// this method highlights
        /// the winning moves values
        /// in yellow just so we know
        /// where the move is.
        /// </summary>
        public void tictacWin()
        {
            if (ticTac.winningMove == clsTiktactoe.WinningMove.Diag1)
            {
                topLeft.BackColor = Color.Yellow;
                midMid.BackColor = Color.Yellow;
                botRight.BackColor = Color.Yellow;
            }
            else if (ticTac.winningMove == clsTiktactoe.WinningMove.Diag2)
            {
                topRight.BackColor = Color.Yellow;
                midMid.BackColor = Color.Yellow;
                botLeft.BackColor = Color.Yellow;
            }
            else if (ticTac.winningMove == clsTiktactoe.WinningMove.Row1)
            {
                topLeft.BackColor = Color.Yellow;
                topMid.BackColor = Color.Yellow;
                topRight.BackColor = Color.Yellow;
            }
            else if (ticTac.winningMove == clsTiktactoe.WinningMove.Row2)
            {
                midLeft.BackColor = Color.Yellow;
                midMid.BackColor = Color.Yellow;
                midRight.BackColor = Color.Yellow;
            }
            else if (ticTac.winningMove == clsTiktactoe.WinningMove.Row3)
            {
                botLeft.BackColor = Color.Yellow;
                botMid.BackColor = Color.Yellow;
                botRight.BackColor = Color.Yellow;
            }
            else if (ticTac.winningMove == clsTiktactoe.WinningMove.Col1)
            {
                topLeft.BackColor = Color.Yellow;
                midLeft.BackColor = Color.Yellow;
                botLeft.BackColor = Color.Yellow;
            }
            else if (ticTac.winningMove == clsTiktactoe.WinningMove.Col2)
            {
                topMid.BackColor = Color.Yellow;
                midMid.BackColor = Color.Yellow;
                botMid.BackColor = Color.Yellow;
            }
            else if (ticTac.winningMove == clsTiktactoe.WinningMove.Col3)
            {
                topRight.BackColor = Color.Yellow;
                midRight.BackColor = Color.Yellow;
                botRight.BackColor = Color.Yellow;
            }
        }
    }
}
