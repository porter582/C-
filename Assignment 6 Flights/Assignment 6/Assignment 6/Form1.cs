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
    public partial class Form1 : Form
    {
        //List<flight> flightList;
        /// <summary>
        /// this is a list of strings
        /// that will hold the information
        /// about the flight
        /// </summary>
        List<string> myList;

        /// <summary>
        /// object for the flightInfo class
        /// in order to populate the specified
        /// boxes with the database info
        /// </summary>
        flight flightInfo;


        int i = 0;

        /// <summary>
        /// object for the addPerson class
        /// that will be used to add people
        /// to the database
        /// </summary>
        addPerson ap;
        public Form1()
        {
            InitializeComponent();
            myList = new List<string>();
            //flightList = new List<flight>();
            flightInfo = new flight();
            ap = new addPerson();

            try
            {
                foreach (var item in flightInfo.flightNumL) //for every item in the flightInfo.flightNumL list
                {
                    flightBox.Items.Add(item + " " + flightInfo.flightType[i]); //add the item to the flightBox
                    i++;
                }
            }
            catch(Exception e) //catch exception
            {
                errorlbl.Text = e.ToString();
            }
        }

        /// <summary>
        /// this method will display the separate flight
        /// panel and display different people on that flight
        /// in the choosePassenger box
        /// </summary>
        /// <param name="sender">N/A</param>
        /// <param name="e">N/A</param>
        private void flightBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                addPassenger.Enabled = true; //enables the buttons
                deletePassenger.Enabled = true;
                changeSeat.Enabled = true;
                if (flightBox.SelectedIndex == 0) //if the first flight
                {
                    choosePass.Items.Clear(); //clears the current info

                    foreach (string item in flightInfo.getName(0))
                    {
                        choosePass.Items.Add(item); //adds each person that is in the flightInfo.getName method list
                    }

                    choosePass.Enabled = true; //enables the box
                    flightNum.Text = flightInfo.flightNumL[0]; //displays the flight number
                    flight1Panel.Visible = true; //enables the correct flight panel
                    flight2Panel.Visible = false;
                }
                else if (flightBox.SelectedIndex == 1) //second flight
                {
                    choosePass.Items.Clear(); //clears all info
                    foreach (string item in flightInfo.getName(1))
                    {
                        choosePass.Items.Add(item); //adds each person that is in the flightInfo.getName method list
                    }

                    choosePass.Enabled = true; //enables box
                    flightNum2.Text = flightInfo.flightNumL[1]; //displays correct flight num
                    flight2Panel.Visible = true; //displays correct panel
                    flight1Panel.Visible = false;
                }
            }
            catch (Exception a) //catch exception
            {
                errorlbl.Text = a.ToString();
            }
        }

        /// <summary>
        /// this method will just show the form
        /// for the user to eventually be able to 
        /// add passengers to the database
        /// </summary>
        /// <param name="sender">N/A</param>
        /// <param name="e">N/A</param>
        private void addPassenger_Click(object sender, EventArgs e)
        {
            ap.ShowDialog();
        }

        /// <summary>
        /// this method will allow
        /// the user to delete passengers
        /// </summary>
        /// <param name="sender">N/A</param>
        /// <param name="e">N/A</param>
        private void deletePassenger_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// this method will allow the user
        /// to change passenger seats
        /// </summary>
        /// <param name="sender">N/A</param>
        /// <param name="e">N/A</param>
        private void changeSeat_Click(object sender, EventArgs e)
        {

        }
    }
}
