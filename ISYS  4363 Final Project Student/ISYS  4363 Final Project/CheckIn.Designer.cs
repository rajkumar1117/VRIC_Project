namespace ISYS__4363_Final_Project
{
    partial class CheckIn
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
            this.checkInButton = new System.Windows.Forms.Button();
            this.studentIDTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButtonExisting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkInButton
            // 
            this.checkInButton.Location = new System.Drawing.Point(174, 186);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(75, 23);
            this.checkInButton.TabIndex = 0;
            this.checkInButton.Text = "Check-in";
            this.checkInButton.UseVisualStyleBackColor = true;
            this.checkInButton.Click += new System.EventHandler(this.checkInButton_Click);
            // 
            // studentIDTB
            // 
            this.studentIDTB.Location = new System.Drawing.Point(95, 67);
            this.studentIDTB.Name = "studentIDTB";
            this.studentIDTB.Size = new System.Drawing.Size(100, 20);
            this.studentIDTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID";
            // 
            // backButtonExisting
            // 
            this.backButtonExisting.Location = new System.Drawing.Point(35, 186);
            this.backButtonExisting.Name = "backButtonExisting";
            this.backButtonExisting.Size = new System.Drawing.Size(75, 23);
            this.backButtonExisting.TabIndex = 3;
            this.backButtonExisting.Text = "Back";
            this.backButtonExisting.UseVisualStyleBackColor = true;
            this.backButtonExisting.Click += new System.EventHandler(this.backButtonExisting_Click);
            // 
            // CheckIn
            // 
            this.AcceptButton = this.checkInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.backButtonExisting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentIDTB);
            this.Controls.Add(this.checkInButton);
            this.Name = "CheckIn";
            this.Text = "Student Check-In Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkInButton;
        private System.Windows.Forms.TextBox studentIDTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButtonExisting;
    }
}