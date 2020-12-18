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

namespace ISYS__4363_Final_Project
{
    public partial class CreateUser : Form
    {
        IntroScreen objIS = new IntroScreen();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        public CreateUser()
        {
            InitializeComponent();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            //pre-loaded items into combo boxes
            branchCB.Items.Add("Air Force");
            branchCB.Items.Add("Army");
            branchCB.Items.Add("Coast Guard");
            branchCB.Items.Add("Marine Corps");
            branchCB.Items.Add("Navy");

            affiliationCB.Items.Add("Active Duty");
            affiliationCB.Items.Add("Retired");
            affiliationCB.Items.Add("Veteran");
            affiliationCB.Items.Add("Family Member");
            affiliationCB.Items.Add("Contracted");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                ////initialize parameter of stored procedure
                int UARK_Student_ID = Convert.ToInt32(studentCreateTB.Text);
                string UARK_Email = uarkEmailTB.Text;
                string Student_First_Name = fNameTB.Text;
                string Student_Last_Name = lNameTB.Text;
                string Military_Branch = Convert.ToString(branchCB.SelectedItem);
                string Military_Affiliation = Convert.ToString(affiliationCB.SelectedItem);
                //initialize connection to database
                SqlConnection conn = new SqlConnection("Data Source = essql1.walton.uark.edu; Initial Catalog = VRICPROJECT; Integrated Security= True");
                //open connection to database
                conn.Open();
                //initialize SQL command as stored procedure
                SqlCommand cmd = new SqlCommand("CheckStudentExists", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //match required parameter with object in the windows form
                cmd.Parameters.AddWithValue("@UARK_Student_ID", SqlDbType.Int).Value = UARK_Student_ID;
                SqlDataAdapter adpater = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                //fill dataset with result of SQL command
                adpater.Fill(dataset);
                int count = dataset.Tables[0].Rows.Count;
                //checks if student id exists
                if (count == 0)
                {
                    //if student id does not exists then the following parameter is executed
                    SqlCommand cmd1 = new SqlCommand("CreateNewVRICStudent", conn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@UARK_Student_ID", SqlDbType.Int).Value = UARK_Student_ID;
                    cmd1.Parameters.AddWithValue("@UARK_Email", SqlDbType.VarChar).Value = UARK_Email;
                    cmd1.Parameters.AddWithValue("@Student_First_Name", SqlDbType.VarChar).Value = Student_First_Name;
                    cmd1.Parameters.AddWithValue("@Student_Last_Name", SqlDbType.VarChar).Value = Student_Last_Name;
                    cmd1.Parameters.AddWithValue("@Military_Branch", SqlDbType.VarChar).Value = Military_Branch;
                    cmd1.Parameters.AddWithValue("@Military_Affiliation", SqlDbType.VarChar).Value = Military_Affiliation;
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("You have successfully created a VRIC Student Account!");
                    this.Close();
                    CheckIn objCI = new CheckIn();
                    objCI.Show();
                }
                else
                {
                    MessageBox.Show("This Student ID already has an existing VRIC Account!");
                }
                //close connection to database
                conn.Close();
 
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter the required information!");
            }
        }

        private void backButtonNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            IntroScreen objIS = new IntroScreen();
            objIS.Show();
        }
    }

}
