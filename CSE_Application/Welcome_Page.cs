using System.Data.OleDb;

namespace CSE_Application
{
    public partial class Welcome_Page : Form
    {
        public Welcome_Page()
        {
            InitializeComponent();
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OleDB.4.0;Data Source=db_users.mdb");
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter da = new OleDbDataAdapter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Admin_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Login_Page().Show();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Welcome_to_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Page().Show();
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Sign_Up_Page().Show();
        }
    }
}
