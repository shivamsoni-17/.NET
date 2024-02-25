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
    public partial class DeleteForm : Form
    {
        private Database db;

        public DeleteForm()
        {
            InitializeComponent();
            db = new Database(); // Initialize your database handler here
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (int.TryParse(txtId.Text, out id))
                {
                    db.Delete(id);
                    MessageBox.Show("Person deleted successfully!");
                    txtId.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a valid ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
