using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace marks_entry
{
    public partial class EnterMarks : UserControl
    {
        private string connectionString = @"Data Source=DESKTOP-48MSCTF\SQLEXPRESS;Initial Catalog=data_center;Integrated Security=True";
        public EnterMarks()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string registerNo = textBox2.Text;
            string name = textBox1.Text;
            string semester = textBox3.Text;
            string mad = textBox4.Text;
            string platformTechnology = textBox5.Text;
            string iem = textBox8.Text;
            string atcd = textBox6.Text;
            string computerNetworks = textBox7.Text;

            
            if (string.IsNullOrWhiteSpace(registerNo) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(semester))
            {
                MessageBox.Show("Please fill in all mandatory fields.");
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
                            MessageBox.Show("Data saved successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Data was not saved.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

    }

}
