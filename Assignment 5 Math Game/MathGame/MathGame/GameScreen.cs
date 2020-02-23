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


namespace MathGame
{
    public partial class GameScreen : Form
    {
        System.Windows.Forms.Timer myTimer;
        GameInfo gInfo;
        int num1 = 0;
        int num2 = 0;
        int count = 1;
        int wins = 0;
        int losses = 0;
        int result = 0;
        int time = 0;
        string sResult;
        FinalScreen finalScreen;
        CalcClass calcClass;

        public GameScreen(GameInfo gameInfo)
        {
            gInfo = gameInfo;
            calcClass = new CalcClass();
            InitializeComponent();
            myTimer = new System.Windows.Forms.Timer();
            myTimer.Interval = 1000;
            myTimer.Tick += MyTimer_Tick;
        }

        void MyTimer_Tick(object sender, EventArgs e)
        {
            time++;
            timeLbl.Text = time.ToString();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            myTimer.Start();
            startButton.Hide();
            num1 = calcClass.createRand();
            Thread.Sleep(100);
            num2 = calcClass.createRand();

            if (gInfo.gType == 1)
            {
                    num1 = calcClass.createRand();
                    Thread.Sleep(100);
                    num2 = calcClass.createRand();
                signLbl.Text = "+";
            }
            else if (gInfo.gType == 2)
            {
                while (calcClass.validRand(num1, num2, gInfo) == false)
                {
                    num1 = calcClass.createRand();
                    Thread.Sleep(100);
                    num2 = calcClass.createRand();
                }
                signLbl.Text = "-";
            }
            else if (gInfo.gType == 3)
            {
                    num1 = calcClass.createRand();
                    Thread.Sleep(100);
                    num2 = calcClass.createRand();
                signLbl.Text = "*";
            }
            else if (gInfo.gType == 4)
            {
                while (calcClass.validRand(num1, num2, gInfo) == false)
                {
                    num1 = calcClass.createRand();
                    Thread.Sleep(100);
                    num2 = calcClass.createRand();
                }
                signLbl.Text = "/";
            }
            Randnum1.Text = num1.ToString();
            Randnum2.Text = num2.ToString();
        }

        private void nextQuestion_Click(object sender, EventArgs e)
        {
            sResult = Answer.Text;
            if (!Int32.TryParse(sResult, out result))
            {
                Error.Text = "Error";
            }
            else
            {
                Int32.TryParse(sResult, out result);
                if (calcClass.solResult(num1, num2, gInfo, result) == true)
                {
                    Luke.Visible = true;
                    Vader.Visible = false;
                    correctOr.Text = "Correct!";
                    wins++;
                }
                else
                {
                    Vader.Visible = true;
                    Luke.Visible = false;
                    correctOr.Text = "Incorrect :(";
                    losses++;
                }

                if (count == 10)
                {
                    myTimer.Stop();
                    finalScreen = new FinalScreen(wins, losses, gInfo, time);
                    this.Hide();
                    finalScreen.Show();
                }
                startButton.Hide();

                num1 = calcClass.createRand();
                Thread.Sleep(100);
                num2 = calcClass.createRand();
                if (gInfo.gType == 1)
                {
                    num1 = calcClass.createRand();
                    Thread.Sleep(100);
                    num2 = calcClass.createRand();
                }
                else if (gInfo.gType == 2)
                {
                    while (calcClass.validRand(num1, num2, gInfo) == false)
                    {
                        num1 = calcClass.createRand();
                        Thread.Sleep(100);
                        num2 = calcClass.createRand();
                    }
                }
                else if (gInfo.gType == 3)
                {
                    num1 = calcClass.createRand();
                    Thread.Sleep(100);
                    num2 = calcClass.createRand();
                }
                else if (gInfo.gType == 4)
                {
                    while (calcClass.validRand(num1, num2, gInfo) == false)
                    {
                        num1 = calcClass.createRand();
                        Thread.Sleep(100);
                        num2 = calcClass.createRand();
                    }
                }
                Randnum1.Text = num1.ToString();
                Randnum2.Text = num2.ToString();
                count++;
                Answer.Text = null;
            }
        }
    }
}
