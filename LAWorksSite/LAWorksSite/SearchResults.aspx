<%@ Page Title="Results | Louisiana Works Career Seeker" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchResults.aspx.cs" Inherits="LAWorksSite.SearchResults" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="nav-justified">
        <tr>
            <td style="border-color: #FFFFFF; text-align: center; color: #FFFFFF; background-color: #296968; height: 22px; width: 20%; border-right-style: solid;">Date Last Modified</td>
            <td style="border-color: #FFFFFF; text-align: center; color: #FFFFFF; background-color: #296968; height: 22px; width: 20%; border-right-style: solid;">Job Title</td>
            <td style="border-color: #FFFFFF; text-align: center; color: #FFFFFF; background-color: #296968; height: 22px; width: 20%; border-right-style: solid;">Employer</td>
            <td style="border-color: #FFFFFF; text-align: center; color: #FFFFFF; background-color: #296968; height: 22px; width: 20%; border-right-style: solid;">Location</td>
            <td style="border-color: #FFFFFF; text-align: center; color: #FFFFFF; background-color: #296968; height: 22px; width: 20%; border-left-style: solid;">Salary</td>
        </tr>
    </table>
    <table id="jobDetails" runat="server" class="nav-justified">
        <!-- Various Details about the Job as Described above -->



    </table>
    <br />
    <br />


</asp:Content>
