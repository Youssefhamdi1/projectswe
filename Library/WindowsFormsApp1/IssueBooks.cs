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
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand("select bName from NewBoook", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    comboBoxbooks.Items.Add(dr.GetString(i));
                }
            }
        }
        int count;
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtenrollment.Text != "")
            {
                string eid = txtenrollment.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from NewStudent where enroll='" + eid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.CommandText = "select count(std_enroll) from IRBook where std_enroll='" + eid + "' and book_return_date is null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtdep.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtsem.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtcont.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtemail.Text = ds.Tables[0].Rows[0][6].ToString();

                }
                else
                {
                    txtName.Clear();
                    txtdep.Clear();
                    txtsem.Clear();
                    txtcont.Clear();
                    txtemail.Clear();
                    MessageBox.Show("Invalid Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnissue_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {

                if (comboBoxbooks.SelectedIndex != -1 && count <= 2) {
                    string enroll = txtenrollment.Text;
                    string sname = txtName.Text;
                    string dep = txtdep.Text;
                    string sem = txtsem.Text;
                    Int64 contact = Int64.Parse(txtcont.Text);
                    string email = txtemail.Text;
                    string bookname = comboBoxbooks.Text;
                    string bookissuedate = dateTimePicker1.Text;
                    string eid = txtenrollment.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "insert into IRBook (std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date)values ('" + enroll + "','" + sname + "','" + dep + "','" + sem + "'," + contact + ",'" + email + "','" + bookname + "','" + bookissuedate + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Select Book.OR Max no of Book has been issued", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("enter valid enrollement no ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtenrollment_TextChanged(object sender, EventArgs e)
        {
            if (txtenrollment.Text == "")
            {
                txtName.Clear();
                txtdep.Clear();
                txtsem.Clear();
                txtemail.Clear();
                txtcont.Clear();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtenrollment.Clear(); 
        }

        private void btnexit_Click(object sender, EventArgs e)
        {if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {


                this.Close();
            }
        }
    }
}
