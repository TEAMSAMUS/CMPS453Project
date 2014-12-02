<%@ Page Title="Results | Louisiana Works Career Seeker" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchResults.aspx.cs" Inherits="LAWorksSite.SearchResults" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <table class="nav-justified">
        <tr>
            <td style="text-align: center; color: #FFFFFF; background-color: #296968; height: 22px; width: 20%;">Date Last Modified</td>
            <td style="text-align: center; color: #FFFFFF; background-color: #296968; height: 22px; width: 20%;">Job Title</td>
            <td style="text-align: center; color: #FFFFFF; background-color: #296968; height: 22px; width: 20%;">Employer</td>
            <td style="text-align: center; color: #FFFFFF; background-color: #296968; height: 22px; width: 20%;">Location</td>
            <td style="text-align: center; color: #FFFFFF; background-color: #296968; height: 22px; width: 20%;">Salary</td>
        </tr>
    </table>
    <table id="jobDetails" runat="server" class="nav-justified"><!-- Various Details about the Job as Described above -->
        <tr>
            <td id="date" width: 20%; style="border: thin solid #00FFFF">&nbsp;</td>
            <td id="jobTitle" width: 20%; style="border: thin solid #00FFFF">&nbsp;</td>
            <td id="employer" width: 20%; style="border: thin solid #00FFFF">&nbsp;</td>
            <td id="location" width: 20%; style="border: thin solid #00FFFF">&nbsp;</td>
            <td id="salary" width: 20%; style="border: thin solid #00FFFF">&nbsp;</td>
        </tr>

    <!-- Job Specifications / Followed by Teal-Colored Separator-->
        <tr>
            <td id="jobSpecs" colspan="5" style="border-width: thin thin thick thin; border-color: #00FFFF #00FFFF #008080 #00FFFF; border-top-style: inherit; border-right-style: solid; border-bottom-style: solid; border-left-style: solid;">&nbsp;</td>
        </tr>
    </table>
    
    
</asp:Content>