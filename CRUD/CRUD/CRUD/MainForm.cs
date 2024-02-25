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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            if (!IsFormOpen(typeof(CreateForm)))
            {
                CreateForm createForm = new CreateForm
                {
                    MdiParent = this
                };
                createForm.Show();
            }
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(ReadForm)))
            {
                ReadForm readForm = new ReadForm
                {
                    MdiParent = this
                };
                readForm.Show();
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(UpdateForm)))
            {
                UpdateForm updateForm = new UpdateForm
                {
                    MdiParent = this
                };
                updateForm.Show();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(DeleteForm)))
            {
                DeleteForm deleteForm = new DeleteForm
                {
                    MdiParent = this
                };
                deleteForm.Show();
            }
        }


        private bool IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == formType)
                {
                    form.Activate();
                    return true;
                }
            }
            return false;
        }
    }
}
