using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

public class Result
{
    public Result()
    {

    }

    private String date;
    public string Date
    {
        get { return date; }
        set { this.date = value; }
    }

    private String title;
    public string Title
    {
        get { return title; }
        set { this.title = value; }
    }

    private String employer;
    public string Employer
    {
        get { return employer; }
        set { this.employer = value; }
    }

    private String location;
    public string Location
    {
        get { return location; }
        set { this.location = value; }
    }

    private String salary;
    public string Salary
    {
        get { return salary; }
        set { this.salary = value; }
    }

    private String jobSpecs;
    public string JobSpecs
    {
        get { return jobSpecs; }
        set { this.jobSpecs = value; }
    }

}

namespace LAWorksSite
{
    public partial class JobSearch : System.Web.UI.Page
    {

        /********************************************************************
*	Start_Thread starts the thread the bot runs on, 				*
*	Preconditions: Name an Password are valid LAHire accounts, and	*
*		the site hasn't changed navigation links and html elements.	*
*	Postconditions: The resume would have been uploaded to the site.*
********************************************************************/
        [STAThread]
        public void Start_Thread()
        {
            var thread = new Thread(Back_Thread);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }



        /********************************************************************
        *	Search Criteria													*
        *		These are some options for the search.						*
        *		KeywordVal: search by relevant KeywordVal. "Nursing" is valid.	*
        *		City: search by Louisiana City. "Lafayette" is valid.		*
        *		SalaryRange: exclude salaries out of range. Uses preset		*
        *			salary ranges, actual Salary values are not valid.		*
        *			"01" is valid for $5,000 annual salary.					*
        *			"20" is valid for $100,000 annual salary.				*
        *		EducationLevel: exclusion above educational levels. Uses	*
        *			preset levels, actual degrees and educations are not	*
        *			valid. 													*
        *			"NH":	None.											*
        *			"90":	High School Diploma or equivalent.				*
        *			"13":	1 year of college, technical, or 				*
        *				vocational schooling.								*
        *			"14":	2 years of college, technical, or 				*
        *				vocational schooling.								*
        *			"15":	3 years of college, technical, or 				*
        *				vocational schooling.								*
        *			"VC":	Vocational School Certificate.					*
        *			"AD":	Associate's Degree.								*
        *			"BD":	Bachelor's Degree.								*		
        *			"MD":	Master's Degree.								*
        *			"PD":	Doctorate Degree.								*
        *			"SD":	Specialized Degree.								*
        *		Time: exclusion by job hours worked a week.					*
        *			"1":	Full Time (30 hours or more)					*
        *			"2":	Fart Time (less than 30 hours)					*
        *			"3":	Full and Part Time								*
        *			"6":	PRN (As Needed)									*
        *			"9":	Information Not Provided						*
        ********************************************************************/
        public string KeywordVal = "Computer Science", City = "Lafayette", SalaryLowVal = "1", SalaryHighVal = "20", EducationLevel = "NH", Time = "9";



        /************************************************
        *	botName & botPass							*
        *	Internal name and password of a test LAHire	*
        *		account.								*
        ************************************************/
        private string botName = "iancallaway", botPass = "#b4DMRx8KwoQ";

        private Regex dateRegex = new Regex(@"\d\d/\d\d/\d\d\d\d");
        private Regex titleRegex = new Regex(@"<.*?>");//""[^""]*""

