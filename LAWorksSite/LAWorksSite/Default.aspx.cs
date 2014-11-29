using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAWorksSite
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ID_JobSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }

        protected void ID_Resume_Click(object sender, EventArgs e)
        {
            Response.Redirect("Resume.aspx");
        }

        protected void ID_Upload_Click(object sender, EventArgs e)
        {
            Response.Redirect("Resume.aspx");
        }
    }
}