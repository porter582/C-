using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    /// <summary>
    /// this class will allow the user to
    /// add new people to the data base
    /// </summary>
    public partial class addPerson : Form
    {
        public addPerson()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this method will save the user
        /// info to the database
        /// </summary>
        /// <param name="sender">N/A</param>
        /// <param name="e">N/A</param>
        private void savebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// this method just closes the addPerson window
        /// </summary>
        /// <param name="sender">N/A</param>
        /// <param name="e">N/A</param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
