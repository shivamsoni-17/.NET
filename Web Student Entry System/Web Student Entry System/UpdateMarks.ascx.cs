using System;
using System.Data.SqlClient;
using System.Web.UI;
namespace Web_Student_Entry_System
{
    public partial class UpdateMarks : System.Web.UI.UserControl
    {

        private string connectionString = @"Data Source=DESKTOP-48MSCTF\SQLEXPRESS;Initial Catalog=data_center;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonShowMarks_Click(object sender, EventArgs e)
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

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string registerNo = TextBoxRegNo.Text;
            string name = TextBoxName.Text;
            string semester = TextBoxSemester.Text;
            string mad = TextBoxMAD.Text;
            string platformTechnology = TextBoxPlatformTechnology.Text;
            string iem = TextBoxIEM.Text;
            string atcd = TextBoxATCD.Text;
            string computerNetworks = TextBoxComputerNetworks.Text;

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
                    string query = "UPDATE Students SET Name = @Name, Semester = @Semester, MAD = @MAD, " +
                                   "Platform_Technology = @Platform_Technology, IEM = @IEM, ATCD = @ATCD, " +
                                   "Computer_Networks = @Computer_Networks WHERE RegisterNo = @RegisterNo";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RegisterNo", registerNo);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Semester", semester);
                        cmd.Parameters.AddWithValue("@MAD", mad);
                        cmd.Parameters.AddWithValue("@Platform_Technology", platformTechnology);
                        cmd.Parameters.AddWithValue("@IEM", iem);
                        cmd.Parameters.AddWithValue("@ATCD", atcd);
                        cmd.Parameters.AddWithValue("@Computer_Networks", computerNetworks);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            LabelMessage.Text = "Data updated successfully.";
                        }
                        else
                        {
                            LabelMessage.Text = "Register No. not found or no data was updated.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    LabelMessage.Text = "An error occurred: " + ex.Message;
                }
            }
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
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

