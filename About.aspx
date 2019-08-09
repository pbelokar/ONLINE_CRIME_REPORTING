<%@ Page Title="About" Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CriminalRecordManagement.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>The application is intended to create an Online Crime and Criminal Record System.</h3>
    <p>The applicatipon will provide the privilege to Police Department and the Citizens to manage
        and track the various process involved in Police Investigation.
        <asp:Button ID="btnClick" runat="server" Text="Click to continue..." Width="140px" OnClick="btnClick_Click" />
    </p>
</asp:Content>
