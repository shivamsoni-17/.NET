using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class CreateForm : Form
    {
        private Database db;

        public CreateForm()
        {
            InitializeComponent();
            db = new Database();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Person newPerson = new Person
                {
                    Id = int.Parse(txtId.Text),
                    Name = txtName.Text,
                    Age = int.Parse(txtAge.Text) // Add validation or try-catch to handle non-integer input
                };

                db.Create(newPerson);

                MessageBox.Show("Person created successfully!");

                txtId.Clear();
                txtName.Clear();
                txtAge.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid age.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
