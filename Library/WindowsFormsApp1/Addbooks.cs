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
    public partial class Addbooks : Form
    {
        public Addbooks()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (Bookname.Text != "" && authorname.Text != "" && bookprice.Text != "" && bookquan.Text != "")
            {
                string bname = Bookname.Text;
                string bauthor = authorname.Text;
                string publ = bookpubl.Text;
                string pdate = bookdate.Text;
                Int64 price = Int64.Parse(bookprice.Text);
                Int64 quan = Int64.Parse(bookquan.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into Newboook(bName,bAuthor, bPubl, bPDate, bPrice, bQuan)values('" + bname + "','" + bauthor + "','" + publ + "','" + pdate + "'," + price + "," + quan + ")";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bookname.Clear();
                authorname.Clear();
                bookpubl.Clear();
                bookquan.Clear();
                bookprice.Clear();
            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? This will delete your unsaved data", "Are you sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
