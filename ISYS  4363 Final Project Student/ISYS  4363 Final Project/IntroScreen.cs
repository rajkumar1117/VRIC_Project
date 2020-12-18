using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISYS__4363_Final_Project
{
    public partial class IntroScreen : Form
    {
        public IntroScreen()
        {
            InitializeComponent();
        }

        private void newStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUser objCU = new CreateUser();
            objCU.Show();
        }

        private void existingStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckIn objCI = new CheckIn();
            objCI.Show();
        }

    }
}
