using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Windows.Forms;
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

        List<Result> resultList = new List<Result>();

        /********************************************************************
        *	Searchbot														*
        *	Executes a search on the LAWorks site and returns the results.	*
        ********************************************************************/
        //class Searchbot// : System.Windows.Forms.ApplicationContext
        //{
        /************************
        *	Default Constructor	*
        ************************/
        /*public Searchbot(List<Result> resultList)
        {
            myResultList = resultList;
        }*/


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
        *		Keyword: search by relevant keyword. "Nursing" is valid.	*
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
        public string Keyword = "Nursing", City = "Lafayette", SalaryLowVal = "1", SalaryHighVal = "20", EducationLevel = "NH", Time = "9";



        /************************************************
        *	botName & botPass							*
        *	Internal name and password of a test LAHire	*
        *		account.								*
        ************************************************/
        private string botName = "iancallaway", botPass = "#b4DMRx8KwoQ";

        private Regex dateRegex = new Regex(@"\d\d/\d\d/\d\d");
        private Regex titleRegex = new Regex(@".*?-");//""[^""]*""

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
                    //www.Document.GetElementById("keyword").SetAttribute("value", Keyword);
                    www.Document.GetElementById("cboEdulevel").SetAttribute("value", EducationLevel);//drop down menu
                    //www.Document.GetElementById("salaryrange").SetAttribute("value", SalaryRange);//high
                    //www.Document.GetElementById("cboTimespan").SetAttribute("value", Time);//time

                    www.Document.GetElementById("ff_advjob_keyword").SetAttribute("value", Keyword);
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
                                if (
                                    iterator.FirstChild != null
                                    && iterator.FirstChild.InnerHtml != null
                                        && iterator.FirstChild.NextSibling != null
                                        && iterator.FirstChild.NextSibling.InnerHtml != null
                                            && iterator.FirstChild.NextSibling.NextSibling != null
                                            && iterator.FirstChild.NextSibling.NextSibling.InnerHtml != null
                                                && iterator.FirstChild.NextSibling.NextSibling.NextSibling != null
                                                && iterator.FirstChild.NextSibling.NextSibling.NextSibling.InnerHtml != null
                                    )
                                {
                                    Match dateMatch = dateRegex.Match(iterator.FirstChild.InnerHtml);
                                    if (dateMatch.Success)
                                    {
                                        Match titleMatch = titleRegex.Match(iterator.FirstChild.NextSibling.FirstChild.InnerHtml);
                                        if (titleMatch.Success)
                                        {
                                            Result result = new Result();
                                            result.Date = dateMatch.Value;
                                            result.Title = titleMatch.Value.Substring(0, titleMatch.Value.Length - 1);
                                            result.Employer = iterator.FirstChild.NextSibling.NextSibling.InnerHtml.Substring(0, iterator.FirstChild.NextSibling.NextSibling.InnerHtml.Length - 6);
                                            result.Salary = iterator.FirstChild.NextSibling.NextSibling.NextSibling.InnerHtml;
                                            result.Location = iterator.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.InnerHtml;
                                            resultList.Add(result);
                                            Debug.WriteLine(
                                                dateMatch.Value + "\t" +
                                                titleMatch.Value.Substring(0, titleMatch.Value.Length - 1) + "\t" +
                                                iterator.FirstChild.NextSibling.NextSibling.InnerHtml.Substring(0, iterator.FirstChild.NextSibling.NextSibling.InnerHtml.Length - 6) + "\t" +
                                                iterator.FirstChild.NextSibling.NextSibling.NextSibling.InnerHtml + "\t" +
                                                iterator.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.InnerHtml);
                                        }
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
                    Response.Redirect("SearchResults.aspx");
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
        //}//*/

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                keyword.Text = "";

            }
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.KeywordRes = keyword.Text;
            search.LocationRes = jobLoc.Text;
            search.SalaryLowRes = SalaryLow.Value;
            search.SalaryHighRes = SalaryHigh.Value;
            search.EducationRes = education.SelectedValue;
            search.HoursRes = hoursRes.Value;




            Start_Thread();

            Session["SearchRes"] = resultList;
            //Response.Redirect("SearchResults.aspx");

        }

    }
}