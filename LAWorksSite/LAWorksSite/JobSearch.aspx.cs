using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public class SearchResults
{
    TextBox keyword;
    public string Keyword
    {
        get { return keyword.Text; }
        set { keyword.Text = value; }
    }

    TextBox location;
    public string Location
    {
        get { return location.Text; }
        set { location.Text = value; }
    }

    TextBox salary;
    public string Salary
    {
        get { return salary.Text; }
        set { salary.Text = value; }
    }

    TextBox education;
    public string Education
    {
        get { return education.Text; }
        set { education.Text = value; }
    }
}

namespace LAWorksSite
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Search_Click(object sender, EventArgs e)
        {
            

            // Response.Redirect("Resume.aspx");
        }

    }
}