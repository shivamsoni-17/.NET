using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace marks_entry
{
    public partial class All : UserControl
    {
        private string connectionString = @"Data Source=DESKTOP-48MSCTF\SQLEXPRESS;Initial Catalog=data_center;Integrated Security=True";

        public All()
        {
            InitializeComponent();
            LoadStudentsData();
        }

        private void LoadStudentsData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand c = new SqlCommand("SELECT COUNT(*) FROM Students", con);
                    int cn = (int)c.ExecuteScalar();
                    if(cn == 0)
                    {
                        label1.Text = "No data Found";
                        label1.ForeColor = System.Drawing.Color.Red;
                        return;
                    }

                    label1.Text = "Total number of students: " + cn;
                    label1.ForeColor = System.Drawing.Color.Green;

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Students", con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    listViewStudents.Columns.Add("RegisterNo", 100000);
                    listViewStudents.Columns.Add("Name", -2);
                    listViewStudents.Columns.Add("Semester", -2);
                    listViewStudents.Columns.Add("Mad", -2);
                    listViewStudents.Columns.Add("IEM", -2);
                    listViewStudents.Columns.Add("Platform_Technology", -2);
                    listViewStudents.Columns.Add("Computer_Networks", -2);
                    listViewStudents.Columns.Add("ATCD", -2);

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["RegisterNo"].ToString());
                        item.SubItems.Add(reader["Name"].ToString());
                        item.SubItems.Add(reader["Semester"].ToString());
                        item.SubItems.Add(reader["MAD"].ToString());
                        item.SubItems.Add(reader["IEM"].ToString());
                        item.SubItems.Add(reader["Platform_Technology"].ToString());
                        item.SubItems.Add(reader["Computer_Networks"].ToString());
                        item.SubItems.Add(reader["ATCD"].ToString());

                        listViewStudents.Items.Add(item);
                    }

                    foreach (ColumnHeader column in listViewStudents.Columns)
                    {
                        column.Width = -2; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
