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
    public partial class Application_Dashboard : Form
    {
        public Application_Dashboard()
        {
            InitializeComponent();
        }

        private void Login_Admin_Button_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome_Page().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new logPersonal().Show();
        }

        private void Application_Dashboard_Load(object sender, EventArgs e)
        {
            int applicantid = 0;
            string username = "";
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
                username = reader.GetString("Username");
            }
            con.Close();

            label5.Text = "Applicant ID: "+applicantid;
            label6.Text = "Username: "+username;
        }
    }
}
