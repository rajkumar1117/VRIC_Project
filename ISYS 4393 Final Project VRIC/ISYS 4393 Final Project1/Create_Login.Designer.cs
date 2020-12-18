namespace ISYS_4393_Final_Project1
{
    partial class Create_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fNameTB = new System.Windows.Forms.TextBox();
            this.lNameTB = new System.Windows.Forms.TextBox();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.passWordTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.staffRoleTB = new System.Windows.Forms.TextBox();
            this.submitButton1 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // fNameTB
            // 
            this.fNameTB.Location = new System.Drawing.Point(94, 52);
            this.fNameTB.Name = "fNameTB";
            this.fNameTB.Size = new System.Drawing.Size(100, 20);
            this.fNameTB.TabIndex = 4;
            // 
            // lNameTB
            // 
            this.lNameTB.Location = new System.Drawing.Point(94, 92);
            this.lNameTB.Name = "lNameTB";
            this.lNameTB.Size = new System.Drawing.Size(100, 20);
            this.lNameTB.TabIndex = 5;
            // 
            // userNameTB
            // 
            this.userNameTB.Location = new System.Drawing.Point(94, 165);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(100, 20);
            this.userNameTB.TabIndex = 6;
            // 
            // passWordTB
            // 
            this.passWordTB.Location = new System.Drawing.Point(94, 208);
            this.passWordTB.Name = "passWordTB";
            this.passWordTB.PasswordChar = '*';
            this.passWordTB.Size = new System.Drawing.Size(100, 20);
            this.passWordTB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Staff Role";
            // 
            // staffRoleTB
            // 
            this.staffRoleTB.Location = new System.Drawing.Point(94, 128);
            this.staffRoleTB.Name = "staffRoleTB";
            this.staffRoleTB.Size = new System.Drawing.Size(100, 20);
            this.staffRoleTB.TabIndex = 9;
            // 
            // submitButton1
            // 
            this.submitButton1.Location = new System.Drawing.Point(166, 266);
            this.submitButton1.Name = "submitButton1";
            this.submitButton1.Size = new System.Drawing.Size(75, 23);
            this.submitButton1.TabIndex = 10;
            this.submitButton1.Text = "Submit";
            this.submitButton1.UseVisualStyleBackColor = true;
            this.submitButton1.Click += new System.EventHandler(this.submitButton1_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(32, 266);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Create_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 319);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitButton1);
            this.Controls.Add(this.staffRoleTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passWordTB);
            this.Controls.Add(this.userNameTB);
            this.Controls.Add(this.lNameTB);
            this.Controls.Add(this.fNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Create_Login";
            this.Text = "Create VRIC Staff Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fNameTB;
        private System.Windows.Forms.TextBox lNameTB;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.TextBox passWordTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox staffRoleTB;
        private System.Windows.Forms.Button submitButton1;
        private System.Windows.Forms.Button backButton;
    }
}