        /****************************************************
        *	Search_Document									*
        *	This function is an event of the WebBrowser 	*
        *		every time it finishes loading a page.		*
        *	Could only get to results page.					*
        *	Preconditions: The bot will reach this logic 	*
        *		only after starting, preconditions of 		*
        *		Start_Thread: Name and Password being valid *
        *		LAHire accounts.							*
        *	Postconditions: If the bot triggers the event on*
        *		any page that isn't: 						*
        *			"https://www.louisianaworks.net/hire/vosnet/Default.aspx"
        *			"https://www.louisianaworks.net/hire/vosnet/dashboards/default.aspx?menuid=MENU_START_PAGE_DASHBOARD"
        *			"https://www.louisianaworks.net/hire/jobbanks/jobadvopts.asp?session=jobsearch&geo=2201000000&geotype=dwl&SearchOriginator=&vrtype=&p=jobadvopts&city=&zip=&radius="
        *		which are the pages in the result building	*
        *		processs, the bot will terminate the thread.*
        ****************************************************/
        [STAThread]
        private void Search_Document(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser www = (WebBrowser)sender;
            Debug.Write(www.DocumentTitle + "\n");
            switch (e.Url.ToString())
            {
                //LOGIN
                case "https://www.louisianaworks.net/hire/vosnet/Default.aspx":
                    Debug.Write("homepage");
                    www.Document.GetElementById("txtUsername").SetAttribute("value", botName);
                    www.Document.GetElementById("txtPassword").SetAttribute("value", botPass);
                    www.Document.GetElementById("ctl00_cmdLogin").InvokeMember("click");
                    break;

                //NAVIGATE TO SEARCH PAGE
                case "https://www.louisianaworks.net/hire/vosnet/dashboards/default.aspx?menuid=MENU_START_PAGE_DASHBOARD":
                    Debug.Write("menupage");
                    www.Navigate("https://www.louisianaworks.net/hire/jobbanks/jobadvopts.asp?session=jobsearch&geo=2201000000&geotype=dwl&SearchOriginator=&vrtype=&p=jobadvopts&city=&zip=&radius=");
                    break;

                //SEARCH PAGE
                case "https://www.louisianaworks.net/hire/jobbanks/jobadvopts.asp?session=jobsearch&geo=2201000000&geotype=dwl&SearchOriginator=&vrtype=&p=jobadvopts&city=&zip=&radius=":
                    Debug.Write("searchpage");
                    www.Document.GetElementById("spnSelectedArea").InvokeMember("click");
                    www.Document.GetElementById("ff_areatypeJS").SetAttribute("value", "92");

                    www.Document.GetElementById("ff_cityJS").SetAttribute("value", City);
                    //www.Document.GetElementById("keyword").SetAttribute("value", KeywordVal);
                    www.Document.GetElementById("cboEdulevel").SetAttribute("value", EducationLevel);//drop down menu
                    //www.Document.GetElementById("salaryrange").SetAttribute("value", SalaryRange);//high
                    //www.Document.GetElementById("cboTimespan").SetAttribute("value", Time);//time

                    www.Document.GetElementById("ff_advjob_keyword").SetAttribute("value", KeywordVal);
                    www.Document.GetElementById("cboSalaryLow").SetAttribute("value", SalaryLowVal);//low
                    www.Document.GetElementById("cboSalaryHigh").SetAttribute("value", SalaryHighVal);//high
                    www.Document.GetElementById("cboJobTime").SetAttribute("value", Time);//time
                    www.Document.GetElementById("Submit").InvokeMember("click");
                    break;

                //END OF LOGIC, 
                default:
                    Debug.Write("terminus");
                    foreach (System.Windows.Forms.HtmlElement element in www.Document.GetElementById("frmJoblist").Children)
                    {
                        if (element.GetAttribute("summary").Equals("This table contains Date Last Modified, Job Title / Description Snippet, Employer, Location, Salary, Source, Key Match, Select"))
                        {
                            //now to get the tbody
                            //Debug.Write(element.FirstChild.FirstChild.NextSibling.OuterHtml);
                            System.Windows.Forms.HtmlElement iterator = element.FirstChild.FirstChild;
                            //Debug.WriteLine(iterator.OuterHtml);
                            for (int i = 0; iterator.NextSibling != null; i++)
                            {
                                iterator = iterator.NextSibling;
                                if (iterator.FirstChild != null
                                    && iterator.FirstChild.InnerHtml != null
                                        && iterator.FirstChild.NextSibling != null
                                        && iterator.FirstChild.NextSibling.InnerHtml != null
                                            && iterator.FirstChild.NextSibling.NextSibling != null
                                            && iterator.FirstChild.NextSibling.NextSibling.InnerHtml != null
                                                && iterator.FirstChild.NextSibling.NextSibling.NextSibling != null
                                                && iterator.FirstChild.NextSibling.NextSibling.NextSibling.InnerHtml != null
                                                    && iterator.FirstChild.NextSibling.FirstChild != null
                                                    && iterator.FirstChild.NextSibling.FirstChild.InnerHtml != null
                                    )
                                {
                                    Match dateMatch = dateRegex.Match(iterator.FirstChild.InnerHtml);
                                    if (dateMatch.Success)
                                    {
                                        Debug.WriteLine(iterator.FirstChild.NextSibling.FirstChild.InnerHtml);
                                        string myTitle = iterator.FirstChild.NextSibling.FirstChild.InnerHtml;
                                        Match titleMatch = titleRegex.Match(myTitle);
                                        while(titleMatch.Success)
                                        {
                                            myTitle = titleRegex.Replace(myTitle, "");
                                            titleMatch = titleRegex.Match(myTitle);
                                        }
                                        Result result = new Result();
                                        result.Date = dateMatch.Value;
                                        //result.Title = iterator.FirstChild.NextSibling.FirstChild.FirstChild.InnerHtml;
                                        result.Title = myTitle;
                                        //result.Title = iterator.FirstChild.NextSibling.FirstChild.FirstChild.InnerHtml;
                                        result.Employer = iterator.FirstChild.NextSibling.NextSibling.InnerHtml.Substring(0, iterator.FirstChild.NextSibling.NextSibling.InnerHtml.Length - 6);
                                        result.Location = iterator.FirstChild.NextSibling.NextSibling.NextSibling.InnerHtml;
                                        result.Salary = iterator.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.InnerHtml;
                                        resultList.Add(result);
                                    }
                                }
                                //results[i] = new Result();
                                //results[i].Date = iterator.FirstChild.InnerHtml.Substring(0, 10);
                                //Debug.WriteLine(iterator.OuterHtml + "\n.................................\n");
                            }
                            //Debug.WriteLine(element.FirstChild.FirstChild.NextSibling.FirstChild.InnerText);
                        }
                    }
                    Debug.Write("Done");

                    //Server.ClearError();
                    
                    
                    //Response.Clear();
                    //Context.ApplicationInstance.CompleteRequest();
                    Session["SearchRes"] = resultList;
                    _blocker.Set();
                    www.Dispose();
                    System.Windows.Forms.Application.ExitThread();
                    break;
            }
            Debug.Write("\n\n");
        }


