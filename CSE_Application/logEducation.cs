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
    public partial class logEducation : Form
    {
        public logEducation()
        {
            InitializeComponent();
        }

        private void logEducation_Load(object sender, EventArgs e)
        {
            int applicantid = 0;
            string connstring = "server=localhost; uid=root; pwd=admin; database=cse_application";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;

            //Getting ApplicantID form temp Table
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
            string read = "SELECT * FROM cse_application.educational_background AS ed, cse_application.applicant_details AS a WHERE ed.EducID = a.EducID AND ApplicantID = '" + applicantid + "';";
            MySqlCommand cmd2 = new MySqlCommand(read, con2);
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read() == true)
            {
                if (reader2.GetString("EduLvl") == "technical/vocational")
                {
                    checkBox1.Checked = true;
                }
                else if (reader2.GetString("EduLvl") == "college")
                {
                    checkBox2.Checked = true;
                }
                else if (reader2.GetString("EduLvl") == "postgraduate")
                {
                    checkBox3.Checked = true;
                }
                else if (reader2.GetString("EduLvl") == "high school/sr high school")
                {
                    checkBox3.Checked = true;
                }
                else
                {
                    textBox1.Text = reader2.GetString("EduLvl");
                }

                if (reader2.GetString("Completion") == "graduated")
                {
                    checkBox5.Checked = true;
                    textBox2.Text = reader2.GetString("Honor");
                    textBox8.Text = reader2.GetString("GradDate");
                }
                else
                {
                    checkBox5.Checked = false;
                    textBox2.Text = reader2.GetString("Honor");
                    textBox8.Text = reader2.GetString("GradDate");
                }

                textBox3.Text = reader2.GetString("Course");
                textBox4.Text = reader2.GetString("Major");
                textBox5.Text = reader2.GetString("SchoolName");
                textBox6.Text = reader2.GetString("SchoolAdd");
                textBox7.Text = reader2.GetString("SchoolYears");

            }
            con2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new logExamsPassed().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new logPersonal().Show();
        }
    }
}
