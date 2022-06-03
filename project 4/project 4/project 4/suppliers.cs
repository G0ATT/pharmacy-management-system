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
    public partial class suppliers : Form
    {
        public suppliers()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=J:\project 4\project 4\project 4\pharmacy.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select supp_Id as ID, supp_name as Name,supp_phone as phone,supp_email as email   from suppliers";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            supp_DGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ext_bott_Click(object sender, EventArgs e)
        {
            //Con.Open();
            //SqlCommand cmd = new SqlCommand("TRUNCATE TABLE suppliers;", Con);
            //cmd.ExecuteNonQuery();
            //Con.Close();
            Application.Exit();
        }

        private void back_bott_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
        int key = 0;
        private void supp_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (supp_DGV.CurrentRow != null)
            {
                key = (int)supp_DGV.CurrentRow.Cells[0].Value;
                name_text.Text = supp_DGV.CurrentRow.Cells[1].Value.ToString();
                phone_text.Text = supp_DGV.CurrentRow.Cells[2].Value.ToString();
                email_text.Text = supp_DGV.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            name_text.Text = "";
            phone_text.Text = "";
            email_text.Text = "";
            key = 0;
        }

        private void add_bott_Click(object sender, EventArgs e)
        {
            if (name_text.Text == "" || phone_text.Text=="" || email_text.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into suppliers values('" + name_text.Text + "','" + phone_text.Text + "','" + email_text.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("supplier saved successfully");
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

        private void delete_text_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("select supplier to delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from suppliers where supp_Id=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("supplier deleted successfully");
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

        private void edit_bott_Click(object sender, EventArgs e)
        {
            if (name_text.Text == "" || phone_text.Text == "" || email_text.Text == "")
            {
                MessageBox.Show("select supplier to update");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update suppliers set supp_name='" + name_text.Text + "',supp_phone='" + phone_text.Text + "',supp_email='"+ email_text.Text + "'where supp_Id=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("supplier updated successfully");
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

        private void clear_bott_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
