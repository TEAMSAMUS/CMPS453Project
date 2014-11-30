using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAWorksSite
{
    public partial class UploadResume : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {

            if (FileUploadControl.HasFile)
            {
                try
                {

                    if (FileUploadControl.PostedFile.ContentType.Equals("application/pdf") || 
                        FileUploadControl.PostedFile.ContentType.Equals("application/msword") ||
                        FileUploadControl.PostedFile.ContentType.Equals("application/vnd.openxmlformats-officedocument.wordprocessingml.document"))
                    {
                        if (FileUploadControl.PostedFile.ContentLength < 102400)
                        {
                            //Stuff to do file upload to LAWorks site
                            StatusLabel.Text = "Upload status: File uploaded!";
                        }
                        else //Else for File Size
                            StatusLabel.Text = "Upload status: The file has to be less than 100 kb!";
                    }
                    else //Else for File Content Type
                        StatusLabel.Text = "Upload status: Only Word/PDF files are accepted!";
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
        }
    }
    
}