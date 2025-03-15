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
using MySql.Data.MySqlClient;

namespace CSE_Application
{
    public partial class Admin_Login_Page : Form
    {
        public Admin_Login_Page()
        {
            InitializeComponent();
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
                    string sql = "SELECT * FROM cse_application.adminlogin WHERE Username = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read() == true && textBox1.Text == reader.GetString("Username") && textBox2.Text == reader.GetString("Password"))
                    {
                        this.Hide();
                        new Summary_Page().Show();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username and Password not Valid", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        con.Close();
                    }

                }catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void return_Home_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome_Page().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
