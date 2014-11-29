<%@ Page Title="Upload Resume | Louisiana Works Career Seeker" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UploadResume.aspx.cs" Inherits="LAWorksSite.UploadResume" %>
<asp:Content ID="UploadContent" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
       <b>Select a File to Upload (Word or PDF only)</b>
        <br /><br />
    <asp:FileUpload id="FileUploadControl" runat="server" />
        <br />
    <asp:Button runat="server" id="UploadButton" text="Upload" onclick="UploadButton_Click" />
    <br /><br />
    <asp:Label runat="server" id="StatusLabel" text="Upload status: " />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

            
        </div>
</asp:Content>