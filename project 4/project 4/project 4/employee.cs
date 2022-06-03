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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=J:\project 4\project 4\project 4\pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select emp_Id as ID, emp_name as Name,emp_address as address,emp_phone as phone,emp_salary as salary,emp_mail as Email,emp_job as job,emp_pass as password from employee";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            emp_DGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ext_bott_Click(object sender, EventArgs e)
        {
            //Con.Open();
            //SqlCommand cmd = new SqlCommand("TRUNCATE TABLE employee;", Con);
            //cmd.ExecuteNonQuery();
            //Con.Close();
            Application.Exit();
        }

        private void back_bott_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void employee_Load(object sender, EventArgs e)
        {

        }
        int key = 0;
        private void emp_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (emp_DGV.CurrentRow != null)
            {
                key = (int)emp_DGV.CurrentRow.Cells[0].Value;
                name_text.Text = emp_DGV.CurrentRow.Cells[1].Value.ToString();
                add_text.Text = emp_DGV.CurrentRow.Cells[2].Value.ToString();
                phone_text.Text = emp_DGV.CurrentRow.Cells[3].Value.ToString();
                salary_text.Text = emp_DGV.CurrentRow.Cells[4].Value.ToString();
                email_text.Text = emp_DGV.CurrentRow.Cells[5].Value.ToString();
                job_text.Text = emp_DGV.CurrentRow.Cells[6].Value.ToString();
                pass_text.Text= emp_DGV.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void add_bott_Click(object sender, EventArgs e)
        {
            if (name_text.Text == "" || add_text.Text == "" || phone_text.Text == "" || salary_text.Text == "" || email_text.Text == "" || job_text.Text == ""||pass_text.Text=="" )
            {
                MessageBox.Show("Missing Information");
            }
            else if (pass_text.Text.Length > 8)
            {
                MessageBox.Show("password size is too long");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into employee values('" + name_text.Text + "','" + add_text.Text + "','" + phone_text.Text + "','" + salary_text.Text + "','" + email_text.Text + "','" + job_text.Text +"','"+ pass_text.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("employee saved successfully");
                    Con.Close();
                    populate();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }
        private void clear()
        {
            name_text.Text = "";
            add_text.Text = "";
            phone_text.Text = "";
            salary_text.Text = "";
            email_text.Text = "";
            job_text.Text = "";
            pass_text.Text = "";
            key = 0;
        }

        private void clear_bott_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void edit_bott_Click(object sender, EventArgs e)
        {
            if (name_text.Text == "" || add_text.Text == "" || phone_text.Text == "" || salary_text.Text == "" || email_text.Text == "" || job_text.Text == "" || pass_text.Text == "")
            {
                MessageBox.Show("select employee to update");
            }
            else if (pass_text.Text.Length > 8)
            {
                MessageBox.Show("password size is too long");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update employee set emp_name='" + name_text.Text + "',emp_address='" + add_text.Text + "',emp_phone='" + phone_text.Text + "',emp_salary='" + salary_text.Text + "',emp_mail='" + email_text.Text + "',emp_job='" + job_text.Text +"',emp_pass='"+ pass_text.Text + "'where emp_Id=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("employee updated successfully");
                    Con.Close();
                    populate();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

        private void delete_bott_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("select employee to delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from employee where emp_Id=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("employee deleted successfully");
                    Con.Close();
                    populate();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }
    }
}
