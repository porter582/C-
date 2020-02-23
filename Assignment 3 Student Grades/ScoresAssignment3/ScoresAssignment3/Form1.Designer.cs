namespace ScoresAssignment3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numberOfAssignments = new System.Windows.Forms.TextBox();
            this.NumStudents = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitCounts = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LastStud = new System.Windows.Forms.Button();
            this.NextStud = new System.Windows.Forms.Button();
            this.PrevStud = new System.Windows.Forms.Button();
            this.FirstStudent = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.studentInfoUp = new System.Windows.Forms.TextBox();
            this.lStudNum = new System.Windows.Forms.Label();
            this.StudentSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.assignmentScoreBox = new System.Windows.Forms.TextBox();
            this.assignmentNumBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.assignmentScoreNums = new System.Windows.Forms.Label();
            this.SaveScore = new System.Windows.Forms.Button();
            this.DisplayScores = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lError = new System.Windows.Forms.Label();
            this.aError = new System.Windows.Forms.Label();
            this.studError = new System.Windows.Forms.Label();
            this.assignError = new System.Windows.Forms.Label();
            this.scoreError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numberOfAssignments);
            this.groupBox1.Controls.Add(this.NumStudents);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SubmitCounts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Counts";
            // 
            // numberOfAssignments
            // 
            this.numberOfAssignments.Location = new System.Drawing.Point(205, 61);
            this.numberOfAssignments.Name = "numberOfAssignments";
            this.numberOfAssignments.Size = new System.Drawing.Size(100, 22);
            this.numberOfAssignments.TabIndex = 7;
            // 
            // NumStudents
            // 
            this.NumStudents.Location = new System.Drawing.Point(205, 22);
            this.NumStudents.Name = "NumStudents";
            this.NumStudents.Size = new System.Drawing.Size(100, 22);
            this.NumStudents.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Assignments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number Of Students";
            // 
            // SubmitCounts
            // 
            this.SubmitCounts.Location = new System.Drawing.Point(347, 43);
            this.SubmitCounts.Name = "SubmitCounts";
            this.SubmitCounts.Size = new System.Drawing.Size(123, 23);
            this.SubmitCounts.TabIndex = 0;
            this.SubmitCounts.Text = "Submit Counts";
            this.SubmitCounts.UseVisualStyleBackColor = true;
            this.SubmitCounts.Click += new System.EventHandler(this.SubmitCounts_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(663, 55);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LastStud);
            this.groupBox2.Controls.Add(this.NextStud);
            this.groupBox2.Controls.Add(this.PrevStud);
            this.groupBox2.Controls.Add(this.FirstStudent);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 56);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navigate";
            // 
            // LastStud
            // 
            this.LastStud.Location = new System.Drawing.Point(445, 22);
            this.LastStud.Name = "LastStud";
            this.LastStud.Size = new System.Drawing.Size(107, 23);
            this.LastStud.TabIndex = 3;
            this.LastStud.Text = "Last Student";
            this.LastStud.UseVisualStyleBackColor = true;
            this.LastStud.Click += new System.EventHandler(this.LastStud_Click);
            // 
            // NextStud
            // 
            this.NextStud.Location = new System.Drawing.Point(311, 21);
            this.NextStud.Name = "NextStud";
            this.NextStud.Size = new System.Drawing.Size(111, 23);
            this.NextStud.TabIndex = 2;
            this.NextStud.Text = "Next Student";
            this.NextStud.UseVisualStyleBackColor = true;
            this.NextStud.Click += new System.EventHandler(this.NextStud_Click);
            // 
            // PrevStud
            // 
            this.PrevStud.Location = new System.Drawing.Point(164, 21);
            this.PrevStud.Name = "PrevStud";
            this.PrevStud.Size = new System.Drawing.Size(129, 23);
            this.PrevStud.TabIndex = 1;
            this.PrevStud.Text = "Previous Student";
            this.PrevStud.UseVisualStyleBackColor = true;
            this.PrevStud.Click += new System.EventHandler(this.PrevStud_Click);
            // 
            // FirstStudent
            // 
            this.FirstStudent.Location = new System.Drawing.Point(36, 21);
            this.FirstStudent.Name = "FirstStudent";
            this.FirstStudent.Size = new System.Drawing.Size(110, 23);
            this.FirstStudent.TabIndex = 0;
            this.FirstStudent.Text = "First Student";
            this.FirstStudent.UseVisualStyleBackColor = true;
            this.FirstStudent.Click += new System.EventHandler(this.FirstStudent_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.studentInfoUp);
            this.groupBox3.Controls.Add(this.lStudNum);
            this.groupBox3.Controls.Add(this.StudentSave);
            this.groupBox3.Location = new System.Drawing.Point(12, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(558, 56);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Info";
            // 
            // studentInfoUp
            // 
            this.studentInfoUp.Location = new System.Drawing.Point(191, 25);
            this.studentInfoUp.Name = "studentInfoUp";
            this.studentInfoUp.Size = new System.Drawing.Size(100, 22);
            this.studentInfoUp.TabIndex = 2;
            // 
            // lStudNum
            // 
            this.lStudNum.AutoSize = true;
            this.lStudNum.Location = new System.Drawing.Point(33, 25);
            this.lStudNum.Name = "lStudNum";
            this.lStudNum.Size = new System.Drawing.Size(77, 17);
            this.lStudNum.TabIndex = 1;
            this.lStudNum.Text = "Student #0";
            // 
            // StudentSave
            // 
            this.StudentSave.Location = new System.Drawing.Point(361, 21);
            this.StudentSave.Name = "StudentSave";
            this.StudentSave.Size = new System.Drawing.Size(96, 23);
            this.StudentSave.TabIndex = 0;
            this.StudentSave.Text = "Save Name";
            this.StudentSave.UseVisualStyleBackColor = true;
            this.StudentSave.Click += new System.EventHandler(this.StudentSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.assignmentScoreBox);
            this.groupBox4.Controls.Add(this.assignmentNumBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.assignmentScoreNums);
            this.groupBox4.Controls.Add(this.SaveScore);
            this.groupBox4.Location = new System.Drawing.Point(12, 293);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(488, 108);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Student Info";
            // 
            // assignmentScoreBox
            // 
            this.assignmentScoreBox.Location = new System.Drawing.Point(232, 63);
            this.assignmentScoreBox.Name = "assignmentScoreBox";
            this.assignmentScoreBox.Size = new System.Drawing.Size(100, 22);
            this.assignmentScoreBox.TabIndex = 6;
            // 
            // assignmentNumBox
            // 
            this.assignmentNumBox.Location = new System.Drawing.Point(255, 22);
            this.assignmentNumBox.Name = "assignmentNumBox";
            this.assignmentNumBox.Size = new System.Drawing.Size(100, 22);
            this.assignmentNumBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Assignment Score";
            // 
            // assignmentScoreNums
            // 
            this.assignmentScoreNums.AutoSize = true;
            this.assignmentScoreNums.Location = new System.Drawing.Point(23, 22);
            this.assignmentScoreNums.Name = "assignmentScoreNums";
            this.assignmentScoreNums.Size = new System.Drawing.Size(198, 17);
            this.assignmentScoreNums.TabIndex = 1;
            this.assignmentScoreNums.Text = "Enter Assignment number X-X";
            // 
            // SaveScore
            // 
            this.SaveScore.Location = new System.Drawing.Point(361, 45);
            this.SaveScore.Name = "SaveScore";
            this.SaveScore.Size = new System.Drawing.Size(109, 23);
            this.SaveScore.TabIndex = 0;
            this.SaveScore.Text = "Save Score";
            this.SaveScore.UseVisualStyleBackColor = true;
            this.SaveScore.Click += new System.EventHandler(this.SaveScore_Click);
            // 
            // DisplayScores
            // 
            this.DisplayScores.Location = new System.Drawing.Point(634, 338);
            this.DisplayScores.Name = "DisplayScores";
            this.DisplayScores.Size = new System.Drawing.Size(75, 23);
            this.DisplayScores.TabIndex = 5;
            this.DisplayScores.Text = "Display";
            this.DisplayScores.UseVisualStyleBackColor = true;
            this.DisplayScores.Click += new System.EventHandler(this.DisplayScores_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 429);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1340, 216);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // lError
            // 
            this.lError.AutoSize = true;
            this.lError.Location = new System.Drawing.Point(508, 34);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(12, 17);
            this.lError.TabIndex = 7;
            this.lError.Text = ":";
            // 
            // aError
            // 
            this.aError.AutoSize = true;
            this.aError.Location = new System.Drawing.Point(509, 72);
            this.aError.Name = "aError";
            this.aError.Size = new System.Drawing.Size(12, 17);
            this.aError.TabIndex = 8;
            this.aError.Text = ":";
            // 
            // studError
            // 
            this.studError.AutoSize = true;
            this.studError.Location = new System.Drawing.Point(588, 217);
            this.studError.Name = "studError";
            this.studError.Size = new System.Drawing.Size(12, 17);
            this.studError.TabIndex = 9;
            this.studError.Text = ":";
            // 
            // assignError
            // 
            this.assignError.AutoSize = true;
            this.assignError.Location = new System.Drawing.Point(517, 319);
            this.assignError.Name = "assignError";
            this.assignError.Size = new System.Drawing.Size(12, 17);
            this.assignError.TabIndex = 10;
            this.assignError.Text = ":";
            // 
            // scoreError
            // 
            this.scoreError.AutoSize = true;
            this.scoreError.Location = new System.Drawing.Point(517, 361);
            this.scoreError.Name = "scoreError";
            this.scoreError.Size = new System.Drawing.Size(12, 17);
            this.scoreError.TabIndex = 11;
            this.scoreError.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 657);
            this.Controls.Add(this.scoreError);
            this.Controls.Add(this.assignError);
            this.Controls.Add(this.studError);
            this.Controls.Add(this.aError);
            this.Controls.Add(this.lError);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.DisplayScores);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitCounts;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LastStud;
        private System.Windows.Forms.Button NextStud;
        private System.Windows.Forms.Button PrevStud;
        private System.Windows.Forms.Button FirstStudent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lStudNum;
        private System.Windows.Forms.Button StudentSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label assignmentScoreNums;
        private System.Windows.Forms.Button SaveScore;
        private System.Windows.Forms.Button DisplayScores;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox NumStudents;
        private System.Windows.Forms.TextBox studentInfoUp;
        private System.Windows.Forms.TextBox assignmentNumBox;
        private System.Windows.Forms.TextBox assignmentScoreBox;
        private System.Windows.Forms.TextBox numberOfAssignments;
        private System.Windows.Forms.Label lError;
        private System.Windows.Forms.Label aError;
        private System.Windows.Forms.Label studError;
        private System.Windows.Forms.Label assignError;
        private System.Windows.Forms.Label scoreError;
    }
}

