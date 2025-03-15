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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSE_Application
{
    public partial class Education : Form
    {
        public Education()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox7.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox4.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox7.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox4.Checked = false;
                checkBox3.Checked = false;
                checkBox7.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
                checkBox7.Checked = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if ((checkBox7.Checked == true && textBox1.Text == "") || (checkBox5.Checked == true && textBox2.Text == "") || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Please fill up all of the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string completion = "a", educlvl = "a", honors = "N/A", completiondate = "N/A";
                if (checkBox1.Checked == true)
                {
                    educlvl = "technical/vocational";
                }
                else if (checkBox2.Checked == true)
                {
                    educlvl = "college";
                }
                else if (checkBox3.Checked == true)
                {
                    educlvl = "postgraduate";
                }
                else if (checkBox4.Checked == true)
                {
                    educlvl = "high school/sr high school";
                }
                else if (checkBox7.Checked == true)
                {
                    educlvl = textBox1.Text;
                }

                if (checkBox5.Checked == true)
                {
                    completion = "graduated";
                    honors = textBox2.Text;
                    completiondate = textBox8.Text;
                }
                else if (checkBox6.Checked == true)
                {
                    completion = "not graduated/on going";
                }

                int applicantid = 1;
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

                string educid = "ED-" + applicantid;
                MySqlConnection con2 = new MySqlConnection();
                con2.ConnectionString = connstring;
                string sql2 = "INSERT INTO cse_application.educational_background (EducID, EduLvl, Completion, Honor, GradDate, Course, Major, SchoolName, SchoolAdd, SchoolYears) VALUES ('" + educid + "', '" + educlvl + "', '" + completion + "', '" + honors + "','" + completiondate + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '"+textBox5.Text+"', '"+textBox6.Text+"', '"+textBox7.Text+"');";
                MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
                con2.Open();
                cmd2.ExecuteNonQuery();
                con2.Close();

                this.Hide();
                new Exams_Passed().Show();
            }
        }
        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox2.Enabled = true;
                checkBox6.Checked = false;
            }
            else
            {
                textBox2.Text = "";
                textBox2.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox5.Checked = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox1.Enabled = true;
                checkBox1.Checked = false;
                textBox3.Enabled = true;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
            }
            else
            {
                textBox1.Text = "";
                textBox1.Enabled = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
