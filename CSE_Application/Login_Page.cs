using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE_Application
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void return_Home_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome_Page().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Username field is empty", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Password field is empty", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string connstring = "server=localhost; uid=root; pwd=admin; database=cse_application";
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = connstring;
                    con.Open();
                    string sql = "SELECT * FROM cse_application.applicantlogin WHERE Username = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read() == true && textBox1.Text == reader.GetString("Username") && textBox2.Text == reader.GetString("Password"))
                    {
                        this.Hide();
                        new Application_Dashboard().Show();
                        string username = reader.GetString("Username");
                        string password = reader.GetString("Password");
                        int applicant = reader.GetInt32("ApplicantID");

                        con.Close();

                        MySqlConnection con2 = new MySqlConnection();
                        con2.ConnectionString = connstring;
                        con2.Open();
                        string sql2 = "UPDATE cse_application.temp SET Username = '"+username+"', Password = '"+password+"', ApplicantID = '"+applicant+"';";
                        MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
                        cmd2.ExecuteNonQuery();
                        con2.Close();

                    }
                    else
                    {
                        MessageBox.Show("Username and Password not Valid", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        con.Close() ;
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }
    }
}
