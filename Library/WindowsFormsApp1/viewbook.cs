using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class viewbook : Form
    {
        public viewbook()
        {
            InitializeComponent();
        }

        private void viewbook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con=new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= con;
            cmd.CommandText = "select * from Newboook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int bid;
        int rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
               // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Newboook where bid="+bid+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);



            rowid= (int)long.Parse(ds.Tables[0].Rows[0][0].ToString());

            bname.Text = ds.Tables[0].Rows[0][1].ToString();
            bauth.Text = ds.Tables[0].Rows[0][2].ToString();
            bpubl.Text = ds.Tables[0].Rows[0][3].ToString();
            bdate.Text= ds.Tables[0].Rows[0][4].ToString();
            bprice.Text = ds.Tables[0].Rows[0][5].ToString();
            bquan.Text=  ds.Tables[0].Rows[0][6].ToString();
        }

        private void canc_Click(object sender, EventArgs e)
        {
            panel2.Visible=false;
        }

        private void txtbookname_TextChanged(object sender, EventArgs e)
        {
            if(txtbookname.Text!="")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Newboook where bName LIKE'"+txtbookname.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Newboook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Refr_Click(object sender, EventArgs e)
        {
            txtbookname.Clear();
            panel2.Visible = false;
        }
        private void LoadData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Newboook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void updt_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Data Will Be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String bnaame = bname.Text;
                string bauthoor = bauth.Text;
                String bpubll = bpubl.Text;
                String bpdate = bdate.Text;
                Int64 pricce = Int64.Parse(bprice.Text);
                Int64 Quann = Int64.Parse(bquan.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Newboook set bName='" + bnaame + "',bAuthor='" + bauthoor + "',bPubl='" + bpubll + "',bPDate='" + bpdate + "',bPrice=" + pricce + ",bQuan=" + Quann + "where bid=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                LoadData();
            }
        
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Deleted. Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
               
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from NewBoook where bid=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                LoadData();
            }
        }
    }
}
