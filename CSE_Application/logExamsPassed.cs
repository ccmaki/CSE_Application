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
    public partial class logExamsPassed : Form
    {
        public logExamsPassed()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new logEmployment().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new logEducation().Show();
        }

        private void logExamsPassed_Load(object sender, EventArgs e)
        {
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

            MySqlConnection con2 = new MySqlConnection();
            con2.ConnectionString = connstring;
            con2.Open();
            string read = "SELECT * FROM cse_application.passedexams_details WHERE ApplicantID = '" + applicantid + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(read, con2);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
