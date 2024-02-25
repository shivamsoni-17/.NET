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

namespace CRUD
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-48MSCTF\SQLEXPRESS;Initial Catalog=data_center;Integrated Security=True");

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            String username, pass;
            username = UsernameTextBox.Text;
            pass = PasswordTextBox.Text;

            try
            {
                String q = "Select * from [user] where username = '" + UsernameTextBox.Text + "' and password = '" + PasswordTextBox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(q, con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = UsernameTextBox.Text;
                    pass = PasswordTextBox.Text;

                    MessageBox.Show("Login Successful");

                    MainForm mf = new MainForm();
                    mf.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    UsernameTextBox.Clear();
                    PasswordTextBox.Clear();

                    UsernameTextBox.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Invalid Username or Password");
            }

            finally
            {
                con.Close();
            }

        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegisterForm registrationForm = new RegisterForm();
            registrationForm.ShowDialog();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();

            UsernameTextBox.Focus();
        }
    }

}
