using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Main : Form
    {
        bool bubble = false;
        bool add = false;
        bool sub = false;
        bool mult = false;
        bool div = false;

        GameScreen gameScreen;
        GameInfo gameInfo;
        public Main()
        {
            InitializeComponent();

            gameInfo = new GameInfo();
        }

        private void rAdd_CheckedChanged(object sender, EventArgs e)
        {
            bubble = true;
            gameInfo.gAdd();
        }

        private void rMultiply_CheckedChanged(object sender, EventArgs e)
        {
            bubble = true;
            gameInfo.gMult();
        }

        private void rSubtract_CheckedChanged(object sender, EventArgs e)
        {
            bubble = true;
            gameInfo.gSub();
        }

        private void rDivide_CheckedChanged(object sender, EventArgs e)
        {
            bubble = true;
            gameInfo.gDiv();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string sAge = ageBox.Text;
            int iAge = 0;
            if (FirstNameBox.Text == "")
            {
                fNameErr.ForeColor = Color.Red;
                fNameErr.Text = "Please Enter First Name";
            }
            else
            {
                fNameErr.Text = "";
            }
            if(LastNameBox.Text == "")
            {
                lNameErr.ForeColor = Color.Red;
                lNameErr.Text = "Please Enter Last Name";
            }
            else
            {
                lNameErr.Text = "";
            }

            if(ageBox.Text == "")
            {
                ageBoxErr.ForeColor = Color.Red;
                ageBoxErr.Text = "Please Enter Age Between 3-10";
            }
            else if (!Int32.TryParse(sAge, out iAge))
            {
                ageBoxErr.ForeColor = Color.Red;
                ageBoxErr.Text = "Please Enter Age Between 3-10";
            }
            else if(Int32.TryParse(sAge, out iAge))
            {
                if (iAge < 3 || iAge > 10)
                {
                    ageBoxErr.ForeColor = Color.Red;
                    ageBoxErr.Text = "Please Enter Age Between 3-10";
                }
            }
            else
            {
                ageBoxErr.Text = "";
            }
            if(bubble != true)
            {
                bubbleErr.ForeColor = Color.Red;
                bubbleErr.Text = "Please select the type of game";
            }
            else
            {
                bubbleErr.Text = "";
            }
            if (FirstNameBox.Text != "" && LastNameBox.Text != "" && ageBox.Text != "" && bubble == true && iAge >= 3 && iAge <= 10)
            {
                gameInfo.gSubmitInfo(FirstNameBox.Text, LastNameBox.Text, iAge);
                this.Hide();
                gameScreen = new GameScreen(gameInfo);
                gameScreen.Show();

            }
        }
    }
}
