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
    public partial class UpdateForm : Form
    {
        private Database db;
        private int personId; // This should be set when selecting a person to update

        public UpdateForm()
        {
            InitializeComponent();
            db = new Database(); // Initialize your database handler here
        }

        // Call this method with the ID of the person you want to update


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Person updatedPerson = new Person
                {
                    Id = int.Parse(txtId.Text),
                    Name = txtName.Text,
                    Age = int.Parse(txtAge.Text)
                };

                bool updateSuccessful = db.Update(updatedPerson);

                if (updateSuccessful)
                {
                    MessageBox.Show("Person updated successfully!");
                }
                else
                {
                    MessageBox.Show("No person found with the provided ID.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid ID and age.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
