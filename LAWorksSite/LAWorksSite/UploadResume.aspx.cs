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

                    HttpPostedFile file = FileUploadControl.PostedFile;
                    string fileName = file.FileName;
                    string filePath = Path.GetFullPath(fileName);
                    string fileExtension = "";

                    if (!string.IsNullOrEmpty(fileName))
                        fileExtension = Path.GetExtension(fileName);

                    StatusLabel.Text = fileExtension;

                    if (FileUploadControl.PostedFile.ContentType.Equals("application/pdf") || 
                        FileUploadControl.PostedFile.ContentType.Equals("application/msword") ||
                        FileUploadControl.PostedFile.ContentType.Equals("application/vnd.openxmlformats-officedocument.wordprocessingml.document"))
                    {
                        if (FileUploadControl.PostedFile.ContentLength < 102400)
                        {
                            
                            StatusLabel.Text = "Upload status: File uploaded!";
                        }
                        else
                            StatusLabel.Text = "Upload status: The file has to be less than 100 kb!";
                    }
                    else
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