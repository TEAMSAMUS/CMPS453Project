using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public class ResumeBuilder
{

    public ResumeBuilder()
    {

    }

    private String fNameRes;
    public string FNameRes
    {
        get { return fNameRes; }
        set { this.fNameRes = value; }
    }

    private String lNameRes;
    public string LNameRes
    {
        get { return lNameRes; }
        set { lNameRes = value; }
    }

    private String addressRes;
    public string AddressRes
    {
        get { return addressRes; }
        set { addressRes = value; }
    }

    private String educationRes;
    public string EducationRes
    {
        get { return educationRes; }
        set { educationRes = value; }
    }

    private String emailRes;
    public string EmailRes
    {
        get { return emailRes; }
        set { emailRes = value; }
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


    public partial class Resume : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BuildResume(object sender, EventArgs e)
        {
            ResumeBuilder resume = new ResumeBuilder();
            resume.AddressRes =  string.Concat(stAddress.Text, " ", CityRes.Text, ", ", StateRes.SelectedValue, " ", zipRes.Text);
            System.Diagnostics.Debug.WriteLine(resume.AddressRes);
        }
    }
}