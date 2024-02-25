using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.UI.WebControls;

namespace Web_Student_Entry_System
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-48MSCTF\SQLEXPRESS;Initial Catalog=data_center;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            // Initialization code here
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string gen = gender.SelectedValue;
            string r = role.SelectedValue;

            if (string.IsNullOrEmpty(fullName.Text) || string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(gen) || string.IsNullOrEmpty(r))
            {
                ShowErrorMessage("[Please enter the data.]");
                return;
            }

            if (!ValidateUsername())
            {
                ShowErrorMessage("[Enter different Username*]");
                return;
            }

            string usernameValue = username.Text;
            string nameValue = fullName.Text;
            string passwordValue = password.Text;
            string emailValue = email.Text;

            if (string.IsNullOrEmpty(emailValue))
            {
                emailValue = "N/A";
            }

            string query = "INSERT INTO [user] (username,name,password,email,gender,role) VALUES (@Value1, @Value2, @Value3,@value4,@value5,@value6)";
            SqlCommand com = new SqlCommand(query, con);

            com.Parameters.AddWithValue("@value1", usernameValue);
            com.Parameters.AddWithValue("@value2", nameValue);
            com.Parameters.AddWithValue("@value3", passwordValue);
            com.Parameters.AddWithValue("@value4", emailValue);
            com.Parameters.AddWithValue("@value5", gen);
            com.Parameters.AddWithValue("@value6", r);

            con.Open();
            int n = com.ExecuteNonQuery();

            if (n == 1)
            {
                ShowErrorMessage("Registration successful!");
            }
            con.Close();
        }

        private bool ValidateUsername()
        {
            string query = "Select * from [user] where username = @username";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@username", username.Text);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count == 0)
            { 
                return true;
            }
            else
            {
                ShowErrorMessage("[username exists!]");
                return false;
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            fullName.Text = string.Empty;
            username.Text = string.Empty;
            password.Text = string.Empty;
            email.Text = string.Empty;
            gender.ClearSelection();
            role.ClearSelection();
        }


        protected void ShowErrorMessage(string message)
        {
            ErrorMessageLabel.Text = message;
            ErrorMessageLabel.Visible = true;
        }
    }
}