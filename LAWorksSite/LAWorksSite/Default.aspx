<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LAWorksSite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        <asp:Button ID="ID_JobSearch" runat="server" Text="Job Search" href="JobSearch.aspx" OnClick="ID_JobSearch_Click" Width="126px"/>
        <br />
        <br />
        <asp:Button ID="ID_Resume" runat="server" Text="Résumé Help" href="Resume.aspx" Width="126px"/>
    </div>
</asp:Content>
