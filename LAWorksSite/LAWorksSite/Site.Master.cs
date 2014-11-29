using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;


namespace LAWorksSite
{
    public partial class SiteMaster : MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            WebClient www = new WebClient();
            //
            string site = www.DownloadString("http://www.laworks.net/CareerSolutions.asp");//http://www.laworks.net/Stars/");

            foreach (string[] text_0_HREF_1 in getLinks(site))
            {
                //Debug.WriteLine(text_0_HREF_1[0]);
                Debug.WriteLine(text_0_HREF_1[1]);
            }

            //Debug.WriteLine(GetDivElements());

        }
        static string[] _words = { "Sam", "Dot", "Perls" };



        static string GetDivElements()
        {
            // Initialize StringWriter instance.
            StringWriter stringWriter = new StringWriter();

            // Put HtmlTextWriter in using block because it needs to call Dispose.
            using (HtmlTextWriter writer = new HtmlTextWriter(stringWriter))
            {
                // Loop over some strings.
                foreach (var word in _words)
                {
                    // Some strings for the attributes.
                    string classValue = "ClassName";
                    string urlValue = "http://www.dotnetperls.com/";
                    string imageValue = "image.jpg";

                    // The important part:
                    writer.AddAttribute(HtmlTextWriterAttribute.Class, classValue);
                    writer.RenderBeginTag(HtmlTextWriterTag.Div); // Begin #1

                    writer.AddAttribute(HtmlTextWriterAttribute.Href, urlValue);
                    writer.RenderBeginTag(HtmlTextWriterTag.A); // Begin #2

                    writer.AddAttribute(HtmlTextWriterAttribute.Src, imageValue);
                    writer.AddAttribute(HtmlTextWriterAttribute.Width, "60");
                    writer.AddAttribute(HtmlTextWriterAttribute.Height, "60");
                    writer.AddAttribute(HtmlTextWriterAttribute.Alt, "");

                    writer.RenderBeginTag(HtmlTextWriterTag.Img); // Begin #3
                    writer.RenderEndTag(); // End #3

                    writer.Write(word);

                    writer.RenderEndTag(); // End #2
                    writer.RenderEndTag(); // End #1
                }
            }
            // Return the result.
            return stringWriter.ToString();
        }

        //returns a list of 
        //string[2] = {text, href}
        static public List<string[]> getLinks(string file)
        {
            List<string[]> results = new List<string[]>();
            MatchCollection matchCollection = Regex.Matches(file, @"(<a.*?>.*?</a>)", RegexOptions.Singleline);
            foreach (Match match in matchCollection)
            {
                string[] text0HREF1 = new string[2];
                string value = match.Groups[1].Value;
                Match matchHref = Regex.Match(value, @"href=\""(.*?)\""", RegexOptions.Singleline);
                if (matchHref.Success) text0HREF1[1] = matchHref.Groups[1].Value;
                text0HREF1[0] = Regex.Replace(value, @"\s*<.*?>\s*", "", RegexOptions.Singleline); ;
                results.Add(text0HREF1);
            }
            return results;
        }


        protected void GoHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");

        }


    }

}