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
using System.IO;
using System.Diagnostics;
using GemBox.Document;
using GemBox.Document.Tables;


public class ResumeBuilder
{
    public List<Job> jobList = new List<Job>();
    public List<JobReference> refList = new List<JobReference>();

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

    private String objectiveRes;
    public string ObjectiveRes
    {
        get { return objectiveRes; }
        set { objectiveRes = value; }
    }

    private String abilitySumRes;
    public string AbilitySumRes
    {
        get { return abilitySumRes; }
        set { abilitySumRes = value; }
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

    private String issuingSchool;
    public string IssuingSchool
    {
        get { return issuingSchool; }
        set { issuingSchool = value; }
    }

    private String courseStudy;
    public string CourseStudy
    {
        get { return courseStudy; }
        set { courseStudy = value; }
    }

    private String academicHonors;
    public string AcademicHonors
    {
        get { return academicHonors; }
        set { academicHonors = value; }
    }

    private String honorsActivities;
    public string HonorsActivities
    {
        get { return honorsActivities; }
        set { honorsActivities = value; }
    }

    private String addInfo;
    public string AddInfo
    {
        get { return addInfo; }
        set { addInfo = value; }
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

public class JobReference
{

    public JobReference()
    {

    }

    private String refName;
    public string RefName
    {
        get { return refName; }
        set { refName = value; }
    }

    private String refAddress;
    public string RefAddress
    {
        get { return refAddress; }
        set { refAddress = value; }
    }

    private String refPhoneNum;
    public string RefPhoneNum
    {
        get { return refPhoneNum; }
        set { refPhoneNum = value; }
    }

    private String refInfo;
    public string RefInfo
    {
        get { return refInfo; }
        set { refInfo = value; }
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
            resume.AddressRes2 = string.Concat(CityRes.Text, ", ", StateRes.Value, " ", zipRes.Text);
            resume.PhoneNumRes = phoneRes.Text.ToString();
            resume.EmailRes = emailAddress.Text;
            resume.ObjectiveRes = objectiveRes.Text;
            resume.AbilitySumRes = abilitySum.Text;
            resume.EducationRes = education.SelectedValue;
            resume.IssuingSchool = schoolRes.Text;
            resume.CourseStudy = schoolCourse.Text;
            resume.AcademicHonors = academicHonors.Text;
            resume.HonorsActivities = honorsActivities.Text;
            resume.AddInfo = addInfo.Text;


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


            if (!refName1.Text.Equals(""))
            {
                JobReference reference = new JobReference();
                reference.RefName = refName1.Text;
                reference.RefAddress = string.Concat(refAdd1.Text, " ", refCity1.Text, ", ", refState1.Value, " ", refZip1.Text);
                reference.RefPhoneNum = refPhone1.Text.ToString();
                reference.RefInfo = refInfo1.Text;

                resume.refList.Add(reference);
            }

            if (!refName2.Text.Equals(""))
            {
                JobReference reference = new JobReference();
                reference.RefName = refName2.Text;
                reference.RefAddress = string.Concat(refAdd2.Text, " ", refCity2.Text, ", ", refState2.Value, " ", refZip2.Text);
                reference.RefPhoneNum = refPhone2.Text.ToString();
                reference.RefInfo = refInfo2.Text;

                resume.refList.Add(reference);
            }


            if (!refName3.Text.Equals(""))
            {
                JobReference reference = new JobReference();
                reference.RefName = refName3.Text;
                reference.RefAddress = string.Concat(refAdd3.Text, " ", refCity3.Text, ", ", refState3.Value, " ", refZip3.Text);
                reference.RefPhoneNum = refPhone3.Text.ToString();
                reference.RefInfo = refInfo3.Text;

                resume.refList.Add(reference);
            }



            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            var document = new DocumentModel();
            document.Sections.Add(
            new Section(document,
                //Heading
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
                            LineSpacingRule = LineSpacingRule.Exactly,
                            SpaceAfter = 20
                        }
                },

                //Objective
            new Paragraph(document,
                new Run(document, "Objective")
                {
                    CharacterFormat = new CharacterFormat()
                    {
                        Size = 13.5,
                        Bold = true
                    }
                },
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, resume.ObjectiveRes),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak))
            {
                ParagraphFormat = new ParagraphFormat
                {
                    Alignment = HorizontalAlignment.Left,
                    LineSpacing = 10,
                    LineSpacingRule = LineSpacingRule.Exactly,
                    SpaceAfter = 20
                }
            },
                //Ability Summary
            new Paragraph(document,
                new Run(document, "Ability Summary")
                {
                    CharacterFormat = new CharacterFormat()
                    {
                        Size = 13.5,
                        Bold = true
                    }
                },
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, resume.AbilitySumRes),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak))
            {
                ParagraphFormat = new ParagraphFormat
                {
                    Alignment = HorizontalAlignment.Left,
                    LineSpacing = 10,
                    LineSpacingRule = LineSpacingRule.Exactly,
                    SpaceAfter = 20
                }
            },
                //Employment History
            new Paragraph(document,
                new Run(document, "Employment History")
                {
                    CharacterFormat = new CharacterFormat()
                    {
                        Size = 13.5,
                        Bold = true
                    }
                })));

            foreach (Job j in resume.jobList)
            {
                //Job
                document.Sections[0].Blocks.Add(
            new Paragraph(document,
                new Run(document, j.JobTitle)
                {
                    CharacterFormat = new CharacterFormat()
                    {
                        Size = 11,
                        Bold = true
                    }
                },
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, j.JobYears + " " + j.CompanyName))
                 {
                     ParagraphFormat = new ParagraphFormat
                     {
                         Alignment = HorizontalAlignment.Left,
                         LineSpacing = 10,
                         LineSpacingRule = LineSpacingRule.Exactly
                     }
                 });

                document.Sections[0].Blocks.Add(

                    new Paragraph(document,
                        new Run(document, j.JobCityState))
                        {
                            ParagraphFormat = new ParagraphFormat
                            {
                                Alignment = HorizontalAlignment.Right,
                                LineSpacing = 10,
                                LineSpacingRule = LineSpacingRule.Exactly
                            }
                        });

                document.Sections[0].Blocks.Add(

                    new Paragraph(document,
                        new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                        new Run(document, j.JobDuties))
                        {
                            ParagraphFormat = new ParagraphFormat
                            {
                                Alignment = HorizontalAlignment.Left,
                                LineSpacing = 10,
                                LineSpacingRule = LineSpacingRule.Exactly,
                                SpaceAfter = 20
                            }
                        });
            }

            //Eduction History
            document.Sections[0].Blocks.Add(

                    new Paragraph(document,
                        new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                        new Run(document, "Education History")
                {
                    CharacterFormat = new CharacterFormat()
                    {
                        Size = 13.5,
                        Bold = true
                    }
                },
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, "Issuing Institution")
                {
                    CharacterFormat = new CharacterFormat()
                    {
                        Bold = true
                    }
                },
                new SpecialCharacter(document, SpecialCharacterType.Tab),
                new SpecialCharacter(document, SpecialCharacterType.Tab),
                new SpecialCharacter(document, SpecialCharacterType.Tab),
                new Run(document, "Education Level")
                {
                    CharacterFormat = new CharacterFormat()
                    {
                        Bold = true
                    }
                },
                new SpecialCharacter(document, SpecialCharacterType.Tab),
                new SpecialCharacter(document, SpecialCharacterType.Tab),
                new SpecialCharacter(document, SpecialCharacterType.Tab),
                new Run(document, "Course of Study")
                {
                    CharacterFormat = new CharacterFormat()
                    {
                        Bold = true
                    }
                },

                new SpecialCharacter(document, SpecialCharacterType.LineBreak),

                new Run(document, resume.IssuingSchool),
                new SpecialCharacter(document, SpecialCharacterType.Tab),
                new SpecialCharacter(document, SpecialCharacterType.Tab),
                new SpecialCharacter(document, SpecialCharacterType.Tab),
                new Run(document, resume.EducationRes),
                new SpecialCharacter(document, SpecialCharacterType.Tab),
                new SpecialCharacter(document, SpecialCharacterType.Tab),
                new SpecialCharacter(document, SpecialCharacterType.Tab),
                new Run(document, resume.CourseStudy),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new Run(document, resume.AcademicHonors),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak)));

            //Honors and Activities
            document.Sections[0].Blocks.Add(

                    new Paragraph(document,
                        new Run(document, "Honors & Activities")
                {
                    CharacterFormat = new CharacterFormat()
                    {
                        Size = 13.5,
                        Bold = true
                    }
                },
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),

                new Run(document, resume.HonorsActivities),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak)));

            //Additional Information
            document.Sections[0].Blocks.Add(

                    new Paragraph(document,
                        new Run(document, "Additional Information")
                        {
                            CharacterFormat = new CharacterFormat()
                            {
                                Size = 13.5,
                                Bold = true
                            }
                        },
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),

                new Run(document, resume.AddInfo),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                
                //References
                new Run(document, "Detailed References")
                {
                    CharacterFormat = new CharacterFormat()
                    {
                        Size = 13.5,
                        Bold = true
                    }
                }));

            foreach (JobReference Ref in resume.refList)
            {
                //Job Reference Details
                document.Sections[0].Blocks.Add(
                    new Paragraph(document,
                    new Run(document, Ref.RefName),
                    new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                    new Run(document, Ref.RefAddress),
                    new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                    new Run(document, Ref.RefPhoneNum),
                    new SpecialCharacter(document, SpecialCharacterType.LineBreak),
                    new Run(document, Ref.RefInfo),
                    new SpecialCharacter(document, SpecialCharacterType.LineBreak)));
            }

            document.Save(resume.NameRes + "Resume.docx");

        }
    }
}