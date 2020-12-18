using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ISYS_4393_Final_Project1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //initialize connection to datbase
            SqlConnection connection = new SqlConnection("Data Source = essql1.walton.uark.edu; Initial Catalog = VRICPROJECT; Integrated Security = True");
            //open connection to database
            connection.Open();
            //initialize SQL command
            SqlCommand command = new SqlCommand("SELECT User_Name, Password FROM Login_Credentials WHERE User_Name = @username and Password = @password", connection);
            command.Parameters.AddWithValue("@username", usernameTB.Text); 
            command.Parameters.AddWithValue("@password", passwordTB.Text);
            SqlDataAdapter adpater = new SqlDataAdapter(command);
            DataSet dataset = new DataSet();
            //fill dataset with results of the above SQL commande
            adpater.Fill(dataset);
            //close connection to database
            connection.Close();
            int count = dataset.Tables[0].Rows.Count;
            //checks if login credentials exists in database
            if (count == 1)
            {
                //displays message box and hides this from and pushes you to the VisitorLog form
                MessageBox.Show("Login Successful!");
                this.Hide();
                VisitorLog objVL = new VisitorLog();
                objVL.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username and/or Password.");
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //hides current form and pushes you to the Create_Login form
            Create_Login objCL = new Create_Login();
            this.Hide();
            objCL.Show();
        }
    }
}
