namespace MathGame
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.startButton = new System.Windows.Forms.Button();
            this.signLbl = new System.Windows.Forms.Label();
            this.Randnum1 = new System.Windows.Forms.Label();
            this.Randnum2 = new System.Windows.Forms.Label();
            this.nextQuestion = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.correctOr = new System.Windows.Forms.Label();
            this.Luke = new System.Windows.Forms.PictureBox();
            this.Vader = new System.Windows.Forms.PictureBox();
            this.timeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Luke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vader)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(12, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(267, 125);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // signLbl
            // 
            this.signLbl.Location = new System.Drawing.Point(48, 162);
            this.signLbl.Name = "signLbl";
            this.signLbl.Size = new System.Drawing.Size(100, 23);
            this.signLbl.TabIndex = 1;
            // 
            // Randnum1
            // 
            this.Randnum1.AutoSize = true;
            this.Randnum1.Location = new System.Drawing.Point(12, 162);
            this.Randnum1.Name = "Randnum1";
            this.Randnum1.Size = new System.Drawing.Size(46, 17);
            this.Randnum1.TabIndex = 2;
            this.Randnum1.Text = "label1";
            // 
            // Randnum2
            // 
            this.Randnum2.AutoSize = true;
            this.Randnum2.Location = new System.Drawing.Point(80, 162);
            this.Randnum2.Name = "Randnum2";
            this.Randnum2.Size = new System.Drawing.Size(46, 17);
            this.Randnum2.TabIndex = 3;
            this.Randnum2.Text = "label2";
            // 
            // nextQuestion
            // 
            this.nextQuestion.Location = new System.Drawing.Point(270, 162);
            this.nextQuestion.Name = "nextQuestion";
            this.nextQuestion.Size = new System.Drawing.Size(75, 23);
            this.nextQuestion.TabIndex = 4;
            this.nextQuestion.Text = "Submit";
            this.nextQuestion.UseVisualStyleBackColor = true;
            this.nextQuestion.Click += new System.EventHandler(this.nextQuestion_Click);
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(154, 159);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(100, 22);
            this.Answer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Location = new System.Drawing.Point(126, 193);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(46, 17);
            this.Error.TabIndex = 7;
            this.Error.Text = "label2";
            // 
            // correctOr
            // 
            this.correctOr.AutoSize = true;
            this.correctOr.Location = new System.Drawing.Point(9, 193);
            this.correctOr.Name = "correctOr";
            this.correctOr.Size = new System.Drawing.Size(46, 17);
            this.correctOr.TabIndex = 8;
            this.correctOr.Text = "label2";
            // 
            // Luke
            // 
            this.Luke.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Luke.BackgroundImage")));
            this.Luke.Location = new System.Drawing.Point(316, 257);
            this.Luke.Name = "Luke";
            this.Luke.Size = new System.Drawing.Size(109, 181);
            this.Luke.TabIndex = 10;
            this.Luke.TabStop = false;
            this.Luke.Visible = false;
            // 
            // Vader
            // 
            this.Vader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Vader.BackgroundImage")));
            this.Vader.Location = new System.Drawing.Point(12, 257);
            this.Vader.Name = "Vader";
            this.Vader.Size = new System.Drawing.Size(258, 181);
            this.Vader.TabIndex = 11;
            this.Vader.TabStop = false;
            this.Vader.Visible = false;
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(286, 13);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(46, 17);
            this.timeLbl.TabIndex = 12;
            this.timeLbl.Text = "label2";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 456);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.Vader);
            this.Controls.Add(this.Luke);
            this.Controls.Add(this.correctOr);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.nextQuestion);
            this.Controls.Add(this.Randnum2);
            this.Controls.Add(this.Randnum1);
            this.Controls.Add(this.signLbl);
            this.Controls.Add(this.startButton);
            this.Name = "GameScreen";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.Luke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label signLbl;
        private System.Windows.Forms.Label Randnum1;
        private System.Windows.Forms.Label Randnum2;
        private System.Windows.Forms.Button nextQuestion;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Label correctOr;
        private System.Windows.Forms.PictureBox Luke;
        private System.Windows.Forms.PictureBox Vader;
        private System.Windows.Forms.Label timeLbl;
    }
}