<%@ Page Title="Resume Builder | Louisiana Works Career Seeker" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Resume.aspx.cs" Inherits="LAWorksSite.Resume" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        <b>Resumé Builder</b>
        <div style="border: solid 4px; border-color: green; overflow: hidden; display: inline-table; padding-left: 25px; padding-right: 100px; text-align: left;">
            <p>
                <br />
                First Name:
                <asp:TextBox ID="fName" runat="server"></asp:TextBox>
                Last Name:
                <asp:TextBox ID="lName" runat="server"></asp:TextBox>
                <br />
                <br />
                Street Address:
                <asp:TextBox ID="stAddress" runat="server" Width="300"></asp:TextBox>
                City:
                <asp:TextBox ID="CityRes" runat="server"></asp:TextBox>
                State/Province:
                <select id="StateRes" runat="server">
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
                Zip Code:
                <asp:TextBox ID="zipRes" runat="server"></asp:TextBox>
                <br />
                <br />
                Phone Number:
                <asp:TextBox ID="phoneRes" runat="server" TextMode="Phone" MaxLength="10"></asp:TextBox>
                (10 Digit incl. Area Code)
                <br />
                <br />
                Contact Email: 
                <asp:TextBox ID="emailAddress" runat="server" TextMode="Email"></asp:TextBox>
                <br />
                <br />
                Education Level: 
            <asp:DropDownList ID="education" runat="server">
                <asp:ListItem Value="88">High School Equivalency Diploma</asp:ListItem>
                <asp:ListItem Value="87">High School Diploma</asp:ListItem>
                <asp:ListItem Value="13">1 Year of College or a Technical or Vocational School</asp:ListItem>
                <asp:ListItem Value="14">2 Years of College or a Technical or Vocational School</asp:ListItem>
                <asp:ListItem Value="15">3 Years of College or a Technical or Vocational School</asp:ListItem>
                <asp:ListItem Value="VC">Vocational School Certificate</asp:ListItem>
                <asp:ListItem Value="AD">Associate&#39;s Degree</asp:ListItem>
                <asp:ListItem Value="BD">Bachelor&#39;s Degree</asp:ListItem>
                <asp:ListItem Value="MD">Master&#39;s Degree</asp:ListItem>
                <asp:ListItem Value="PD">Doctorate Degree</asp:ListItem>
                <asp:ListItem Value="SD">Specialized Degree (e.g. MD, DDS)</asp:ListItem>
            </asp:DropDownList>
                <br />
                <br />
                Work Experience (Most Recent Jobs First): 
            </p>
            <div style="border: solid 1px; border-color: black; overflow: hidden; display: inline-table; text-align: left; margin-right: 50px; padding: 1em;">
                1. Job Title:
                    <asp:TextBox ID="JobTitle1" runat="server"></asp:TextBox>
                <br />
                <br />
                Job Duties:
                    <asp:TextBox ID="JobDuties1" runat="server" TextMode="MultiLine"></asp:TextBox>
                <br />
                <br />
                Company Name:<asp:TextBox ID="CompName1" runat="server"></asp:TextBox>
                <br />
                <br />
                City:<asp:TextBox ID="JobCity1" runat="server"></asp:TextBox>
                <br />
                <br />
                State/Province:
                <select id="JobState1" runat="server">
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
                Dates of Employment:
                    <asp:TextBox ID="YearFrom1" runat="server" Width="40px" MaxLength="4"></asp:TextBox>
                -
                    <asp:TextBox ID="YearTo1" runat="server" Width="40px" MaxLength="4"></asp:TextBox>

            </div>

            <div style="border: solid 1px; border-color: black; overflow: hidden; display: inline-table; text-align: left; margin-right: 50px; padding: 1em;">
                2. Job Title:
                    <asp:TextBox ID="JobTitle2" runat="server"></asp:TextBox>
                <br />
                <br />
                Job Duties:
                    <asp:TextBox ID="JobDuties2" runat="server" TextMode="MultiLine"></asp:TextBox>
                <br />
                <br />
                Company Name:<asp:TextBox ID="CompName2" runat="server"></asp:TextBox>
                <br />
                <br />
                City:<asp:TextBox ID="JobCity2" runat="server"></asp:TextBox>
                <br />
                <br />
                State/Province:
                <select id="JobState2" runat="server">
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
                Dates of Employment:
                    <asp:TextBox ID="YearFrom2" runat="server" Width="40px" MaxLength="4"></asp:TextBox>
                -
                    <asp:TextBox ID="YearTo2" runat="server" Width="40px" MaxLength="4"></asp:TextBox>
            </div>

            <div style="border: solid 1px; border-color: black; overflow: hidden; display: inline-table; text-align: left; padding: 1em;">
                3. Job Title:
                    <asp:TextBox ID="JobTitle3" runat="server"></asp:TextBox>
                <br />
                <br />
                Job Duties:
                    <asp:TextBox ID="JobDuties3" runat="server" TextMode="MultiLine"></asp:TextBox>
                <br />
                <br />
                Company Name:<asp:TextBox ID="CompName3" runat="server"></asp:TextBox>
                <br />
                <br />
                City:<asp:TextBox ID="JobCity3" runat="server"></asp:TextBox>
                <br />
                <br />
                State/Province:
                <select name="ctl00$Main_content$ucIndEducation$cboState" id="JobState3" runat="server">
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
                Dates of Employment:
                    <asp:TextBox ID="YearFrom3" runat="server" Width="40px" MaxLength="4"></asp:TextBox>
                -
                    <asp:TextBox ID="YearTo3" runat="server" Width="40px" MaxLength="4"></asp:TextBox>
            </div>
            <br />
            <br />
            <br />
        </div>
        <p>
            <br />
            <br />
            <asp:Button ID="SubmitResume" runat="server" Text="Build" OnClick="BuildResume" />
            <br />
            <br />
        </p>
    </div>
</asp:Content>

