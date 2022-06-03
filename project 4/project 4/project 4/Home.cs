using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_4
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ext_bott_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void med_bott_Click(object sender, EventArgs e)
        {
            medicine ss = new medicine();
            ss.Owner = this;
            ss.Show();
            this.Hide();
        }

        private void emp_bott_Click(object sender, EventArgs e)
        {
            employee ss = new employee();
            ss.Owner = this;
            ss.Show();
            this.Hide();
        }

        private void supp_bott_Click(object sender, EventArgs e)
        {
            suppliers ss = new suppliers();
            ss.Owner = this;
            ss.Show();
            this.Hide();
        }

        private void bill_bott_Click(object sender, EventArgs e)
        {
            billing ss = new billing();
            ss.Owner = this;
            ss.Show();
            this.Hide();
        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            user.Text = Login.emp_namee;
        }
    }
}
