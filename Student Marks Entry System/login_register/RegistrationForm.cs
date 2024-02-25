using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace marks_entry
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-48MSCTF\SQLEXPRESS;Initial Catalog=data_center;Integrated Security=True");
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            bool gen = false,rol = false;

            RadioButton selectedGender = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
            if (selectedGender != null)
            {
                gen = true;
            }

            RadioButton selectedRole = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
            if(selectedRole != null)
            {
                rol = true;
            }

            if (string.IsNullOrEmpty(Name_textbox.Text) || string.IsNullOrEmpty(Username_textbox.Text) || string.IsNullOrEmpty(Password_textbox.Text) || !gen || !rol)
            {
                MessageBox.Show("Please enter the data.");
                return;
            }

            if(!ValidateUsername())
            {
                MessageBox.Show("Enter different Username*");
                return;
            }

            String username, password, email, name, role, gender;
            username = Username_textbox.Text;
            name = Name_textbox.Text;
            password = Password_textbox.Text;
            email = Email_textbox.Text;
            gender = selectedGender.Text;
            role = selectedRole.Text;

            System.Console.WriteLine(username);
            System.Console.WriteLine(name);
            System.Console.WriteLine(gender);
            System.Console.WriteLine(email);
            System.Console.WriteLine(role);
            System.Console.WriteLine(password);

            if (email == null)
            {
                email = "N/A";
            }

            String q = "INSERT INTO [user] (username,name,password,email,gender,role) VALUES (@Value1, @Value2, @Value3,@value4,@value5,@value6)";
            SqlCommand com = new SqlCommand(q,con);

            com.Parameters.AddWithValue("@value1", username);
            com.Parameters.AddWithValue("@value2", name);
            com.Parameters.AddWithValue("@value3", password);
            com.Parameters.AddWithValue("@value4", email);
            com.Parameters.AddWithValue("@value5", gender);
            com.Parameters.AddWithValue("@value6", role);
            
            
            con.Open();
            int n = com.ExecuteNonQuery();

            if (n == 1)
            {
                MessageBox.Show("Registration successful!");
                this.Close();
            }
            con.Close();
        }

        private bool ValidateUsername()
        {
            String q = "Select * from [user] where username = '" + Username_textbox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(q, con);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if(dtable.Rows.Count == 0)
            {
                Check_textbox.Text = "Good to go.";
                Check_textbox.ForeColor = Color.Green;
                Check_textbox.Visible = true;
                return true;
            }
            else
            {
                Check_textbox.Text = "username exists.";
                Check_textbox.ForeColor = Color.Red;
                Check_textbox.Visible = true;
                return false;
            }
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            ValidateUsername();
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            Name_textbox.Clear();
            var radioButtons = groupBox1.Controls.OfType<RadioButton>();
            foreach (RadioButton rb in radioButtons)
            {
                rb.Checked = false;
            }

            radioButtons = groupBox2.Controls.OfType<RadioButton>();
            foreach (RadioButton rb in radioButtons)
            {
                rb.Checked = false;
            }
            Email_textbox.Clear();
            Username_textbox.Clear();
            Password_textbox.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Password_textbox.UseSystemPasswordChar = false;
            }
            else
            {
                Password_textbox.UseSystemPasswordChar = true;
            }
        }
    }
}
