using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from IRBook where std_enroll='" + txtenrollement.Text + "'and book_return_date IS NULL";
            SqlDataAdapter da=new SqlDataAdapter(cmd);  
            DataSet ds=new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("invalid id or no book issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            panel2.Visible=false;
            txtenrollement.Clear();
        }
        String bname;
        String bdate;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname= dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate= dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtbookname.Text = bname;
            txtbookissue.Text = bdate;  
            
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText="update IRBook set book_return_date='"+dateTimePicker1.Text+"'where std_enroll='"+txtenrollement.Text+"'and id = "+rowid+"";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("return successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReturnBook_Load(this, null);
        }

        private void txtenrollement_TextChanged(object sender, EventArgs e)
        {
            if(txtenrollement.Text=="")
            {
                panel2.Visible = false; 
                dataGridView1.DataSource = null;    
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtenrollement.Clear();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
