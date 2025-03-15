using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CSE_Application
{
    public partial class Sign_Up_Page : Form
    {
        public Sign_Up_Page()
        {
            InitializeComponent();
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void return_Home_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome_Page().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Please fill up all of the fields", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Username field is empty", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Password field is empty", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Please Re-enter your password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Password does not match", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connstring = "server=localhost; uid=root; pwd=admin; database=cse_application";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();

                string sql = "SELECT * FROM cse_application.applicantlogin WHERE Username = '" + textBox1.Text + "';";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true && textBox1.Text == reader.GetString("Username"))
                {
                    MessageBox.Show("An account with the same username already exists", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
                else
                {
                    con.Close();
                    string register = "INSERT INTO cse_application.applicantlogin (Username, Password) VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
                    MySqlConnection con2 = new MySqlConnection();
                    MySqlCommand cmd2 = new MySqlCommand(register, con2);
                    con2.ConnectionString = connstring;
                    con2.Open();
                    cmd2.ExecuteNonQuery();

                    string read = "SELECT * FROM cse_application.applicantlogin WHERE Username = '"+textBox1.Text+"';";
                    MySqlConnection con3 = new MySqlConnection();
                    con3.ConnectionString = connstring;
                    MySqlCommand cmd3 = new MySqlCommand(read, con3);
                    con3.Open();
                    MySqlDataReader reader2 = cmd3.ExecuteReader();
                    if (reader2.Read() == true) 
                    { 
                        int applicantid = reader2.GetInt32("ApplicantID");
                        string insert = "INSERT INTO cse_application.applicant_details (ApplicantID) VALUES('" + applicantid + "');";
                        MySqlConnection con4 = new MySqlConnection();
                        MySqlCommand cmd4 = new MySqlCommand(insert, con4);
                        con4.ConnectionString = connstring;
                        con4.Open();
                        cmd4.ExecuteNonQuery();
                        con4.Close();

                        string username = textBox1.Text;
                        string password = textBox2.Text;
                        string update = "UPDATE cse_application.temp SET Username = '" + username + "', Password = '" + password + "', ApplicantID = '" + applicantid + "';";
                        MySqlConnection con5 = new MySqlConnection();
                        con5.ConnectionString = connstring;
                        MySqlCommand cmd5 = new MySqlCommand(update, con5);
                        con5.Open();
                        cmd5.ExecuteNonQuery();
                        con5.Close();
                    }
                    con3.Close();








                    MessageBox.Show("Your Account was Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    new RegistrationForm().Show();
                    con2.Close ();



                }
            }
        }
    }
}
