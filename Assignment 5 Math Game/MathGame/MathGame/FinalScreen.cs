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
    public partial class FinalScreen : Form
    {
        MainMenu mainMenu;
        GameInfo gameInfo;
        public FinalScreen(int wins, int losses, GameInfo game, int time)
        {
            gameInfo = game;
            mainMenu = new MainMenu();
            InitializeComponent();
            Wins.Text = wins.ToString();
            Losses.Text = losses.ToString();
            firstNameL.Text = gameInfo.firstName;
            lastNameL.Text = gameInfo.lastName;
            ageL.Text = gameInfo.age.ToString();
            timerLbl.Text = time.ToString();

            if(wins <= 4)
            {
                bad.Visible = true;
                Med.Visible = false;
                good.Visible = false;
            }
            else if(wins >= 5 && wins <= 7)
            {
                bad.Visible = false;
                Med.Visible = true;
                good.Visible = false;
            }
            else
            {
                bad.Visible = false;
                Med.Visible = false;
                good.Visible = true;
            }
        }
    }
}
