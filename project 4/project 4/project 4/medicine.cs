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
    public partial class medicine : Form
    {
        public medicine()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=J:\project 4\project 4\project 4\pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select pord_Id as ID, pro_name as Name, pro_category as category, pro_qunt as quantity, selling_price as selling, buying_price as buying, exp_date,supplier  from product";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            mid_DGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ext_bott_Click(object sender, EventArgs e)
        {
            //Con.Open();
            //SqlCommand cmd = new SqlCommand("TRUNCATE TABLE product;", Con);
            //cmd.ExecuteNonQuery();
            //Con.Close();
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(name_text.Text== ""|| cat_text.Text == ""||Quan_text.Text == ""|| supp_text.Text == ""||buy_text.Text==""|| selling_text.Text == ""|| exp_text.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into product values('" + name_text.Text + "','" + cat_text.Text + "'," + Quan_text.Text + "," + selling_text.Text + "," + buy_text.Text + ",'" + exp_text.Text + "','" + supp_text.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("product saved successfully");
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
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mid_DGV.CurrentRow != null)
            {
                key = (int)mid_DGV.CurrentRow.Cells[0].Value;
                name_text.Text = mid_DGV.CurrentRow.Cells[1].Value.ToString();
                cat_text.Text = mid_DGV.CurrentRow.Cells[2].Value.ToString();
                Quan_text.Text = mid_DGV.CurrentRow.Cells[3].Value.ToString();
                selling_text.Text = mid_DGV.CurrentRow.Cells[4].Value.ToString();
                buy_text.Text = mid_DGV.CurrentRow.Cells[5].Value.ToString();
                exp_text.Text = mid_DGV.CurrentRow.Cells[6].Value.ToString();
                supp_text.Text = mid_DGV.CurrentRow.Cells[7].Value.ToString();
            }
            
        }

        private void name_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            name_text.Text = ""; 
            cat_text.Text = "";
            Quan_text.Text = "";
            supp_text.Text = "";
            buy_text.Text = "";
            selling_text.Text = "";
            exp_text.Text = "";
            key = 0;
        }
        private void delete_bott_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dele_bott_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("select product to delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from product where pord_Id=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("product deleted successfully");
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
            if (name_text.Text == "" || cat_text.Text == "" || Quan_text.Text == "" || supp_text.Text == "" || buy_text.Text == "" || selling_text.Text == "" || exp_text.Text == "")
            {
                MessageBox.Show("select product to update");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update product set pro_name='"+ name_text.Text + "',pro_category='" + cat_text.Text + "',pro_qunt=" + Quan_text.Text + ",selling_price=" + selling_text.Text + ",buying_price=" + buy_text.Text + ",exp_date='" + exp_text.Text + "',supplier='" + supp_text.Text + "'where pord_Id="+key+";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("product updated successfully");
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

        private void medicine_Load(object sender, EventArgs e)
        {

        }
    }
}
