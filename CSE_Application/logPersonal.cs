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
    public partial class logPersonal : Form
    {
        public logPersonal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new logEducation().Show();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox5.Checked = false;
            }
        }

        private void logPersonal_Load(object sender, EventArgs e)
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
            string read = "SELECT * FROM cse_application.applicant_details WHERE ApplicantID = '" + applicantid + "';";
            MySqlCommand cmd2 = new MySqlCommand(read, con2);
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read() == true)
            {
                textBox1.Text = reader2.GetString("Name");
                textBox2.Text = reader2.GetInt32("Age").ToString();
                textBox3.Text = reader2.GetString("BirthDate");
                textBox4.Text = reader2.GetString("BirthPlace");
                textBox5.Text = reader2.GetString("MomMaidenName");
                textBox6.Text = reader2.GetString("Address");
                if (reader2.GetString("CivilStat") == "S" || reader2.GetString("CivilStat") == "s")
                {
                    textBox7.Text = "Single";
                }
                else if (reader2.GetString("CivilStat") == "M" || reader2.GetString("CivilStat") == "m")
                {
                    textBox7.Text = "Married";
                }
                textBox8.Text = reader2.GetString("Disability");
                //textBox9.Text = reader2.GetString("MobileNo");
                textBox10.Text = reader2.GetString("TelNo");
                textBox11.Text = reader2.GetString("Email");
                textBox12.Text = reader2.GetString("Citizenship");
                textBox13.Text = reader2.GetInt32("Zipcode").ToString();

                if (reader2.GetString("Sex") == "f")
                {
                    checkBox5.Checked = true;
                }
                else
                {
                    checkBox4.Checked = true;
                }

                if (reader2.GetString("Preg") == "n")
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }

                if (reader2.GetString("SC") == "n")
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }

                if (reader2.GetString("PWD") == "n")
                {
                    checkBox3.Checked = false;
                }
                else
                {
                    checkBox3.Checked = true;
                }

            }
            con2.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Application_Dashboard().Show();
        }
    }
}
