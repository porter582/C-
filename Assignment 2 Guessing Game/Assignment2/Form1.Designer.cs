namespace Assignment2
{
    partial class DiceGame
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
            this.rollB = new System.Windows.Forms.Button();
            this.resetB = new System.Windows.Forms.Button();
            this.TPlayed = new System.Windows.Forms.Label();
            this.Twon = new System.Windows.Forms.Label();
            this.TLoss = new System.Windows.Forms.Label();
            this.resultsBox = new System.Windows.Forms.RichTextBox();
            this.Guess = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.DieImage = new System.Windows.Forms.PictureBox();
            this.Pout = new System.Windows.Forms.Label();
            this.Wout = new System.Windows.Forms.Label();
            this.Lout = new System.Windows.Forms.Label();
            this.lError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DieImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rollB
            // 
            this.rollB.Location = new System.Drawing.Point(303, 184);
            this.rollB.Name = "rollB";
            this.rollB.Size = new System.Drawing.Size(75, 23);
            this.rollB.TabIndex = 0;
            this.rollB.Text = "Roll";
            this.rollB.UseVisualStyleBackColor = true;
            this.rollB.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetB
            // 
            this.resetB.Location = new System.Drawing.Point(303, 232);
            this.resetB.Name = "resetB";
            this.resetB.Size = new System.Drawing.Size(75, 23);
            this.resetB.TabIndex = 1;
            this.resetB.Text = "Reset";
            this.resetB.UseVisualStyleBackColor = true;
            this.resetB.Click += new System.EventHandler(this.button2_Click);
            // 
            // TPlayed
            // 
            this.TPlayed.AutoSize = true;
            this.TPlayed.Location = new System.Drawing.Point(6, 21);
            this.TPlayed.Name = "TPlayed";
            this.TPlayed.Size = new System.Drawing.Size(157, 17);
            this.TPlayed.TabIndex = 2;
            this.TPlayed.Text = "Number of times played";
            // 
            // Twon
            // 
            this.Twon.AutoSize = true;
            this.Twon.Location = new System.Drawing.Point(6, 49);
            this.Twon.Name = "Twon";
            this.Twon.Size = new System.Drawing.Size(140, 17);
            this.Twon.TabIndex = 3;
            this.Twon.Text = "Number of times won";
            // 
            // TLoss
            // 
            this.TLoss.AutoSize = true;
            this.TLoss.Location = new System.Drawing.Point(9, 77);
            this.TLoss.Name = "TLoss";
            this.TLoss.Size = new System.Drawing.Size(137, 17);
            this.TLoss.TabIndex = 4;
            this.TLoss.Text = "Number of times lost";
            // 
            // resultsBox
            // 
            this.resultsBox.Location = new System.Drawing.Point(12, 275);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(776, 163);
            this.resultsBox.TabIndex = 5;
            this.resultsBox.Text = "";
            // 
            // Guess
            // 
            this.Guess.AutoSize = true;
            this.Guess.Location = new System.Drawing.Point(23, 184);
            this.Guess.Name = "Guess";
            this.Guess.Size = new System.Drawing.Size(121, 17);
            this.Guess.TabIndex = 6;
            this.Guess.Text = "Enter a guess 1-6";
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(151, 184);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(100, 22);
            this.userText.TabIndex = 7;
            // 
            // DieImage
            // 
            this.DieImage.Location = new System.Drawing.Point(496, 40);
            this.DieImage.Name = "DieImage";
            this.DieImage.Size = new System.Drawing.Size(181, 115);
            this.DieImage.TabIndex = 8;
            this.DieImage.TabStop = false;
            // 
            // Pout
            // 
            this.Pout.AutoSize = true;
            this.Pout.Location = new System.Drawing.Point(195, 11);
            this.Pout.Name = "Pout";
            this.Pout.Size = new System.Drawing.Size(0, 17);
            this.Pout.TabIndex = 9;
            // 
            // Wout
            // 
            this.Wout.AutoSize = true;
            this.Wout.Location = new System.Drawing.Point(195, 49);
            this.Wout.Name = "Wout";
            this.Wout.Size = new System.Drawing.Size(0, 17);
            this.Wout.TabIndex = 10;
            // 
            // Lout
            // 
            this.Lout.AutoSize = true;
            this.Lout.Location = new System.Drawing.Point(195, 87);
            this.Lout.Name = "Lout";
            this.Lout.Size = new System.Drawing.Size(0, 17);
            this.Lout.TabIndex = 11;
            // 
            // lError
            // 
            this.lError.AutoSize = true;
            this.lError.Location = new System.Drawing.Point(23, 238);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(0, 17);
            this.lError.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TPlayed);
            this.groupBox1.Controls.Add(this.Twon);
            this.groupBox1.Controls.Add(this.Lout);
            this.groupBox1.Controls.Add(this.TLoss);
            this.groupBox1.Controls.Add(this.Wout);
            this.groupBox1.Controls.Add(this.Pout);
            this.groupBox1.Location = new System.Drawing.Point(28, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 111);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Info";
            // 
            // DiceGame
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lError);
            this.Controls.Add(this.DieImage);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.Guess);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.resetB);
            this.Controls.Add(this.rollB);
            this.Name = "DiceGame";
            this.Text = "DiceGame";
            ((System.ComponentModel.ISupportInitialize)(this.DieImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollB;
        private System.Windows.Forms.Button resetB;
        private System.Windows.Forms.Label TPlayed;
        private System.Windows.Forms.Label Twon;
        private System.Windows.Forms.Label TLoss;
        private System.Windows.Forms.RichTextBox resultsBox;
        private System.Windows.Forms.Label Guess;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.PictureBox DieImage;
        private System.Windows.Forms.Label Pout;
        private System.Windows.Forms.Label Wout;
        private System.Windows.Forms.Label Lout;
        private System.Windows.Forms.Label lError;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

