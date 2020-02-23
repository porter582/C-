using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace Assignment2
{
    public partial class DiceGame : Form
    {
        /// <summary>
        /// variable declaration and
        /// declaration of list used in the
        /// rich text box to calculate face, frequency,
        /// percent, and num of times guessed by user
        /// </summary>
        int numWins = 0;
        int numLosses = 0;
        double numGames = 0;
        List<int> face = new List<int>() {1, 2, 3, 4, 5, 6};
        List<double> frequency = new List<double>() {0, 0, 0, 0, 0, 0};
        List<double> percent = new List<double>() {0.0, 0.0, 0.0, 0.0, 0.0, 0.0};
        List<int> numberofTimesGuessed = new List<int>() {0, 0, 0, 0, 0, 0};

        public DiceGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method runs the random dice game
        /// everytime the button is clicked
        /// it keeps track of the score and the user input
        /// in the textbox,
        /// along with the random number
        /// </summary>
        /// <param name="sender">OnClick method</param>
        /// <param name="e">OnClick method</param>
        private void button1_Click(object sender, EventArgs e)
        {
            Random rndNumber = new Random(); //makes the random number
            int iRandNum = 0;
            string suserInput = userText.Text; //takes user input as string
            int userInput = 0;
            bool valid = false;
            lError.Text = null;

            while (valid == false)
            {
                if (!Int32.TryParse(suserInput, out userInput))
                {
                    lError.Text = "Invalid Input";
                    return;
                }
                else if (userInput < 1 || userInput > 6)
                {
                    lError.Text = "Number must be between 1 and 6";
                    return;
                }
                else
                {
                    valid = true;
                }
            }


            DieImage.SizeMode = PictureBoxSizeMode.StretchImage;

            for (int i = 1; i < 7; i++)
            {
                iRandNum = rndNumber.Next(1, 7); //makes our rand num stay between 1 and 7
                DieImage.Image = Image.FromFile("die" + iRandNum.ToString() + ".gif");
                DieImage.Refresh();
                Thread.Sleep(300);
            }

            if (userInput == iRandNum)
            {
                //increment num wins
                numWins++;
            }
            else
            {
                //increment num losses
                numLosses++;
            }
            //increment num games
            numGames++;
            
            //prints the results of each game 
            Pout.Text = numGames.ToString();
            Wout.Text = numWins.ToString();
            Lout.Text = numLosses.ToString();
            resultsBox.Text = null;
            
            frequency[iRandNum - 1]++; // calculates frequency of the dice face rolled
            for (int i = 0; i < 6; i++)
            {
                percent[i] = (frequency[i] / numGames) * 100; //calculates percentage rolled
            }
            numberofTimesGuessed[userInput - 1]++; // calculates number of time guessed by user

            resultsBox.Text += "Face\t Frequency\t Percent\t Number of Times Guessed\n";

            for (int i = 0; i < 6; i++) //prints results for each face of the die and number of times guessed by user
            {
                resultsBox.Text += face[i].ToString().PadRight(25) + "\t" + frequency[i].ToString().PadRight(30) + "\t" + percent[i].ToString("####0.00") + "%".PadRight(30) + "\t" + numberofTimesGuessed[i] + "\n";
            }
            resultsBox.SelectionTabs = new int[] { 75, 200, 300 }; //formatting rich text box stuff
            resultsBox.AcceptsTab = true;
            resultsBox.SelectAll();

        }

        /// <summary>
        /// This is the reset button method
        /// it resets all of the stats and clears
        /// all boxes with information
        /// </summary>
        /// <param name="sender">OnClick method</param>
        /// <param name="e">OnClick method</param>
        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 6; i++) // sets everything in rich text box to 0
            {
                frequency[i] = 0;
                percent[i] = 0;
                numberofTimesGuessed[i] = 0;
            }
            numWins = 0;
            numLosses = 0;
            numGames = 0;
            DieImage.Image = null;
            Pout.Text = null;
            Wout.Text = null;
            Lout.Text = null;
            userText.Text = null;
            lError.Text = null;
            resultsBox.Text = null;
        }
    }

}
