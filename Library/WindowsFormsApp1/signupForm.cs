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
    public partial class signupForm : Form
    {
        public signupForm()
        {
            InitializeComponent();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string connectionString = "data source=DESKTOP-HOB8HCV\\SQLEXPRESS; database=LibraryDB; integrated security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                   
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM logzinTable WHERE username = @username", con);
                    checkCmd.Parameters.AddWithValue("@username", usernameTextBox.Text);

                    int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                   
                    if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                    {
                        MessageBox.Show("Password and confirmation password do not match. Please re-enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    
                    SqlCommand insertCmd = new SqlCommand("INSERT INTO logzinTable (username, pass) VALUES (@username, @password)", con);
                    insertCmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                    insertCmd.Parameters.AddWithValue("@password", passwordTextBox.Text);

                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Signup Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Signup failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to cancel Signing up","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            this.Close();
        }
    }
}