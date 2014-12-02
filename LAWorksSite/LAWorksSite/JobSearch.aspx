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
                City: 
                <asp:TextBox ID="jobLoc" runat="server"></asp:TextBox>
                <br />
                <br />
                Preferred Salary Range: 
                <br />
                From:
                <select id="SalaryLow" name="cboSalaryLow" runat="server">
                    <option value="">None Selected</option>
                    <option value="01">$2.50 hourly ($5,000 annually) </option>
                    <option value="02">$4.75 hourly ($10,000 annually) </option>
                    <option value="03">$7.25 hourly ($15,000 annually) </option>
                    <option value="04">$9.50 hourly ($20,000 annually) </option>
                    <option value="05">$12.00 hourly ($25,000 annually) </option>
                    <option value="06">$14.50 hourly ($30,000 annually) </option>
                    <option value="07">$16.75 hourly ($35,000 annually) </option>
                    <option value="08">$19.25 hourly ($40,000 annually) </option>
                    <option value="09">$21.75 hourly ($45,000 annually) </option>
                    <option value="10">$24.00 hourly ($50,000 annually) </option>
                    <option value="11">$26.50 hourly ($55,000 annually) </option>
                    <option value="12">$28.75 hourly ($60,000 annually) </option>
                    <option value="13">$31.25 hourly ($65,000 annually) </option>
                    <option value="14">$33.75 hourly ($70,000 annually) </option>
                    <option value="15">$36.00 hourly ($75,000 annually) </option>
                    <option value="16">$38.50 hourly ($80,000 annually) </option>
                    <option value="17">$41.00 hourly ($85,000 annually) </option>
                    <option value="18">$43.50 hourly ($90,000 annually) </option>
                    <option value="19">$45.50 hourly ($95,000 annually) </option>
                    <option value="20">$48.00 hourly ($100,000 annually) </option>
                </select>
                <br />

                To:
                <select id="SalaryHigh" name="cboSalaryHigh" runat="server">
                    <option value="">None Selected</option>
                    <option value="01">$2.50 hourly ($5,000 annually) </option>
                    <option value="02">$4.75 hourly ($10,000 annually) </option>
                    <option value="03">$7.25 hourly ($15,000 annually) </option>
                    <option value="04">$9.50 hourly ($20,000 annually) </option>
                    <option value="05">$12.00 hourly ($25,000 annually) </option>
                    <option value="06">$14.50 hourly ($30,000 annually) </option>
                    <option value="07">$16.75 hourly ($35,000 annually) </option>
                    <option value="08">$19.25 hourly ($40,000 annually) </option>
                    <option value="09">$21.75 hourly ($45,000 annually) </option>
                    <option value="10">$24.00 hourly ($50,000 annually) </option>
                    <option value="11">$26.50 hourly ($55,000 annually) </option>
                    <option value="12">$28.75 hourly ($60,000 annually) </option>
                    <option value="13">$31.25 hourly ($65,000 annually) </option>
                    <option value="14">$33.75 hourly ($70,000 annually) </option>
                    <option value="15">$36.00 hourly ($75,000 annually) </option>
                    <option value="16">$38.50 hourly ($80,000 annually) </option>
                    <option value="17">$41.00 hourly ($85,000 annually) </option>
                    <option value="18">$43.50 hourly ($90,000 annually) </option>
                    <option value="19">$45.50 hourly ($95,000 annually) </option>
                    <option value="20">$48.00 hourly ($100,000 annually) </option>
                </select>
                <br />
                <br />
                Education Level: 
            <asp:DropDownList ID="education" runat="server">
                <asp:ListItem Value="90">High School Diploma or Equivalent</asp:ListItem>
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
                Full Time / Part Time: 
                <select id='hoursRes' name='cboJobTime' size='1' runat="server">
                    <option value='1'>Full Time (30 Hours or More)</option>
                    <option value='2'>Part Time (Less than 30 Hours)</option>
                    <option value='3' selected>Full and Part Time Positions</option>
                    <option value='6'>PRN (As Needed)</option>
                    <option value='9'>Information Not Provided</option>
                </select>
                <br />
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
