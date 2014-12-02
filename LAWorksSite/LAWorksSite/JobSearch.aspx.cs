using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public class Search
{

    public Search()
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

    private String salaryLowRes;
    public string SalaryLowRes
    {
        get { return salaryLowRes; }
        set { salaryLowRes = value; }
    }

    private String salaryHighRes;
    public string SalaryHighRes
    {
        get { return salaryHighRes; }
        set { salaryHighRes = value; }
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
            Search result = new Search();
            result.KeywordRes = keyword.Text;
            result.LocationRes = jobLoc.Text;
            result.SalaryLowRes = SalaryLow.Value;
            result.SalaryHighRes = SalaryHigh.Value;
            result.EducationRes = education.SelectedValue;
            result.HoursRes = hoursRes.Value;


            Response.Redirect("SearchResults.aspx");
            
        }

    }
}