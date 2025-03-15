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

namespace CSE_Application
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text =="" || textBox13.Text == "")
            {
                MessageBox.Show("Please fill up all of the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string preg = "a", pwd = "a", sex = "a", sc = "a";
                if (checkBox1.Checked == true )
                {
                    preg = "y";
                }
                else
                {
                    preg = "n";
                }

                if (checkBox2.Checked == true)
                {
                    sc = "y";
                }
                else
                {
                    sc = "n";
                }

                if (checkBox3.Checked == true)
                {
                    pwd = "y";
                }
                else
                {
                    pwd = "n";
                }


                if (checkBox4.Checked == true)
                {
                    sex = "m";
                }

                else if (checkBox5.Checked == true)
                {
                    sex = "f";
                }

                try
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


                string educid = "ED-" + applicantid;
                string employmentid = "EMP-" + applicantid;
                MySqlConnection con2 = new MySqlConnection();
                con2.ConnectionString = connstring;
                string sql2 = "UPDATE cse_application.applicant_details SET Name = '" + textBox1.Text + "', Age = '" + textBox2.Text + "', BirthDate = '" + textBox3.Text + "', Sex = '" + sex + "', BirthPlace = '"+textBox4.Text+"', Citizenship = '"+textBox12.Text+"', MomMaidenName = '"+textBox5.Text+"', Address = '"+textBox6.Text+"', Zipcode = '"+textBox13.Text+ "', CivilStat = TRIM(LEFT('"+textBox7+"', 1)), Preg = '"+preg+"', SC = '"+sc+"' ,PWD = '"+pwd+"', Disability = '"+textBox8.Text+"', MobileNo = '"+textBox9.Text+"', TelNo = '"+textBox10.Text+"', Email = '"+textBox11.Text+"', EducID = '"+educid+"', EmploymentID = '"+employmentid+"' WHERE ApplicantID = "+applicantid+"; " ;
                MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
                con2.Open();
                cmd2.ExecuteNonQuery();
                con2.Close();
                
                this.Hide();
                new Education().Show();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox5.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox4.Checked = false;
            }
        }
    }
}
