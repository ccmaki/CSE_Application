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
    public partial class logExamDetails : Form
    {
        public logExamDetails()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Application_Dashboard().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new logEmployment().Show();
        }
    }
}
