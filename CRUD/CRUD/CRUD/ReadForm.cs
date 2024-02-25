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
    public partial class ReadForm : Form
    {
        private Database db;

        public ReadForm()
        {
            InitializeComponent();
            db = new Database(); // Initialize your database handler here
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<Person> people = db.Read(); // Assuming Read returns a List<Person>
                dataGridView.DataSource = people;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading data: " + ex.Message);
            }
        }
    }
}
