using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace marks_entry
{
    public partial class StudentInterface : Form
    {
        private string connectionString = @"Data Source=DESKTOP-48MSCTF\SQLEXPRESS;Initial Catalog=data_center;Integrated Security=True";

        public StudentInterface()
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
                                label2.Visible = true;
                                textBox1.Visible = true;
                                textBox3.Text = reader["Semester"].ToString();
                                label4.Visible = true;
                                textBox3.Visible = true;
                                textBox4.Text = reader["MAD"].ToString();
                                textBox5.Text = reader["Platform_Technology"].ToString();
                                textBox8.Text = reader["IEM"].ToString();
                                textBox6.Text = reader["ATCD"].ToString();
                                textBox7.Text = reader["Computer_Networks"].ToString();
                                groupBox1.Visible = true;
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
                                textBox2.Focus();
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
            textBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