        /************************************************
        *	Back_Thread									*
        *	The thread to be started from Start_Thread	*
        ************************************************/
        [STAThread]
        private void Back_Thread()
        {
            Debug.WriteLine("thread");
            using (WebBrowser browser = new WebBrowser())
                try
                {
                    browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(Search_Document);
                    browser.ScriptErrorsSuppressed = true;
                    browser.Navigate(new Uri("https://www.louisianaworks.net/hire/vosnet/Default.aspx"));
                    System.Windows.Forms.Application.Run();
                }
                catch (Exception)
                {
                    Debug.WriteLine("exception");
                }
            Thread.CurrentThread.Join();
        }

        AutoResetEvent _blocker = new AutoResetEvent(false);
        List<Result> resultList = new List<Result>();

        [STAThread]
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
           {
               keyword.Text = "";
               
           }
        }

        [STAThread]
        protected void Search_Click(object sender, EventArgs e)
        {
            

            KeywordVal = keyword.Text;
            City = jobLoc.Text;
            SalaryLowVal = SalaryLow.Value;
            SalaryHighVal = SalaryHigh.Value;
            EducationLevel = education.SelectedValue;
            Time = hoursRes.Value;

            Start_Thread();
            //Do bot stuff

            //Adds resultList to the session data
            //Session["SearchRes"] = resultList;
            _blocker.WaitOne();
            HttpContext.Current.Response.Redirect("SearchResults.aspx");
            
            
        }

    }
}