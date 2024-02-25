using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace Web_Student_Entry_System
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-48MSCTF\SQLEXPRESS;Initial Catalog=data_center;Integrated Security=True");

        protected void Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                ShowErrorMessage("Please enter username and password.");
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
                    con.Open();
                    q = "Select role from [user] where username = '" + UsernameTextBox.Text + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    object r = cmd.ExecuteScalar();
                    String role = r.ToString();

                    ShowErrorMessage("Login Successful");

                    if (role.Equals("Teacher   "))
                    {
                        Response.Redirect("TeacherInterface.aspx");
                    }
                    else
                    {
                        StudentInterface si = new StudentInterface();
                        Response.Redirect("StudentInterface.aspx");
                    }


                }

                else
                {
                    ShowErrorMessage("Invalid Username or Password");

                    UsernameTextBox.Text = string.Empty;
                    PasswordTextBox.Text = string.Empty;

                    UsernameTextBox.Focus();
                }

            }
            catch
            {
                ShowErrorMessage("Invalid Username or Password");
            }
            
            finally
            {
                con.Close();
            }
        }
        protected void Clear_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;

        }

        protected void ShowErrorMessage(string message)
        {
            ErrorMessageLabel.Text = message;
            ErrorMessageLabel.Visible = true;
        }

    }
}