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
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxusername_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void textBoxusername_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxusername.Text == "Username")
            {
                textBoxusername.Clear();
            }
        }

        private void textBoxpassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxpassword.Text == "Password")
            {
                textBoxpassword.Clear();
            textBoxpassword.PasswordChar = '*';
            }
        }

        private void pictureBoxyt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }

        private void pictureBoxfb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void pictureBoxig_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
    
           con.ConnectionString = "data source = DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from logzinTable where username= '"+ textBoxusername.Text + "' and pass = '"+textBoxpassword.Text+"' ";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            Da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                dashboard dsa= new dashboard();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username OR Password","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void signup_Click(object sender, EventArgs e)
        {
            signupForm ds= new signupForm();
            ds.Show();
        }
    }
}
