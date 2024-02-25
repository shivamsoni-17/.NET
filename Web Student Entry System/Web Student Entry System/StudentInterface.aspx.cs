using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Student_Entry_System
{
    public partial class StudentInterface : System.Web.UI.Page
    {
        private string connectionString = @"Data Source=DESKTOP-48MSCTF\SQLEXPRESS;Initial Catalog=data_center;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Cache.SetNoStore();
                Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1));
                Response.Cache.SetNoServerCaching();
            }
        }

        protected void buttonShowMarks_Click(object sender, EventArgs e)
        {
            string registerNo = TextBoxRegNo.Text;

            if (string.IsNullOrWhiteSpace(registerNo))
            {
                LabelMessage.Text = "Please enter the Register No.";
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Students WHERE RegisterNo = @RegisterNo";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RegisterNo", registerNo);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TextBoxName.Text = reader["Name"].ToString();
                                TextBoxSemester.Text = reader["Semester"].ToString();
                                TextBoxMAD.Text = reader["MAD"].ToString();
                                TextBoxPlatformTechnology.Text = reader["Platform_Technology"].ToString();
                                TextBoxIEM.Text = reader["IEM"].ToString();
                                TextBoxATCD.Text = reader["ATCD"].ToString();
                                TextBoxComputerNetworks.Text = reader["Computer_Networks"].ToString();
                            }
                            else
                            {
                                LabelMessage.Text = "Register No. not found.";
                                ClearTextBoxes();
                                TextBoxRegNo.Focus();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LabelMessage.Text = "An error occurred: " + ex.Message;
                }
            }
        }

        protected void buttonClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            TextBoxRegNo.Focus();
        }

        protected void buttonLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        private void ClearTextBoxes()
        {
            TextBoxName.Text = string.Empty;
            TextBoxRegNo.Text = string.Empty;
            TextBoxSemester.Text = string.Empty;
            TextBoxMAD.Text = string.Empty;
            TextBoxPlatformTechnology.Text = string.Empty;
            TextBoxIEM.Text = string.Empty;
            TextBoxATCD.Text = string.Empty;
            TextBoxComputerNetworks.Text = string.Empty;
            LabelMessage.Text = string.Empty;
        }
    }
}