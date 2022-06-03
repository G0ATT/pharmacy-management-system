using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace project_4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string emp_namee = "";
        public static int emp_idd ;


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=J:\project 4\project 4\project 4\pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        private void Log_botton_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select  count(*) from employee where emp_name='"+user_text.Text+"'and emp_pass='"+pass_text.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1"|| (user_text.Text == "admin" && pass_text.Text == "admin"))
            {
                if((user_text.Text == "admin" && pass_text.Text == "admin"))
                {
                    emp_idd = 1000;
                }
                else
                {
                    string qq = "select  emp_Id from employee where emp_name='" + user_text.Text + "'";
                    SqlDataAdapter sd = new SqlDataAdapter(qq, Con);
                    DataTable d = new DataTable();
                    emp_idd = sd.Fill(d);
                }
                emp_namee = user_text.Text;
                Home Obj = new Home();
                Obj.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password");
            }
            Con.Close();
            
        }

        private void user_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ext_bott_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
