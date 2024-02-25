using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Web_Student_Entry_System
{
    public partial class All : UserControl
    {
        private string connectionString = @"Data Source=DESKTOP-48MSCTF\SQLEXPRESS;Initial Catalog=data_center;Integrated Security=True";

        public void Page_Load(object sender, EventArgs e)
        {
            LoadStudentsData();
        }

        private void LoadStudentsData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand countCommand = new SqlCommand("SELECT COUNT(*) FROM Students", con);
                    int count = (int)countCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        LabelMessage.Text = "No data Found";
                        LabelMessage.ForeColor = System.Drawing.Color.Red;
                        return;
                    }

                    LabelMessage.Text = "Total number of students: " + count;
                    LabelMessage.ForeColor = System.Drawing.Color.Green;

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Students", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GridViewStudents.DataSource = dt;
                    GridViewStudents.DataBind();
                }
                catch (Exception ex)
                {
                    LabelMessage.Text = "Error loading data: " + ex.Message;
                    LabelMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        protected void ButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadStudentsData();
        }
    }
}