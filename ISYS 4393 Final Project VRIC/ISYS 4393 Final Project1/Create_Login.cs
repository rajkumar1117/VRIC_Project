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
    public partial class Create_Login : Form
    {
        public Create_Login()
        {
            InitializeComponent();
        }

        private void submitButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int answer;
                //initialize parameter of stored procedure
                string UserName = userNameTB.Text;
                string Password = passWordTB.Text;
                string FirstName = fNameTB.Text;
                string LastName = lNameTB.Text;
                string Role = staffRoleTB.Text;
                //initialize connection to database
                 SqlConnection conn = new SqlConnection("Data Source = essql1.walton.uark.edu; Initial Catalog = VRICPROJECT; Integrated Security= True");
                //open connection to database
                conn.Open();
                //initialize SQL command as stored procedure
                SqlCommand cmd = new SqlCommand("NewVRICStaff", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //match required parameter with object in the windows form
                cmd.Parameters.AddWithValue("@UserName", SqlDbType.VarChar).Value = UserName;
                cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = Password;
                cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = FirstName;
                cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = LastName;
                cmd.Parameters.AddWithValue("@Role", SqlDbType.VarChar).Value = Role;
                //execute SQL command
                answer = cmd.ExecuteNonQuery();
                //checks if insert SQL command occurred within database
                if (answer > 1)
                {
                    //displays message and pushes you to the Login form
                    MessageBox.Show("VRIC Staff Account has been created!");
                    Login objLogin = new Login();
                    this.Hide();
                    objLogin.Show();
                }
                //clsoe connection to database
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please try again!");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            this.Hide();
            objLogin.Show();
        }
    }
}
