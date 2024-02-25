using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace marks_entry
{
    public partial class UpdateMarks : UserControl
    {

        private string connectionString = @"Data Source=DESKTOP-48MSCTF\SQLEXPRESS;Initial Catalog=data_center;Integrated Security=True";
        public UpdateMarks()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string registerNo = textBox2.Text;

            if (string.IsNullOrWhiteSpace(registerNo))
            {
                MessageBox.Show("Please enter the Register No.");
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
                                textBox1.Text = reader["Name"].ToString();
                                textBox3.Text = reader["Semester"].ToString();
                                textBox4.Text = reader["MAD"].ToString();
                                textBox5.Text = reader["Platform_Technology"].ToString();
                                textBox8.Text = reader["IEM"].ToString();
                                textBox6.Text = reader["ATCD"].ToString();
                                textBox7.Text = reader["Computer_Networks"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Register No. not found.");
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string registerNo = textBox2.Text;
            string name = textBox1.Text;
            string semester = textBox3.Text;
            string mad = textBox4.Text;
            string platformTechnology = textBox5.Text;
            string iem = textBox8.Text;
            string atcd = textBox6.Text;
            string computerNetworks = textBox7.Text;


            if (string.IsNullOrWhiteSpace(registerNo))
            {
                MessageBox.Show("Please enter the Register No.");
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
                            MessageBox.Show("Data updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Register No. not found or no data was updated.");
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
