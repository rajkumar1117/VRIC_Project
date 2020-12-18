namespace ISYS__4363_Final_Project
{
    partial class IntroScreen
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
            this.newStudentButton = new System.Windows.Forms.Button();
            this.existingStudentButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newStudentButton
            // 
            this.newStudentButton.Location = new System.Drawing.Point(70, 51);
            this.newStudentButton.Name = "newStudentButton";
            this.newStudentButton.Size = new System.Drawing.Size(229, 85);
            this.newStudentButton.TabIndex = 0;
            this.newStudentButton.Text = "New Student";
            this.newStudentButton.UseVisualStyleBackColor = true;
            this.newStudentButton.Click += new System.EventHandler(this.newStudent_Click);
            // 
            // existingStudentButtom
            // 
            this.existingStudentButtom.Location = new System.Drawing.Point(70, 189);
            this.existingStudentButtom.Name = "existingStudentButtom";
            this.existingStudentButtom.Size = new System.Drawing.Size(229, 85);
            this.existingStudentButtom.TabIndex = 1;
            this.existingStudentButtom.Text = "Existing Student";
            this.existingStudentButtom.UseVisualStyleBackColor = true;
            this.existingStudentButtom.Click += new System.EventHandler(this.existingStudent_Click);
            // 
            // IntroScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 308);
            this.Controls.Add(this.existingStudentButtom);
            this.Controls.Add(this.newStudentButton);
            this.Name = "IntroScreen";
            this.Text = "Student Intro Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newStudentButton;
        private System.Windows.Forms.Button existingStudentButtom;
    }
}

