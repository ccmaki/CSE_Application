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
    public partial class Exams_Passed : Form
    {
        public Exams_Passed()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                int applicantid = 1;
                int count = 1;
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

                string title = "N/A";
                string rating = "N/A";
                string date = "N/A";
                string place = "N/A";

                string past = "PE" + count + "-" + applicantid;
                string insert = "INSERT INTO cse_application.passedexams_details(ApplicantID, PastExamID, ExamTitle, Rating, DatePass, PlacePast) VALUES('" + applicantid + "', '" + past + "', '" + title + "', '" + rating + "', '" + date + "', '" + place + "'); ";
                MySqlConnection con3 = new MySqlConnection();
                MySqlCommand cmd3 = new MySqlCommand(insert, con3);
                con3.ConnectionString = connstring;
                con3.Open();
                cmd3.ExecuteNonQuery();
                con3.Close();


                this.Hide();
                new Employment().Show();
            }
            else
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                {
                    MessageBox.Show("Please fill up all of the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        int applicantid = 1;
                        int count = 1;
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

                        string read = "SELECT * FROM cse_application.passedexams_details WHERE ApplicantID = '" + applicantid + "';";
                        MySqlConnection con2 = new MySqlConnection();
                        MySqlCommand cmd2 = new MySqlCommand(read, con2);
                        con2.ConnectionString = connstring;
                        con2.Open();
                        MySqlDataReader reader2 = cmd2.ExecuteReader();

                        while (reader2.Read() == true)
                        {
                            count = count + 1;
                        }
                        con2.Close();

                        string past = "PE" + count + "-" + applicantid;
                        string insert = "INSERT INTO cse_application.passedexams_details(ApplicantID, PastExamID, ExamTitle, Rating, DatePass, PlacePast) VALUES('" + applicantid + "', '" + past + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox2.Text + "', '" + textBox1.Text + "'); ";
                        MySqlConnection con3 = new MySqlConnection();
                        MySqlCommand cmd3 = new MySqlCommand(insert, con3);
                        con3.ConnectionString = connstring;
                        con3.Open();
                        cmd3.ExecuteNonQuery();
                        con3.Close();

                        if (checkBox4.Checked == true)
                        {
                            this.Hide();
                            new Exams_Passed().Show();
                        }
                        else
                        {
                            this.Hide();
                            new Employment().Show();
                        }

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
        }

        private void Exams_Passed_Load(object sender, EventArgs e)
        {

        }
    }
}
