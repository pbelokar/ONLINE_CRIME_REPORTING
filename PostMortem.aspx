<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PostMortem.aspx.cs" Inherits="CriminalRecordManagement.PostMortem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        
        <tr>
            <td>
                Postmortem No. :
            </td>
            <td>
                <asp:TextBox ID="txtPostMortelNo" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                FIR No. :
            </td>
            <td>
                <asp:TextBox ID="txtFirNo" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                Result of Mortem :
            </td>
            <td>
                <asp:TextBox ID="txtResultofMortem" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                Sex :
            </td>
            <td>
                <asp:TextBox ID="txtSex" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                Date of Death :
            </td>
            <td>
                <asp:TextBox ID="txtDateofDeath" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                Description of Case :
            </td>
            <td>
                <asp:TextBox ID="txtDescriptionofCase" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                House Name :
            </td>
            <td>
                <asp:TextBox ID="txtHouseName" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                 Doctor's Name :
            </td>
            <td>
                <asp:TextBox ID="txtDrName" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                Police Station :
            </td>
            <td>
                <asp:TextBox ID="txtPoliceStation" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
               <asp:Button ID="btnSave" runat="server" Text="Save"/>
            </td>
            <td>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel"/>
            </td>
        </tr>

    </table>
</asp:Content>
