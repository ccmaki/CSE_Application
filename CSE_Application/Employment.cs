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
    public partial class Employment : Form
    {
        public Employment()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string employmentid;
            string employment = "";

            int applicantid = 1;
            string connstring = "server=localhost; uid=root; pwd=admin; database=cse_application";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            try
            {
                con.Open();
                string sql = "SELECT * FROM cse_application.temp";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    applicantid = reader.GetInt32("ApplicantID");
                }
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            employmentid = "EMP-" + applicantid;

            if (radioButton1.Checked == true)
            {
                employment = "Government";
            }
            else if (radioButton2.Checked == true)
            {
                employment = "Private";
            }
            else if (radioButton3.Checked == true)
            {
                employment = "Non-government Organization";
            }
            else if (radioButton4.Checked == true)
            {
                employment = "Self-Employed";
            }
            else if (radioButton5.Checked == true)
            {
                employment = "Unemployed";
            }

            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false)
            {
                MessageBox.Show("Please fill up all of the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioButton5.Checked == true)
            {
                try
                {
                    string office = "N/A";
                    string address = "N/A";
                    string position = "N/A";
                    string years = "N/A";
                    string status = "N/A";
                    string insert = "INSERT INTO cse_application.employment_details (EmploymentID, Employment, Office, OfficeAdd, Position, OfficeYears, status) VALUES ('" + employmentid + "','" + employment + "','" + office + "', '" + address + "', '" + position + "', '" + years + "', '" + status + "' );";
                    MySqlConnection con2 = new MySqlConnection();
                    con2.ConnectionString = connstring;
                    MySqlCommand cmd2 = new MySqlCommand(insert, con2);
                    con2.Open();
                    cmd2.ExecuteNonQuery();
                    con2.Close();
                    this.Hide();
                    new Exam_Details().Show();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Please fill up all of the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {

                    try
                    {
                        string office = textBox1.Text;
                        string address = textBox2.Text;
                        string position = textBox3.Text;
                        string years = textBox4.Text;
                        string status = textBox5.Text;
                        string insert2 = "INSERT INTO cse_application.employment_details (EmploymentID, ApplicantID, Employment, Office, OfficeAdd, Position, OfficeYears, status) VALUES ('" + employmentid + "','" + applicantid + "','"+employment+"','" + office + "', '" + address + "', '" + position + "', '" + years + "', '" + status + "' );";
                        MySqlConnection con3 = new MySqlConnection();
                        con3.ConnectionString = connstring;
                        MySqlCommand cmd3 = new MySqlCommand(insert2, con3);
                        con3.Open();
                        cmd3.ExecuteNonQuery();
                        con3.Close();
                        this.Hide();
                        new Exam_Details().Show();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
            }
        }

        private void Employment_Load(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
            }
            
        }
    }
}
