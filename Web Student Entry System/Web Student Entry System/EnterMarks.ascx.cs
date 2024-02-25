using System;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Student_Entry_System
{
    public partial class EnterMarks : UserControl
    {
        private string connectionString = @"Data Source=DESKTOP-48MSCTF\SQLEXPRESS;Initial Catalog=data_center;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            // Initialization code here, if needed
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            string registerNo = TextBox2.Text;
            string name = TextBox1.Text;
            string semester = TextBox3.Text;
            string mad = TextBox4.Text;
            string platformTechnology = TextBox5.Text;
            string iem = TextBox6.Text;
            string atcd = TextBox7.Text;
            string computerNetworks = TextBox8.Text;

            if (string.IsNullOrWhiteSpace(registerNo) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(semester))
            {
                LabelMessage.Text = "Please fill in all mandatory fields.";
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Students (RegisterNo, Name, Semester, MAD, Platform_Technology, IEM, ATCD, Computer_Networks) " +
                                   "VALUES (@RegisterNo, @Name, @Semester, @MAD, @Platform_Technology, @IEM, @ATCD, @Computer_Networks)";

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
                            LabelMessage.Text = "Data saved successfully.";
                        }
                        else
                        {
                            LabelMessage.Text = "Data was not saved.";
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
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
            TextBox5.Text = string.Empty;
            TextBox6.Text = string.Empty;
            TextBox7.Text = string.Empty;
            TextBox8.Text = string.Empty;
            LabelMessage.Text = string.Empty;
        }
    }
}