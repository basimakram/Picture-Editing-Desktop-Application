using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Pixelair
{
    public partial class UpdatePasswordForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        string passwordpattern = @"((?=.*\d)(?=.*[A-Z])(?=.*\W).{8,16})";

        public UpdatePasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
            this.Hide();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "What is your username?");
            }

            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "What is your Email?");
            }

            else
            {
                errorProvider2.Clear();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox3.Text, passwordpattern) == false)
            {
                textBox3.Focus();
                errorProvider3.SetError(this.textBox3, "Password must contain\nAt least one digit\nAt least one uppercase character\nAt least one special symbol\nLength at least 8 characters and also maximum of 16");
            }

            else
            {
                errorProvider3.Clear();
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text != textBox3.Text)
            {
                
                errorProvider4.SetError(this.textBox4, "Password did not match, Try Again!!");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "What is your username?");
            }

            else if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "What is your Email?");
            }

            else if (Regex.IsMatch(textBox3.Text, passwordpattern) == false)
            {
                textBox3.Focus();
                errorProvider3.SetError(this.textBox3, "Password must contain\nAt least one digit\nAt least one uppercase character" +
                    "\nAt least one special symbol\nLength at least 8 characters and also maximum of 16");
            }

            else if (textBox4.Text != textBox3.Text)
            {
                errorProvider4.SetError(this.textBox4, "Password did not match, Try Again!!");
            }

            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query2 = "SELECT* FROM userInfo WHERE username = @user and email = @email";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@user", textBox1.Text);
                cmd2.Parameters.AddWithValue("@email", textBox2.Text);
                con.Open();
                SqlDataReader dr2 = cmd2.ExecuteReader();

                if (dr2.HasRows == false)
                {
                    MessageBox.Show("username and email didn't match");
                }

                else
                {
                    con.Close();
                    string query = "UPDATE userInfo SET pass = @pass Where username = @user AND email = @email";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@user", textBox1.Text);
                    cmd.Parameters.AddWithValue("@email", textBox2.Text);
                    cmd.Parameters.AddWithValue("@pass", textBox3.Text);

                    try
                    {
                        SqlDataReader dr;
                        con.Open();
                        dr = cmd.ExecuteReader();
                        MessageBox.Show("Password Updated, Click OK to proceed");
                        LoginForm l = new LoginForm();
                        l.Show();
                        this.Hide();

                    }

                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message);
                    }
                    con.Close();
                }
            }

        }
    }
}
