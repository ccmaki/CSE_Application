using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE_Application
{
    public partial class logEmployment : Form
    {
        public logEmployment()
        {
            InitializeComponent();
        }

        private void logEmployment_Load(object sender, EventArgs e)
        {
            int applicantid = 0;
            string connstring = "server=localhost; uid=root; pwd=admin; database=cse_application";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;

            con.Open();
            string sql = "SELECT * FROM cse_application.temp";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                applicantid = reader.GetInt32("ApplicantID");
            }
            con.Close();

            MySqlConnection con2 = new MySqlConnection();
            con2.ConnectionString = connstring;

            con2.Open();
            string read = "SELECT * FROM cse_application.employment_details AS emp, cse_application.applicant_details AS a WHERE emp.EmploymentID = a.EmploymentID AND ApplicantID = '" + applicantid + "';";
            MySqlCommand cmd2 = new MySqlCommand(read, con2);
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read() == true)
            {
                if (reader2.GetString("Employment") == "Government")
                {
                    radioButton1.Checked = true;
                }
                else if (reader2.GetString("Employment") == "Private")
                {
                    radioButton2.Checked = true;
                }
                else if (reader2.GetString("Employment") == "Non-government Organization")
                {
                    radioButton3.Checked = true;
                }
                else if (reader2.GetString("Employment") == "Self-Employed")
                {
                    radioButton4.Checked = true;
                }
                else if (reader2.GetString("Employment") == "Unemployed")
                {
                    radioButton5.Checked = true;
                }

                textBox1.Text = reader2.GetString("Office");
                textBox2.Text = reader2.GetString("OfficeAdd");
                textBox3.Text = reader2.GetString("Position");
                textBox4.Text = reader2.GetString("OfficeYears");
                textBox5.Text = reader2.GetString("status");
            }
            con2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new logExamDetails().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new logExamsPassed().Show();
        }
    }
}
