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
    public partial class SignupForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        string pattern = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";

        string passwordpattern = @"((?=.*\d)(?=.*[A-Z])(?=.*\W).{8,16})";

        public SignupForm()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "First Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Last Name")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Username")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Password")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
                textBox5.UseSystemPasswordChar = true;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Confirm Password")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
                textBox6.UseSystemPasswordChar = true;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "someone@example.com")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "What is your Fisrt Name?");
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
                errorProvider2.SetError(this.textBox2, "What is your Surname?");
            }

            else
            {
                errorProvider2.Clear();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) == true)
            {
                textBox3.Focus();
                errorProvider3.SetError(this.textBox3, "Enter a username!");
            }

            else
            {
                errorProvider3.Clear();
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox4.Text, pattern) == false)
            {
                textBox4.Focus();
                errorProvider4.SetError(this.textBox4, "Invalid Email");
            }

            else
            {
                errorProvider4.Clear();
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                comboBox1.Focus();
                errorProvider7.SetError(this.comboBox1, "Please Specify Your Gender");
            }

            else
            {
                errorProvider7.Clear();
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox5.Text, passwordpattern) == false)
            {
                textBox5.Focus();
                errorProvider5.SetError(this.textBox5, "Password must contain\nAt least one digit\nAt least one uppercase character\nAt least one special symbol\nLength at least 8 characters and also maximum of 16");
            }

            else
            {
                errorProvider5.Clear();
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text != textBox5.Text)
            {
                textBox6.Focus();
                errorProvider6.SetError(this.textBox6, "Password did not match, Try Again!!");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "What is your Fisrt Name?");
            }

            else if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "What is your Surname?");
            }

            else if (string.IsNullOrEmpty(textBox3.Text) == true)
            {
                textBox3.Focus();
                errorProvider3.SetError(this.textBox3, "Enter a username!");
            }

            else if (Regex.IsMatch(textBox4.Text, pattern) == false)
            {
                textBox4.Focus();
                errorProvider4.SetError(this.textBox4, "Invalid Email");
            }

            else if (comboBox1.SelectedItem == null)
            {
                comboBox1.Focus();
                errorProvider7.SetError(this.comboBox1, "Please Specify Your Gender");
            }

            else if (Regex.IsMatch(textBox5.Text, passwordpattern) == false)
            {
                textBox5.Focus();
                errorProvider5.SetError(this.textBox5, "Password must contain\nAt least one digit\nAt least one uppercase character\nAt least one special symbol\nLength at least 8 characters and also maximum of 16");
            }

            if (textBox6.Text != textBox5.Text)
            {
                textBox6.Focus();
                errorProvider6.SetError(this.textBox6, "Password did not match, Try Again!!");
            }

            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query2 = "SELECT* FROM userInfo WHERE username = @user";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@user", textBox3.Text);
                con.Open();
                SqlDataReader dr2 = cmd2.ExecuteReader();

                if (dr2.HasRows == true)
                {
                    MessageBox.Show("username already exists");
                }

                else
                {
                    con.Close();
                    string query = "insert into userInfo Values(@firstname, @lastname, @user, @email, @gender, @pass)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@firstname", textBox1.Text);
                    cmd.Parameters.AddWithValue("@lastname", textBox2.Text);
                    cmd.Parameters.AddWithValue("@user", textBox3.Text);
                    cmd.Parameters.AddWithValue("email", textBox4.Text);
                    cmd.Parameters.AddWithValue("@gender", comboBox1.SelectedItem);
                    cmd.Parameters.AddWithValue("@pass", textBox5.Text);


                    con.Open();
                    int a = cmd.ExecuteNonQuery();

                    if (a > 0)
                    {
                        MessageBox.Show("Account Created Successfully, Click OK to continue");
                        LoginForm l = new LoginForm();
                        l.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Failed");
                    }

                    con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenuForm mf = new MainMenuForm();
            mf.Show();
            this.Hide();
        }
    }
}
