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
    public partial class CompleteBookDetails : Form
    {
        public CompleteBookDetails()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CompleteBookDetails_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from IRBook where book_return_date is null";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);   
            DataSet ds=new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            cmd.CommandText = "select* from IRBook where book_return_Date is not null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds1 = new DataSet();
             da.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];
        }
    }
}
