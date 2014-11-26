using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;


//GetLinks is a function where given a site's html code, returns a list of links.
namespace ConsoleApplication8
{
    class Program
    {
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
				text0HREF1[0] = Regex.Replace(value, @"\s*<.*?>\s*", "", RegexOptions.Singleline);;
				results.Add(text0HREF1);
			}
            return results;
        }
        static void Main(string[] args)
        {
            WebClient www = new WebClient();
            //
            string site = www.DownloadString("http://www.laworks.net/CareerSolutions.asp");//http://www.laworks.net/Stars/");

            foreach (string[] text_0_HREF_1 in getLinks(site))
            {
                Debug.WriteLine(text_0_HREF_1[0]);
                Debug.WriteLine(text_0_HREF_1[1]);
            }
        }
    }
}
