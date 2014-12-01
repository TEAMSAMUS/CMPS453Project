using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public class SearchResults
{

    public SearchResults()
    {
    
    }

    private String keywordRes;
    public string KeywordRes
    {
        get { return keywordRes; }
        set { this.keywordRes = value; }
    }

    private String locationRes;
    public string LocationRes
    {
        get { return locationRes; }
        set { locationRes = value; }
    }

    private String salaryRes;
    public string SalaryRes
    {
        get { return salaryRes; }
        set { salaryRes = value; }
    }

    private String educationRes;
    public string EducationRes
    {
        get { return educationRes; }
        set { educationRes = value; }
    }

    private String hoursRes;
    public string HoursRes
    {
        get { return hoursRes; }
        set { hoursRes = value; }
    }

    private String expRes;
    public string ExpRes
    {
        get { return expRes; }
        set { expRes = value; }
    }
}

namespace LAWorksSite
{
    public partial class JobSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
           {
               keyword.Text = "";
           }
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            SearchResults result = new SearchResults();
            result.EducationRes = education.SelectedValue;
            System.Diagnostics.Debug.WriteLine(result.EducationRes);

            
            
        }

    }
}