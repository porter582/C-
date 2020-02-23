namespace Assignment_6
{
    partial class addPerson
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
            this.namelbl = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.lblfirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(1, 9);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(403, 32);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "Please Enter Passenger Name";
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(43, 213);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 1;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(281, 212);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(133, 77);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(100, 22);
            this.firstNameTxt.TabIndex = 3;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(133, 126);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(100, 22);
            this.lastNameTxt.TabIndex = 4;
            // 
            // lblfirst
            // 
            this.lblfirst.AutoSize = true;
            this.lblfirst.Location = new System.Drawing.Point(43, 77);
            this.lblfirst.Name = "lblfirst";
            this.lblfirst.Size = new System.Drawing.Size(84, 17);
            this.lblfirst.TabIndex = 5;
            this.lblfirst.Text = "First Name: ";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(43, 129);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(80, 17);
            this.lblLast.TabIndex = 6;
            this.lblLast.Text = "Last Name:";
            // 
            // addPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 305);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblfirst);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.namelbl);
            this.Name = "addPerson";
            this.Text = "addPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label lblfirst;
        private System.Windows.Forms.Label lblLast;
    }
}