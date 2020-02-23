namespace MathGame
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.rAdd = new System.Windows.Forms.RadioButton();
            this.rSubtract = new System.Windows.Forms.RadioButton();
            this.rMultiply = new System.Windows.Forms.RadioButton();
            this.rDivide = new System.Windows.Forms.RadioButton();
            this.Submit = new System.Windows.Forms.Button();
            this.fNameErr = new System.Windows.Forms.Label();
            this.lNameErr = new System.Windows.Forms.Label();
            this.bubbleErr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.ageBoxErr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(110, 99);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(100, 22);
            this.FirstNameBox.TabIndex = 3;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(110, 133);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(100, 22);
            this.LastNameBox.TabIndex = 4;
            // 
            // rAdd
            // 
            this.rAdd.AutoSize = true;
            this.rAdd.Location = new System.Drawing.Point(12, 219);
            this.rAdd.Name = "rAdd";
            this.rAdd.Size = new System.Drawing.Size(54, 21);
            this.rAdd.TabIndex = 6;
            this.rAdd.TabStop = true;
            this.rAdd.Text = "Add";
            this.rAdd.UseVisualStyleBackColor = true;
            this.rAdd.CheckedChanged += new System.EventHandler(this.rAdd_CheckedChanged);
            // 
            // rSubtract
            // 
            this.rSubtract.AutoSize = true;
            this.rSubtract.Location = new System.Drawing.Point(129, 219);
            this.rSubtract.Name = "rSubtract";
            this.rSubtract.Size = new System.Drawing.Size(82, 21);
            this.rSubtract.TabIndex = 7;
            this.rSubtract.TabStop = true;
            this.rSubtract.Text = "Subtract";
            this.rSubtract.UseVisualStyleBackColor = true;
            this.rSubtract.CheckedChanged += new System.EventHandler(this.rSubtract_CheckedChanged);
            // 
            // rMultiply
            // 
            this.rMultiply.AutoSize = true;
            this.rMultiply.Location = new System.Drawing.Point(12, 255);
            this.rMultiply.Name = "rMultiply";
            this.rMultiply.Size = new System.Drawing.Size(76, 21);
            this.rMultiply.TabIndex = 8;
            this.rMultiply.TabStop = true;
            this.rMultiply.Text = "Multiply";
            this.rMultiply.UseVisualStyleBackColor = true;
            this.rMultiply.CheckedChanged += new System.EventHandler(this.rMultiply_CheckedChanged);
            // 
            // rDivide
            // 
            this.rDivide.AutoSize = true;
            this.rDivide.Location = new System.Drawing.Point(129, 255);
            this.rDivide.Name = "rDivide";
            this.rDivide.Size = new System.Drawing.Size(68, 21);
            this.rDivide.TabIndex = 9;
            this.rDivide.TabStop = true;
            this.rDivide.Text = "Divide";
            this.rDivide.UseVisualStyleBackColor = true;
            this.rDivide.CheckedChanged += new System.EventHandler(this.rDivide_CheckedChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(12, 338);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 10;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // fNameErr
            // 
            this.fNameErr.Location = new System.Drawing.Point(241, 99);
            this.fNameErr.Name = "fNameErr";
            this.fNameErr.Size = new System.Drawing.Size(226, 23);
            this.fNameErr.TabIndex = 10;
            // 
            // lNameErr
            // 
            this.lNameErr.Location = new System.Drawing.Point(244, 137);
            this.lNameErr.Name = "lNameErr";
            this.lNameErr.Size = new System.Drawing.Size(223, 23);
            this.lNameErr.TabIndex = 11;
            // 
            // bubbleErr
            // 
            this.bubbleErr.Location = new System.Drawing.Point(16, 297);
            this.bubbleErr.Name = "bubbleErr";
            this.bubbleErr.Size = new System.Drawing.Size(299, 23);
            this.bubbleErr.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Age";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(110, 171);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(100, 22);
            this.ageBox.TabIndex = 5;
            // 
            // ageBoxErr
            // 
            this.ageBoxErr.Location = new System.Drawing.Point(247, 175);
            this.ageBoxErr.Name = "ageBoxErr";
            this.ageBoxErr.Size = new System.Drawing.Size(220, 23);
            this.ageBoxErr.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 236);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ageBoxErr);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bubbleErr);
            this.Controls.Add(this.lNameErr);
            this.Controls.Add(this.fNameErr);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.rDivide);
            this.Controls.Add(this.rMultiply);
            this.Controls.Add(this.rSubtract);
            this.Controls.Add(this.rAdd);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.RadioButton rAdd;
        private System.Windows.Forms.RadioButton rSubtract;
        private System.Windows.Forms.RadioButton rMultiply;
        private System.Windows.Forms.RadioButton rDivide;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label fNameErr;
        private System.Windows.Forms.Label lNameErr;
        private System.Windows.Forms.Label bubbleErr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label ageBoxErr;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

