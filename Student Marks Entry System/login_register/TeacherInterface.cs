using login_register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marks_entry
{
    public partial class TeacherInterface : Form
    {
        public TeacherInterface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
            uc.BringToFront();

        }
        private void enterMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterMarks uc = new EnterMarks();
            addUserControl(uc);
        }

        private void updateMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMarks uc = new UpdateMarks();
            addUserControl(uc);
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            All uc = new All();
            addUserControl(uc);
        }

        private void particularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Particular uc = new Particular();
            addUserControl(uc);
        }
    }
}
