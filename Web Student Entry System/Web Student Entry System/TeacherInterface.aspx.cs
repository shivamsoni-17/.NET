using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Student_Entry_System
{
    public partial class TeacherInterface : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void EnterMarks_Click(object sender, EventArgs e)
        {
            EnterMarks1.Visible = true;
            All1.Visible = false;
            UpdateMarks1.Visible = false;
        }

        protected void UpdateMarks_Click(object sender, EventArgs e)
        {
            UpdateMarks1.Visible = true;
            EnterMarks1.Visible = false;
            All1.Visible = false;
        }

        protected void AllMarks_Click(object sender, EventArgs e)
        {
            All1.Visible = true;
            EnterMarks1.Visible = false;
            UpdateMarks1.Visible = false;
        }

        
    }
}