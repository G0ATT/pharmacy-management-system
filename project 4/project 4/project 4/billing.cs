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
    public partial class billing : Form
    {
        public billing()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=J:\project 4\project 4\project 4\pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select  pord_Id as ID ,pro_name as Name, pro_qunt as quantity, selling_price as selling, exp_date  from product";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prod_DGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        int key = 0, stock = 0, price = 0;
        int n = 0,grd_total=0, amount=0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(prod_text.Text==""||qunt_text.Text==""||Convert.ToInt32(qunt_text.Text)>stock)
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int total= Convert.ToInt32(qunt_text.Text)* (int)prod_DGV.CurrentRow.Cells[3].Value;
                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(bill_DGV);
                newrow.Cells[0].Value = n + 1;
                newrow.Cells[1].Value = prod_text.Text;
                newrow.Cells[2].Value = Convert.ToInt32(qunt_text.Text);
                newrow.Cells[3].Value = total;
                bill_DGV.Rows.Add(newrow);
                grd_total = grd_total + total;
                amount = grd_total;
                Totallbl.Text = +grd_total+"EG";
                n++;
                update();
                reset();
            }
        }

        private void update ()
        {
            try
            {
                int newqunt = stock - Convert.ToInt32(qunt_text.Text);
                Con.Open();
                string qq = "update product set pro_qunt="+newqunt+" where pord_Id="+key+";";
                SqlCommand cm = new SqlCommand(qq, Con);
                cm.ExecuteNonQuery();
                Con.Close();
                populate();
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
        private void reset()
        {
            prod_text.Text = "";
            qunt_text.Text = "";
            cname_text.Text = "";
            cphone_text.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            reset();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (cname_text.Text==""||cphone_text.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into bill values('" + this.time.Text + "','" + cname_text.Text + "','" + cphone_text.Text + "'," + Login.emp_idd + "," + amount+ ")", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("bill saved successfully");
                    Con.Close();
                    populate();
                    //clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    Con.Close();
                }
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            
        }

        private void back_bott_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void ext_bott_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int prod_id, prod_qunt, prod_price, totall, pos = 60;
        string name;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Welcome to EL EZABY pharmacy", new Font("JUICY MILKY", 12, FontStyle.Regular), Brushes.Black, new Point(100, 10));
            e.Graphics.DrawString("ID  Product  Quantity  Total", new Font("JUICY MILKY", 12, FontStyle.Regular), Brushes.Black, new Point(100, 40));
            foreach(DataGridViewRow row in bill_DGV.Rows)
            {
                prod_id = Convert.ToInt32(row.Cells["Column1"].Value);
                name = row.Cells["Column2"].Value.ToString();
                prod_qunt = Convert.ToInt32(row.Cells["Column3"].Value);
                totall = Convert.ToInt32(row.Cells["Column4"].Value);
                e.Graphics.DrawString(""+prod_id, new Font("JUICY MILKY", 8, FontStyle.Regular), Brushes.Black, new Point(100, pos));
                e.Graphics.DrawString(""+name, new Font("JUICY MILKY", 8, FontStyle.Regular), Brushes.Black, new Point(130, pos));
                e.Graphics.DrawString(""+prod_qunt, new Font("JUICY MILKY", 8, FontStyle.Regular), Brushes.Black, new Point(205, pos));
                e.Graphics.DrawString(""+totall, new Font("JUICY MILKY", 8, FontStyle.Regular), Brushes.Black, new Point(260, pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("total amount of bill", new Font("JUICY MILKY", 12, FontStyle.Regular), Brushes.Black, new Point(100, pos));
            e.Graphics.DrawString(""+amount, new Font("JUICY MILKY", 12, FontStyle.Regular), Brushes.Black, new Point(240, pos));
            bill_DGV.Rows.Clear();
            bill_DGV.Refresh();
        }

        private void billing_Load(object sender, EventArgs e)
        {

        }

        public object Total { get; private set; }

        private void bill_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void prod_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (prod_DGV.CurrentRow != null)
            {
                key = (int)prod_DGV.CurrentRow.Cells[0].Value;
                prod_text.Text = prod_DGV.CurrentRow.Cells[1].Value.ToString();
               
            }
            if(prod_text.Text=="")
            {
                stock = 0;
            }
            else
            {
                stock = (int)prod_DGV.CurrentRow.Cells[2].Value;
                price= (int)prod_DGV.CurrentRow.Cells[3].Value;
            }
        }
    }
}
