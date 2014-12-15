/*
 * This program will be using GemBox.Document Free for creating Word Documents
 *      in the code.
 *      GemBox.Document Free can be found at http://www.gemboxsoftware.com/document/free-version
 * 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.IO;
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
    //Date Last Modified (mm/dd/yyyy)
    //Job Title
    //Employer 
    //Location (city, state)
    //Salary

    public partial class SearchResults : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            Load_Table(sender, e);
        }

        protected void Load_Table(object sender, EventArgs e)
        {

            //Array of results from class diagram
            //while reading in results
            //Result res = new Result();
            //res.Date = resultDate;
            //res.Title = resultTitle;
            //res.Employer = resultEmployer;
            //res.Location = resultLocation;
            //res.Salary = resultSalary;
            //res.JobSpecs = jobSpecs;
            //resultList.Add(res);

            List<Result> results = (List <Result>)Session["SearchRes"];




            foreach (Result result in results)
            {
                HtmlTableRow row = new HtmlTableRow();
                HtmlTableRow rowFooter = new HtmlTableRow();
                HtmlTableRow dummyRow = new HtmlTableRow();

                var cell = new HtmlTableCell();
                cell.InnerText = result.Date;
                cell.Width = "20%";
                cell.BorderColor = "#296968";
                row.Cells.Add(cell);
                
                cell = new HtmlTableCell();
                cell.InnerText = result.Title;
                cell.Width = "20%";
                cell.BorderColor = "#296968";
                row.Cells.Add(cell);
                
                cell = new HtmlTableCell();
                cell.InnerText = result.Employer;
                cell.Width = "20%";
                cell.BorderColor = "#296968";
                row.Cells.Add(cell);
                
                cell = new HtmlTableCell();
                cell.InnerText = result.Location;
                cell.Width = "20%";
                cell.BorderColor = "#296968";
                row.Cells.Add(cell);
                
                cell = new HtmlTableCell();
                cell.InnerText = result.Salary;
                cell.Width = "20%";
                cell.BorderColor = "#296968";
                row.Cells.Add(cell);

                

                var cellFooter = new HtmlTableCell();
                cellFooter.InnerText = result.JobSpecs;
                cellFooter.ColSpan = 5;
                rowFooter.Cells.Add(cellFooter);

                jobDetails.Rows.Add(row);
                jobDetails.Rows.Add(rowFooter);
                jobDetails.Rows.Add(dummyRow);
            }
        }


    }
}

