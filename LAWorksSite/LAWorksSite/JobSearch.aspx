<%@ Page Title="Job Search | Louisiana Works Career Seeker" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="JobSearch.aspx.cs" Inherits="LAWorksSite.JobSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        <div style="border: solid 4px; border-color: #339933; overflow: hidden; display: inline-table; padding-left: 25px; padding-right: 100px; text-align: left;">
            <p>
                <br />
                Enter Job Keyword(s): 
            <asp:TextBox ID="keyword" runat="server"></asp:TextBox>
                <br />
                <br />
                Select A Job Location: 
                <select id="jobLoc" runat="server">
					<option value="">None Selected</option>
					<option value="AA">AF Atl. Coast</option>
					<option value="AE">AF East Coast</option>
					<option value="AP">AF Pac. Coast</option>
					<option value="AL">Alabama</option>
					<option value="AK">Alaska</option>
					<option value="AS">American Samoa</option>
					<option value="AZ">Arizona</option>
					<option value="AR">Arkansas</option>
					<option value="CA">California</option>
					<option value="CO">Colorado</option>
					<option value="CT">Connecticut</option>
					<option value="DE">Delaware</option>
					<option value="DC">District of Columbia</option>
					<option value="FL">Florida</option>
					<option value="GA">Georgia</option>
					<option value="GU">Guam</option>
					<option value="HI">Hawaii</option>
					<option value="ID">Idaho</option>
					<option value="IL">Illinois</option>
					<option value="IN">Indiana</option>
					<option value="IA">Iowa</option>
					<option value="KS">Kansas</option>
					<option value="KY">Kentucky</option>
					<option selected="selected" value="LA">Louisiana</option>
					<option value="ME">Maine</option>
					<option value="MD">Maryland</option>
					<option value="MA">Massachusetts</option>
					<option value="MI">Michigan</option>
					<option value="MN">Minnesota</option>
					<option value="MS">Mississippi</option>
					<option value="MO">Missouri</option>
					<option value="MT">Montana</option>
					<option value="MP">N. Mariana Islands</option>
					<option value="NE">Nebraska</option>
					<option value="NV">Nevada</option>
					<option value="NH">New Hampshire</option>
					<option value="NJ">New Jersey</option>
					<option value="NM">New Mexico</option>
					<option value="NY">New York</option>
					<option value="NC">North Carolina</option>
					<option value="ND">North Dakota</option>
					<option value="OH">Ohio</option>
					<option value="OK">Oklahoma</option>
					<option value="OR">Oregon</option>
					<option value="PW">Palau</option>
					<option value="PA">Pennsylvania</option>
					<option value="PR">Puerto Rico</option>
					<option value="RI">Rhode Island</option>
					<option value="SC">South Carolina</option>
					<option value="SD">South Dakota</option>
					<option value="TN">Tennessee</option>
					<option value="TX">Texas</option>
					<option value="VI">U.S. Virgin Islands</option>
					<option value="UT">Utah</option>
					<option value="VT">Vermont</option>
					<option value="VA">Virginia</option>
					<option value="WA">Washington</option>
					<option value="WV">West Virginia</option>
					<option value="WI">Wisconsin</option>
					<option value="WY">Wyoming</option>

				</select>
                <br />
                <br />
                Preferred Salary Range: 
            <asp:DropDownList ID="salaryRange" runat="server">
                <asp:ListItem Value="<$10000">< $10,000</asp:ListItem>

            </asp:DropDownList>
                <br />
                <br />
                Education Level: 
            <asp:DropDownList ID="education" runat="server">
                <asp:ListItem value="90">High School Diploma or Equivalent</asp:ListItem>
                <asp:ListItem value="13">1 Year of College or a Technical or Vocational School</asp:ListItem>
                <asp:ListItem value="14">2 Years of College or a Technical or Vocational School</asp:ListItem>
                <asp:ListItem value="15">3 Years of College or a Technical or Vocational School</asp:ListItem>
                <asp:ListItem value="VC">Vocational School Certificate</asp:ListItem>
                <asp:ListItem value="AD">Associate&#39;s Degree</asp:ListItem>
                <asp:ListItem value="BD">Bachelor&#39;s Degree</asp:ListItem>
                <asp:ListItem value="MD">Master&#39;s Degree</asp:ListItem>
                <asp:ListItem value="PD">Doctorate Degree</asp:ListItem>
                <asp:ListItem value="SD">Specialized Degree (e.g. MD, DDS)</asp:ListItem>
            </asp:DropDownList>
                <br />
                <br />
                Desired Hours: 
                <asp:RadioButtonList ID="hoursButtons" runat="server" RepeatDirection="Vertical" CellPadding="0">
                    <asp:ListItem Selected="True" Value="partTime">Part-Time (Less than 40)</asp:ListItem>
                    <asp:ListItem Value="fullTime">Full-Time (40 or More)</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                Experience Level: 
                <asp:RadioButtonList ID="experienceLevel" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True">Entry</asp:ListItem>
                    <asp:ListItem>Intermediate</asp:ListItem>
                    <asp:ListItem>Expert</asp:ListItem>
                </asp:RadioButtonList>
            </p>
        </div>
        <p>
            <br />
            <br />
            <asp:Button ID="CommitSearch" runat="server" Text="Search" OnClick="Search_Click" />
            <br />
            <br />
        </p>
    </div>
</asp:Content>
