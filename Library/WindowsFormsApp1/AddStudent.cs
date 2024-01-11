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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        
        

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm?","Alert",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK) 
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Clear(); 
            txtEnrollment.Clear();
            txtDepartment.Clear();
            txtSmeester.Clear();    
            txtContact.Clear();
           // txtEmail.Clear();
            txtEmail.Text = " ";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnrollment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDepartment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSmeester_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEnrollment.Text != "" && txtDepartment.Text != "" && txtSmeester.Text != "" && txtContact.Text != "" && txtSmeester.Text != ""&& txtEmail.Text!="")
            {
                string name = txtName.Text;
                string enroll = txtEnrollment.Text;
                string dep = txtDepartment.Text;
                string sem = txtSmeester.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                string email = txtEmail.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into NewStudent (sname, enroll, dep, sem, contact, email)values('" + name + "','" + enroll + "','" + dep + "','" + sem + "'," + mobile + ",'" + email + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Please Fill Empty Fields ", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //

        }
    }
}
