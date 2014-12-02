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
using System.IO;
using System.Diagnostics;
using GemBox.Document;


public class ResumeBuilder
{
    public List<Job> jobList = new List<Job>();

    public ResumeBuilder()
    {

    }

    private String nameRes;
    public string NameRes
    {
        get { return nameRes; }
        set { this.nameRes = value; }
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


}

public class Job
{

    public Job()
    {

    }

    private String jobTitle;
    public string JobTitle
    {
        get { return jobTitle; }
        set { jobTitle = value; }
    }

    private String jobDuties;
    public string JobDuties
    {
        get { return jobDuties; }
        set { jobDuties = value; }
    }

    private String companyName;
    public string CompanyName
    {
        get { return companyName; }
        set { companyName = value; }
    }

    private String jobCityState;
    public string JobCityState
    {
        get { return jobCityState; }
        set { jobCityState = value; }
    }

    private String jobYears;
    public string JobYears
    {
        get { return jobYears; }
        set { jobYears = value; }
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

            resume.NameRes = string.Concat(fName.Text, " ", lName.Text);
            resume.AddressRes1 = stAddress.Text;
            resume.AddressRes2 = string.Concat(CityRes.Text, ", ", StateRes.Value, zipRes.Text);
            resume.PhoneNumRes = phoneRes.Text.ToString();
            resume.EmailRes = emailAddress.Text;

            if (!JobTitle1.Text.Equals(""))
            {
                Job job1 = new Job();
                job1.JobTitle = JobTitle1.Text;
                job1.JobDuties = JobDuties1.Text;
                job1.CompanyName = CompName1.Text;
                job1.JobCityState = string.Concat(JobCity1.Text, ", ", JobState1.Value);
                job1.JobYears = string.Concat(YearFrom1.Text, " - ", YearTo1.Text);

                resume.jobList.Add(job1);
            }

            if (!JobTitle2.Text.Equals(""))
            {
                Job job2 = new Job();
                job2.JobTitle = JobTitle2.Text;
                job2.JobDuties = JobDuties2.Text;
                job2.CompanyName = CompName2.Text;
                job2.JobCityState = string.Concat(JobCity2.Text, ", ", JobState2.Value);
                job2.JobYears = string.Concat(YearFrom2.Text, " - ", YearTo2.Text);

                resume.jobList.Add(job2);
            }


            if (!JobTitle3.Text.Equals(""))
            {
                Job job3 = new Job();
                job3.JobTitle = JobTitle3.Text;
                job3.JobDuties = JobDuties3.Text;
                job3.CompanyName = CompName3.Text;
                job3.JobCityState = string.Concat(JobCity3.Text, ", ", JobState3.Value);
                job3.JobYears = string.Concat(YearFrom3.Text, " - ", YearFrom3.Text);

                resume.jobList.Add(job3);
            }


            Debug.WriteLine(resume.NameRes);
            Debug.WriteLine(resume.AddressRes1);
            Debug.WriteLine(resume.AddressRes2);
            Debug.WriteLine(resume.PhoneNumRes);

            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            var document = new DocumentModel();

            Section section = new Section(document,
            new Paragraph(document,
                new Run(document, resume.NameRes)
                {
                    CharacterFormat = new CharacterFormat()
                        {
                            Size = 13,
                            Bold = true
                        }
                },
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, resume.AddressRes1),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, resume.AddressRes2),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, "Phone: " + resume.PhoneNumRes),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, resume.EmailRes))
                {
                    ParagraphFormat = new ParagraphFormat
                        {
                            Alignment = HorizontalAlignment.Center,
                            LineSpacing = 10,
                            LineSpacingRule = LineSpacingRule.AtLeast,
                            SpaceAfter = 20
                        }
                });
            document.Sections.Add(section);


            section = new Section(document,
            new Paragraph(document,
                new Run(document, "Objective")
                {
                    CharacterFormat = new CharacterFormat()
                    {
                        Size = 14,
                        Bold = true
                    }
                },
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, resume.AddressRes1),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, resume.AddressRes2),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, "Phone: " + resume.PhoneNumRes),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, resume.EmailRes))
            {
                ParagraphFormat = new ParagraphFormat
                {
                    Alignment = HorizontalAlignment.Left,
                    LineSpacing = 10,
                    LineSpacingRule = LineSpacingRule.AtLeast,
                    SpaceAfter = 20
                }
            });
            document.Sections.Add(section);

            document.Save(resume.NameRes + "Resume.docx");

        }
    }
}