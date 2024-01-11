using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ViewStudentinformation : Form
    {
        public ViewStudentinformation()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchEnronement_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEnronement.Text != "")
            {
                label1.Visible = false;
                Image image = Image.FromFile("D:/software/Library/WindowsFormsApp1/WindowsFormsApp1/Resources/search1.gif");
                pictureBox1.Image = image;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from NewStudent where enroll LIKE '" + txtSearchEnronement.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                label1.Visible = true;
                Image image = Image.FromFile("D:/software/Library/WindowsFormsApp1/WindowsFormsApp1/Resources/search.gif");
                pictureBox1.Image = image;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void ViewStudentinformation_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int bid;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NewStudent where stuid = " + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtstudentname.Text = ds.Tables[0].Rows[0][1].ToString();
            txtenrollment.Text = ds.Tables[0].Rows[0][2].ToString();
            txtdep.Text = ds.Tables[0].Rows[0][3].ToString();
            txtsem.Text = ds.Tables[0].Rows[0][4].ToString();
            txtcont.Text = ds.Tables[0].Rows[0][5].ToString();
            txtemail.Text = ds.Tables[0].Rows[0][6].ToString();


        }

        private void updtbtn_Click(object sender, EventArgs e)
        {
            String sname = txtstudentname.Text;
            String enrol = txtenrollment.Text;
            String depp = txtdep.Text;
            String semm = txtsem.Text;
            Int64 conta = Int64.Parse(txtcont.Text);
            String emaill = txtemail.Text;
            if (MessageBox.Show("Data will be updated . Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update NewStudent set sname='" + sname + "',enroll='" + enrol + "',dep='" + depp + "',sem='" + semm + "',contact='" + conta + "',email='" + emaill + "'where stuid=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                ViewStudentinformation_Load(this, null);
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            ViewStudentinformation_Load(this, null);
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Data will be deleted . Confirm?", "Deleted ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from NewStudent where stuid=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                ViewStudentinformation_Load(this, null);
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved data will be lost", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}