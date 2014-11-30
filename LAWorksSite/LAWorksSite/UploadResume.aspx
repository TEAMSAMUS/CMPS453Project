<%@ Page Title="Upload Resume | Louisiana Works Career Seeker" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UploadResume.aspx.cs" Inherits="LAWorksSite.UploadResume" %>

<asp:Content ID="UploadContent" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        <b>Select a File to Upload (Word or PDF only)</b>
        <br />
        <br />
        <asp:FileUpload ID="FileUploadControl" runat="server" />
        <br />
        <asp:Button runat="server" ID="UploadButton" Text="Upload" OnClick="UploadButton_Click" />
        <br />
        <br />
        <asp:Label runat="server" ID="StatusLabel" Text="Upload status: " />
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
