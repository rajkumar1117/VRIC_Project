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
    public partial class CheckIn : Form
    {
        IntroScreen objIS = new IntroScreen();
        public CheckIn()
        {
            InitializeComponent();
        }


        private void checkInButton_Click(object sender, EventArgs e)
        {
            try
            {
                //initialize parameter of stored procedure
                int UARK_Student_ID = Convert.ToInt32(studentIDTB.Text);
                //initialize connection to database
                SqlConnection conn = new SqlConnection("Data Source = essql1.walton.uark.edu; Initial Catalog = VRICPROJECT; Integrated Security= True");
                //open connection to database
                conn.Open();
                //initialize SQL command as stored procedure
                SqlCommand cmd1 = new SqlCommand("CheckStudentExists", conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                //match required parameter with object in the windows form
                cmd1.Parameters.AddWithValue("@UARK_Student_ID", SqlDbType.Int).Value = UARK_Student_ID;
                SqlDataAdapter adpater = new SqlDataAdapter(cmd1);
                DataSet dataset = new DataSet();
                //fill dataset with results of SQL command
                adpater.Fill(dataset);
                int count = dataset.Tables[0].Rows.Count;
                //checks if student id exists
                if (count == 1)
                {
                    //if it does then the following stored procedure is executed
                    SqlCommand cmd = new SqlCommand("CheckIntoWaitingRoomStudentExe", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UARK_Student_ID", SqlDbType.Int).Value = UARK_Student_ID;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You have been successfully checked in!");
                    this.Close();
                    objIS.Show();
                }
                else
                {
                    MessageBox.Show("Student ID does not exist!");
                }
                //close connection to database
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please try again!");
            }
        }

        private void backButtonExisting_Click(object sender, EventArgs e)
        {
            this.Close();
            objIS.Show();
        }
    }
}
