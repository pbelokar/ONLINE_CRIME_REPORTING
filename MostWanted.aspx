<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MostWanted.aspx.cs" Inherits="CriminalRecordManagement.MostWanted" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        
        <tr>
            <td>Name :
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Nick Name :
            </td>
            <td>
                <asp:TextBox ID="txtNickName" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Age :
            </td>
            <td>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Sex :
            </td>
            <td>
                <asp:TextBox ID="txtSex" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Description :
            </td>
            <td>
                <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
            </td>
        </tr>

         <tr>
            <td>
                <asp:Button ID="btnSave" runat="server" Text ="Save"/>
            </td>
            <td>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            </td>
        </tr>

    </table>
</asp:Content>
