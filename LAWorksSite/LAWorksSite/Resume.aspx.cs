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

    private String addressRes1;
    public string AddressRes1
    {
        get { return addressRes1; }
        set { addressRes1 = value; }
    }

    private String addressRes2;
    public string AddressRes2
    {
        get { return addressRes2; }
        set { addressRes2 = value; }
    }

    private String phoneNumRes;
    public string PhoneNumRes
    {
        get { return phoneNumRes; }
        set { phoneNumRes = value; }
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
            resume.FNameRes = fName.Text;
            resume.LNameRes = lName.Text;
            resume.AddressRes1 = stAddress.Text;
            resume.AddressRes2 =  string.Concat(CityRes.Text, ", ", StateRes.SelectedValue, ", ", zipRes.Text);
            resume.PhoneNumRes = string.Concat("(", phoneRes1.Text, ")-", phoneRes2.Text, "-", phoneRes3.Text);
            System.Diagnostics.Debug.WriteLine(resume.FNameRes + " " + resume.LNameRes);
            System.Diagnostics.Debug.WriteLine(resume.AddressRes1);
            System.Diagnostics.Debug.WriteLine(resume.AddressRes2);
            System.Diagnostics.Debug.WriteLine(resume.PhoneNumRes);
        }
    }
}