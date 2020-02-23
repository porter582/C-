namespace TikTacToe
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
            this.HoriSep = new System.Windows.Forms.Label();
            this.topLeft = new System.Windows.Forms.Label();
            this.topMid = new System.Windows.Forms.Label();
            this.topRight = new System.Windows.Forms.Label();
            this.midLeft = new System.Windows.Forms.Label();
            this.midMid = new System.Windows.Forms.Label();
            this.midRight = new System.Windows.Forms.Label();
            this.botLeft = new System.Windows.Forms.Label();
            this.botMid = new System.Windows.Forms.Label();
            this.botRight = new System.Windows.Forms.Label();
            this.horisep1 = new System.Windows.Forms.Label();
            this.vertisep = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.statBox = new System.Windows.Forms.GroupBox();
            this.lTies = new System.Windows.Forms.Label();
            this.label465 = new System.Windows.Forms.Label();
            this.p2Wins = new System.Windows.Forms.Label();
            this.p1Wins = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.gameStatus = new System.Windows.Forms.GroupBox();
            this.gameStatusLabel = new System.Windows.Forms.Label();
            this.statBox.SuspendLayout();
            this.gameStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // HoriSep
            // 
            this.HoriSep.BackColor = System.Drawing.Color.Black;
            this.HoriSep.Location = new System.Drawing.Point(-6, 291);
            this.HoriSep.Name = "HoriSep";
            this.HoriSep.Size = new System.Drawing.Size(499, 15);
            this.HoriSep.TabIndex = 0;
            this.HoriSep.Text = "label1";
            // 
            // topLeft
            // 
            this.topLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLeft.Location = new System.Drawing.Point(-3, -1);
            this.topLeft.Name = "topLeft";
            this.topLeft.Size = new System.Drawing.Size(161, 142);
            this.topLeft.TabIndex = 1;
            this.topLeft.Click += new System.EventHandler(this.ChoiceClick);
            // 
            // topMid
            // 
            this.topMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topMid.Location = new System.Drawing.Point(178, -1);
            this.topMid.Name = "topMid";
            this.topMid.Size = new System.Drawing.Size(149, 145);
            this.topMid.TabIndex = 2;
            this.topMid.Click += new System.EventHandler(this.ChoiceClick);
            // 
            // topRight
            // 
            this.topRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topRight.Location = new System.Drawing.Point(346, -1);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(147, 145);
            this.topRight.TabIndex = 3;
            this.topRight.Click += new System.EventHandler(this.ChoiceClick);
            // 
            // midLeft
            // 
            this.midLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midLeft.Location = new System.Drawing.Point(-3, 156);
            this.midLeft.Name = "midLeft";
            this.midLeft.Size = new System.Drawing.Size(161, 135);
            this.midLeft.TabIndex = 4;
            this.midLeft.Click += new System.EventHandler(this.ChoiceClick);
            // 
            // midMid
            // 
            this.midMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midMid.Location = new System.Drawing.Point(182, 156);
            this.midMid.Name = "midMid";
            this.midMid.Size = new System.Drawing.Size(145, 135);
            this.midMid.TabIndex = 5;
            this.midMid.Click += new System.EventHandler(this.ChoiceClick);
            // 
            // midRight
            // 
            this.midRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midRight.Location = new System.Drawing.Point(347, 156);
            this.midRight.Name = "midRight";
            this.midRight.Size = new System.Drawing.Size(146, 135);
            this.midRight.TabIndex = 6;
            this.midRight.Click += new System.EventHandler(this.ChoiceClick);
            // 
            // botLeft
            // 
            this.botLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botLeft.Location = new System.Drawing.Point(-3, 306);
            this.botLeft.Name = "botLeft";
            this.botLeft.Size = new System.Drawing.Size(161, 135);
            this.botLeft.TabIndex = 7;
            this.botLeft.Click += new System.EventHandler(this.ChoiceClick);
            // 
            // botMid
            // 
            this.botMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botMid.Location = new System.Drawing.Point(181, 306);
            this.botMid.Name = "botMid";
            this.botMid.Size = new System.Drawing.Size(146, 135);
            this.botMid.TabIndex = 8;
            this.botMid.Click += new System.EventHandler(this.ChoiceClick);
            // 
            // botRight
            // 
            this.botRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botRight.Location = new System.Drawing.Point(347, 306);
            this.botRight.Name = "botRight";
            this.botRight.Size = new System.Drawing.Size(146, 142);
            this.botRight.TabIndex = 9;
            this.botRight.Click += new System.EventHandler(this.ChoiceClick);
            // 
            // horisep1
            // 
            this.horisep1.BackColor = System.Drawing.Color.Black;
            this.horisep1.Location = new System.Drawing.Point(-6, 141);
            this.horisep1.Name = "horisep1";
            this.horisep1.Size = new System.Drawing.Size(499, 15);
            this.horisep1.TabIndex = 10;
            this.horisep1.Text = "label1";
            // 
            // vertisep
            // 
            this.vertisep.BackColor = System.Drawing.Color.Black;
            this.vertisep.Location = new System.Drawing.Point(324, -1);
            this.vertisep.Name = "vertisep";
            this.vertisep.Size = new System.Drawing.Size(26, 459);
            this.vertisep.TabIndex = 12;
            this.vertisep.Text = "label1";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(155, -1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 459);
            this.label9.TabIndex = 13;
            this.label9.Text = "label1";
            // 
            // statBox
            // 
            this.statBox.Controls.Add(this.lTies);
            this.statBox.Controls.Add(this.label465);
            this.statBox.Controls.Add(this.p2Wins);
            this.statBox.Controls.Add(this.p1Wins);
            this.statBox.Controls.Add(this.label11);
            this.statBox.Controls.Add(this.label10);
            this.statBox.Location = new System.Drawing.Point(517, 13);
            this.statBox.Name = "statBox";
            this.statBox.Size = new System.Drawing.Size(200, 131);
            this.statBox.TabIndex = 14;
            this.statBox.TabStop = false;
            this.statBox.Text = "Stats";
            // 
            // lTies
            // 
            this.lTies.AutoSize = true;
            this.lTies.Location = new System.Drawing.Point(59, 94);
            this.lTies.Name = "lTies";
            this.lTies.Size = new System.Drawing.Size(16, 17);
            this.lTies.TabIndex = 5;
            this.lTies.Text = "0";
            // 
            // label465
            // 
            this.label465.AutoSize = true;
            this.label465.Location = new System.Drawing.Point(10, 94);
            this.label465.Name = "label465";
            this.label465.Size = new System.Drawing.Size(35, 17);
            this.label465.TabIndex = 4;
            this.label465.Text = "Ties";
            // 
            // p2Wins
            // 
            this.p2Wins.AutoSize = true;
            this.p2Wins.Location = new System.Drawing.Point(118, 64);
            this.p2Wins.Name = "p2Wins";
            this.p2Wins.Size = new System.Drawing.Size(16, 17);
            this.p2Wins.TabIndex = 3;
            this.p2Wins.Text = "0";
            // 
            // p1Wins
            // 
            this.p1Wins.AutoSize = true;
            this.p1Wins.Location = new System.Drawing.Point(118, 33);
            this.p1Wins.Name = "p1Wins";
            this.p1Wins.Size = new System.Drawing.Size(16, 17);
            this.p1Wins.TabIndex = 2;
            this.p1Wins.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Player 2 Wins";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Player 1 Wins";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(576, 167);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // gameStatus
            // 
            this.gameStatus.Controls.Add(this.gameStatusLabel);
            this.gameStatus.Location = new System.Drawing.Point(527, 291);
            this.gameStatus.Name = "gameStatus";
            this.gameStatus.Size = new System.Drawing.Size(200, 100);
            this.gameStatus.TabIndex = 16;
            this.gameStatus.TabStop = false;
            this.gameStatus.Text = "Game Status";
            // 
            // gameStatusLabel
            // 
            this.gameStatusLabel.AutoSize = true;
            this.gameStatusLabel.Location = new System.Drawing.Point(7, 22);
            this.gameStatusLabel.Name = "gameStatusLabel";
            this.gameStatusLabel.Size = new System.Drawing.Size(31, 17);
            this.gameStatusLabel.TabIndex = 0;
            this.gameStatusLabel.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameStatus);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.statBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.vertisep);
            this.Controls.Add(this.horisep1);
            this.Controls.Add(this.botRight);
            this.Controls.Add(this.botMid);
            this.Controls.Add(this.botLeft);
            this.Controls.Add(this.midRight);
            this.Controls.Add(this.midMid);
            this.Controls.Add(this.midLeft);
            this.Controls.Add(this.topRight);
            this.Controls.Add(this.topMid);
            this.Controls.Add(this.topLeft);
            this.Controls.Add(this.HoriSep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statBox.ResumeLayout(false);
            this.statBox.PerformLayout();
            this.gameStatus.ResumeLayout(false);
            this.gameStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HoriSep;
        private System.Windows.Forms.Label topLeft;
        private System.Windows.Forms.Label topMid;
        private System.Windows.Forms.Label topRight;
        private System.Windows.Forms.Label midLeft;
        private System.Windows.Forms.Label midMid;
        private System.Windows.Forms.Label midRight;
        private System.Windows.Forms.Label botLeft;
        private System.Windows.Forms.Label botMid;
        private System.Windows.Forms.Label botRight;
        private System.Windows.Forms.Label horisep1;
        private System.Windows.Forms.Label vertisep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox statBox;
        private System.Windows.Forms.Label p2Wins;
        private System.Windows.Forms.Label p1Wins;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox gameStatus;
        private System.Windows.Forms.Label gameStatusLabel;
        private System.Windows.Forms.Label lTies;
        private System.Windows.Forms.Label label465;
    }
}

