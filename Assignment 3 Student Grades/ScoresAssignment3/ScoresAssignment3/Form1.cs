using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoresAssignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// sNumStuds is a string that holds 
        /// the number of students to later 
        /// be converted to an int numStudents
        /// </summary>
        string sNumStuds;
        int numStudents = 0;
        /// <summary>
        /// sNumAssigns is a string that holds 
        /// the number of students to later 
        /// be converted to an int numAssignments
        /// </summary>
        string sNumAssigns;
        int numAssignments = 0;
        /// <summary>
        /// studentArr holds the number of students
        /// </summary>
        string[] studentArr;
        /// <summary>
        /// multiArr holds the the number of students
        /// and number of assignments then assigns
        /// a score to each assignment
        /// </summary>
        int[,] multiArr;
        /// <summary>
        /// currentStud is to keep track of which
        /// student we are on in the studentArr
        /// </summary>
        int currentStud = 0;
        /// <summary>
        /// sAssignNumBox is a string that takes the
        /// user input for assignment number
        /// then converts it to the int
        /// iAssignNumBox
        /// </summary>
        string sAssignNumBox;
        int iAssignNumBox = 0;
        /// <summary>
        /// sAssignScoreBox is a string that takes the
        /// user input for score then converts it to the int
        /// iAssignScoreBox
        /// </summary>
        string sAssignScoreBox;
        int iAssignScoreBox = 0;
        /// <summary>
        /// valid tests to make sure we have valid
        /// input from the user
        /// </summary>
        bool valid = false;
        /// <summary>
        /// average gets the average of all assignment scores
        /// </summary>
        double average = 0;
        /// <summary>
        /// grade is the letter grade
        /// based on average
        /// </summary>
        string grade;
        /// <summary>
        /// info tests to make sure the user
        /// has put in a number of students
        /// and number of assignments
        /// </summary>
        bool info = false;

        /// <summary>
        /// Submit counts allows the user the set
        /// the number of students and number of assignments
        /// which initializes the studentarr and multiarr
        /// arrays it also checks for valid input
        /// </summary>
        /// <param name="sender">N/A</param>
        /// <param name="e">N/A</param>
        private void SubmitCounts_Click(object sender, EventArgs e)
        {
            sNumStuds = NumStudents.Text; //assigns user input to a string variable
            sNumAssigns = numberOfAssignments.Text;

            while (valid == false)
            {
                if (!Int32.TryParse(sNumStuds, out numStudents)) //validates input
                {
                    lError.Text = "Invalid Input";
                    return;
                }
                else if (numStudents < 1 || numStudents > 10)
                {
                    lError.Text = "Number must be between 1 and 10";
                    return;
                }
                else
                {
                    lError.Text = ":";
                    valid = true;
                }
            }
            valid = false;

            while (valid == false)
            {
                if (!Int32.TryParse(sNumAssigns, out numAssignments)) //validates input
                {
                    aError.Text = "Invalid Input";
                    return;
                }
                else if (numAssignments < 1 || numAssignments > 99)
                {
                    aError.Text = "Number must be between 1 and 99";
                    return;
                }
                else
                {
                    valid = true;
                    aError.Text = ":";
                }
            }
            valid = false;
            studentArr = new string[numStudents];
            multiArr = new int[numStudents, numAssignments];

            for (int i = 0; i < studentArr.Length; i++)
            {
                studentArr[i] = "Student #" + " " + (i + 1);
            }

            for (int i = 0; i < numStudents; i++)
            {
                for (int j = 0; j < numAssignments; j++)
                {
                    multiArr[i, j] = 0;
                }
            }

            assignmentScoreNums.Text = "Enter assignments 1 - " + sNumAssigns; //prints the number of assignments
            lStudNum.Text = studentArr[0]; //sets lstudnum text to default student
            currentStud = 0;
            info = true; //we have information submitted

        }

        /// <summary>
        /// Reset Click method resets all values in the program
        /// it resets all boxes and values along with reseting the arrays
        /// </summary>
        /// <param name="sender">N/A</param>
        /// <param name="e">N/A</param>
        private void Reset_Click(object sender, EventArgs e)
        {
            if (info == true)
            {
                numStudents = 0;
                numAssignments = 0;
                Array.Clear(studentArr, 0, studentArr.Length);
                for (int i = 0; i < studentArr.Length; i++)
                {
                    studentArr[i] = "Student #" + " " + (i + 1);
                }
                Array.Clear(multiArr, 0, multiArr.Length);
                for (int i = 0; i < numStudents; i++)
                {
                    for (int j = 0; j < numAssignments; j++)
                    {
                        multiArr[i, j] = 0;
                    }
                }

                average = 0;
                currentStud = 0;
                grade = null;
                sAssignNumBox = null;
                sAssignScoreBox = null;
                lStudNum.Text = "Student #0";
                assignmentScoreNums.Text = "Enter Assignment number X-X";
                richTextBox1.Text = null;
                lError.Text = ":";
                aError.Text = ":";
                studError.Text = ":";
                assignError.Text = ":";
                scoreError.Text = ":";
                NumStudents.Text = null;
                numberOfAssignments.Text = null;
                studentInfoUp.Text = null;
                assignmentNumBox.Text = null;
                assignmentScoreBox.Text = null;
            }

        }

        /// <summary>
        /// Checks to make sure we have students
        /// then goes to the first student in the array
        /// </summary>
        /// <param name="sender">N/A</param>
        /// <param name="e">N/A</param>
        private void FirstStudent_Click(object sender, EventArgs e)
        {
            if (info == true)
            {
                lStudNum.Text = studentArr[0];
                currentStud = 1;
            }
        }

        /// <summary>
        /// Checks to make sure we arent out of bounds
        /// and to make sure we have information to use
        /// then moves to the previous position in the student array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrevStud_Click(object sender, EventArgs e)
        {
            if(currentStud > 0 && info == true)
            {
                currentStud--;
                lStudNum.Text = studentArr[currentStud];
            }
        }

        /// <summary>
        /// Checks to make sure we arent out of bounds
        /// and to make sure we have information to use
        /// then moves to the next position in the student array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextStud_Click(object sender, EventArgs e)
        {
            if (info == true && currentStud < studentArr.Length - 1)
            {
                currentStud++;
                lStudNum.Text = studentArr[currentStud];
            }
        }

        /// <summary>
        /// Checks to make sure we have students
        /// then goes to the last student in the array
        /// </summary>
        /// <param name="sender">N/A</param>
        /// <param name="e">N/A</param>
        private void LastStud_Click(object sender, EventArgs e)
        {
            if (info == true)
            {
                lStudNum.Text = studentArr.Last();
                currentStud = studentArr.Length - 1;
            }
        }

        /// <summary>
        /// Allows the user to update the value in the
        /// student array to anything instead of just
        /// leaving the default value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentSave_Click(object sender, EventArgs e)
        {
            if (info == true)
            {
                studentArr[currentStud] = studentInfoUp.Text;
            }
        }

        /// <summary>
        /// Allows user to update the multiarray with the
        /// assignment grade for each assignmnet for each student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveScore_Click(object sender, EventArgs e)
        {
            if (info == true)
            {
                sAssignNumBox = assignmentNumBox.Text; //assigns values for assignmnet number 
                sAssignScoreBox = assignmentScoreBox.Text; //value for assignmnet score

                while (valid == false)
                {
                    if (!Int32.TryParse(sAssignNumBox, out iAssignNumBox))//validates user input
                    {
                        assignError.Text = "Invalid Input";
                        return;
                    }
                    else
                    {
                        valid = true;
                        assignError.Text = ":";
                    }
                }

                valid = false;

                while (valid == false)
                {
                    if (!Int32.TryParse(sAssignScoreBox, out iAssignScoreBox)) //validates user input
                    {
                        scoreError.Text = "Invalid Input";
                        return;
                    }
                    else
                    {
                        valid = true;
                        scoreError.Text = ":";
                    }
                }

                valid = false;

                try
                {
                    multiArr[currentStud, iAssignNumBox - 1] = iAssignScoreBox;
                }
                catch (System.IndexOutOfRangeException) //if array goes out of bounds nothing will update
                {

                    return;
                }
            }
        }

        /// <summary>
        /// displays all of the student info and grades
        /// for each assignment along with the average 
        /// and letter grade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayScores_Click(object sender, EventArgs e)
        {
            if (info == true)
            {
                for (int i = 0; i < multiArr.GetLength(0); i++)
                {
                    richTextBox1.Text += studentArr[i] + "\t"; //prints the student value in student array
                    for (int j = 0; j < multiArr.GetLength(1); j++)
                    {
                        average += multiArr[i, j];
                        richTextBox1.Text += "Assignment#" + (j + 1) + ": " + multiArr[i, j] + "\t"; //prints assignment number and value
                    }

                    average = Convert.ToDouble(average / numAssignments); //gets average casts to double
                    if (average > 93)// if statements to determine letter grade
                    {
                        grade = "A";
                    }
                    else if (average < 93 && average > 90)
                    {
                        grade = "A-";
                    }
                    else if (average < 90 && average > 87)
                    {
                        grade = "B+";
                    }
                    else if (average < 87 && average > 83)
                    {
                        grade = "B";
                    }
                    else if (average < 83 && average > 80)
                    {
                        grade = "B-";
                    }
                    else if (average < 80 && average > 77)
                    {
                        grade = "C+";
                    }
                    else if (average < 77 && average > 73)
                    {
                        grade = "C";
                    }
                    else if (average < 73 && average > 70)
                    {
                        grade = "C-";
                    }
                    else if (average < 70 && average > 67)
                    {
                        grade = "D+";
                    }
                    else if (average < 67 && average > 63)
                    {
                        grade = "D";
                    }
                    else if (average < 63 && average > 60)
                    {
                        grade = "D-";
                    }
                    else if (average < 60)
                    {
                        grade = "F";
                    }
                    richTextBox1.Text += "Average\t" + average + "\t";
                    richTextBox1.Text += "Grade\t" + grade;
                    richTextBox1.Text += "\n";
                    average = 0;
                }
            }
        }
    }
}
