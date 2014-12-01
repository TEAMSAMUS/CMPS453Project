<%@ Page Title="Resume Builder | Louisiana Works Career Seeker" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Resume.aspx.cs" Inherits="LAWorksSite.Resume" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
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
                <asp:TextBox ID="stAddress" runat="server"></asp:TextBox>
                City:
                <asp:TextBox ID="CityRes" runat="server"></asp:TextBox>
                State:
                <asp:DropDownList ID="StateRes" runat="server">
                    <asp:ListItem Value="AL">Alabama</asp:ListItem>
                    <asp:ListItem Value="AK">Alaska</asp:ListItem>
                    <asp:ListItem Value="AZ">Arizona</asp:ListItem>
                    <asp:ListItem Value="AR">Arkansas</asp:ListItem>
                    <asp:ListItem Value="CA">California</asp:ListItem>
                    <asp:ListItem Value="CO">Colorado</asp:ListItem>
                    <asp:ListItem Value="CT">Connecticut</asp:ListItem>
                    <asp:ListItem Value="DC">District of Columbia</asp:ListItem>
                    <asp:ListItem Value="DE">Delaware</asp:ListItem>
                    <asp:ListItem Value="FL">Florida</asp:ListItem>
                    <asp:ListItem Value="GA">Georgia</asp:ListItem>
                    <asp:ListItem Value="HI">Hawaii</asp:ListItem>
                    <asp:ListItem Value="ID">Idaho</asp:ListItem>
                    <asp:ListItem Value="IL">Illinois</asp:ListItem>
                    <asp:ListItem Value="IN">Indiana</asp:ListItem>
                    <asp:ListItem Value="IA">Iowa</asp:ListItem>
                    <asp:ListItem Value="KS">Kansas</asp:ListItem>
                    <asp:ListItem Value="KY">Kentucky</asp:ListItem>
                    <asp:ListItem Value="LA">Louisiana</asp:ListItem>
                    <asp:ListItem Value="ME">Maine</asp:ListItem>
                    <asp:ListItem Value="MD">Maryland</asp:ListItem>
                    <asp:ListItem Value="MA">Massachusetts</asp:ListItem>
                    <asp:ListItem Value="MI">Michigan</asp:ListItem>
                    <asp:ListItem Value="MN">Minnesota</asp:ListItem>
                    <asp:ListItem Value="MS">Mississippi</asp:ListItem>
                    <asp:ListItem Value="MO">Missouri</asp:ListItem>
                    <asp:ListItem Value="MT">Montana</asp:ListItem>
                    <asp:ListItem Value="NE">Nebraska</asp:ListItem>
                    <asp:ListItem Value="NV">Nevada</asp:ListItem>
                    <asp:ListItem Value="NH">New Hampshire</asp:ListItem>
                    <asp:ListItem Value="NJ">New Jersey</asp:ListItem>
                    <asp:ListItem Value="NM">New Mexico</asp:ListItem>
                    <asp:ListItem Value="NY">New York</asp:ListItem>
                    <asp:ListItem Value="NC">North Carolina</asp:ListItem>
                    <asp:ListItem Value="ND">North Dakota</asp:ListItem>
                    <asp:ListItem Value="OH">Ohio</asp:ListItem>
                    <asp:ListItem Value="OK">Oklahoma</asp:ListItem>
                    <asp:ListItem Value="OR">Oregon</asp:ListItem>
                    <asp:ListItem Value="PA">Pennsylvania</asp:ListItem>
                    <asp:ListItem Value="RI">Rhode Island</asp:ListItem>
                    <asp:ListItem Value="SC">South Carolina</asp:ListItem>
                    <asp:ListItem Value="SD">South Dakota</asp:ListItem>
                    <asp:ListItem Value="TN">Tennessee</asp:ListItem>
                    <asp:ListItem Value="TX">Texas</asp:ListItem>
                    <asp:ListItem Value="UT">Utah</asp:ListItem>
                    <asp:ListItem Value="VT">Vermont</asp:ListItem>
                    <asp:ListItem Value="VA">Virginia</asp:ListItem>
                    <asp:ListItem Value="WA">Washington</asp:ListItem>
                    <asp:ListItem Value="WV">West Virginia</asp:ListItem>
                    <asp:ListItem Value="WI">Wisconsin</asp:ListItem>
                    <asp:ListItem Value="WY">Wyoming</asp:ListItem>
                </asp:DropDownList>
                Zip Code:
                <asp:TextBox ID="zipRes" runat="server"></asp:TextBox>
                <br />
                <br />
                Phone Number:
                (<asp:TextBox ID="phoneRes1" runat="server" Width="30px" MaxLength="3"></asp:TextBox>) - 
                <asp:TextBox ID="phoneRes2" runat="server" Width="30px" MaxLength="3"></asp:TextBox> - 
                <asp:TextBox ID="phoneRes3" runat="server" Width="40px" MaxLength="4"></asp:TextBox>
                <br />
                <br />
                Education Level: 
            <asp:DropDownList ID="education" runat="server">
                <asp:ListItem Value="SomeHS">Some High School</asp:ListItem>
                <asp:ListItem Value="GradHS">High School Degree</asp:ListItem>
                <asp:ListItem Value="SomeColl">Some College</asp:ListItem>
                <asp:ListItem Value="CollAsso">Associate's Degree</asp:ListItem>
                <asp:ListItem Value="CollBach">Bachelor's Degree</asp:ListItem>
                <asp:ListItem Value="CollMast">Master's Degree/ PhD</asp:ListItem>
            </asp:DropDownList>
                <br />
                <br />
                Desired Hours: 
                <asp:RadioButtonList ID="hoursButtons" runat="server" RepeatDirection="Vertical" CellPadding="0">
                    <asp:ListItem Selected="True" Value="partTime">Part-Time (Less than 40)</asp:ListItem>
                    <asp:ListItem Value="fullTime">Full-Time (40 or More)</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                Expreience Level: 
                <asp:RadioButtonList ID="experienceLevel" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value="entry">Entry</asp:ListItem>
                    <asp:ListItem Value="intermediate">Intermediate</asp:ListItem>
                    <asp:ListItem Value="expert">Expert</asp:ListItem>
                </asp:RadioButtonList>
            </p>
        </div>
        <p>
            <br />
            <br />
            <asp:Button ID="CommitSearch" runat="server" Text="Search" OnClick="BuildResume" />
            <br />
            <br />
        </p>
    </div>
</asp:Content>
